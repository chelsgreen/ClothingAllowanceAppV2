using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundButton : Button
{    
    private int borderRadius = 24;
    private int borderWidth = 2;
    private int shadowWidth = 4;
    private int shadowDepth = 3;

    public RoundButton()
    {
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;
        this.BackColor = Color.Transparent; // Set background to transparent
        this.ForeColor = Color.Black;
        this.Padding = new Padding(borderWidth + shadowWidth, shadowWidth, borderWidth + shadowWidth, shadowWidth);

        // Ensure control is double buffered to prevent flickering
        this.DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rect = ClientRectangle;
        rect.Width -= 1; // Adjust width to account for right border clipping          
    }

    protected override void OnSizeChanged(EventArgs e)
    {
        base.OnSizeChanged(e);

        // Update the region to reflect the new size
        UpdateRegion();
    }

    private void UpdateRegion()
    {
        GraphicsPath path = GetRoundedRectangle(new Rectangle(Point.Empty, Size), borderRadius);
        this.Region = new Region(path);
    }

    private GraphicsPath GetRoundedRectangle(Rectangle rectangle, int radius)
    {
        int diameter = radius * 2;
        Size size = new Size(diameter, diameter);
        Rectangle arc = new Rectangle(rectangle.Location, size);
        GraphicsPath path = new GraphicsPath();

        // Top left arc
        path.AddArc(arc, 180, 90);

        // Top right arc
        arc.X = rectangle.Right - diameter;
        path.AddArc(arc, 270, 90);

        // Bottom right arc
        arc.Y = rectangle.Bottom - diameter;
        path.AddArc(arc, 0, 90);

        // Bottom left arc and closure
        arc.X = rectangle.Left;
        path.AddArc(arc, 90, 90);
        path.CloseFigure();

        return path;
    }

  

    protected override void OnPaintBackground(PaintEventArgs pevent)
    {
        // Do not paint background to achieve transparency
    }
}
