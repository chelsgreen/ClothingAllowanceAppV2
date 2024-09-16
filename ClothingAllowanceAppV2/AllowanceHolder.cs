using ClothingAllowanceAppV2;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingAllowanceAppV1

{

    public class AllowanceHolder
    {
        // attributes or fields 
        private string name;
        private float allowance;
        private bool bonus;
        private List<Purchase> purchases;
        private string bonusActivity;
        private Dictionary<int, string> yearlyBonusActivity;

        // Constructor
        public AllowanceHolder(string name)
        {
            this.name = name;
            this.bonusActivity = ""; // Initialize properly
            this.purchases = new List<Purchase>();
            this.allowance = 300; // Initial allowance
            this.bonus = true;
            this.yearlyBonusActivity = new Dictionary<int, string>(); 
        }

        // Method that will set bonus activity
        // Method to set bonus activity for a specific year
        public void SetBonusActivity(string selectedActivity, int year)
        {
            yearlyBonusActivity[year] = selectedActivity; // Store bonus activity for the year
        }

        // Method used to set the allowance
        public void SetAllowance(float amount)
        {
            allowance = amount;
        }

        // Gets the allowance the allowance holder wants to do
        public float GetAllowance()
        {
            return allowance;
        }

        // Determines if the user is still entitled to a bonus
       public bool SetBonus(int selectedYear)
        {
           
           //If user is below $50
           if (CalculateAllowance(selectedYear) <= 50)
            {
                bonus = false;
                return false;
                bonusActivity = ""; // Reset bonus activity
           }
            return true;  
            
       }

        public string GetBonusActivity(int year)
        {
            if (yearlyBonusActivity.ContainsKey(year))
            {
                return yearlyBonusActivity[year];
            }
            return "No bonus activity";
        }

        // Gets the name of the child who has purchased clothes  
        public string GetName()
        {
            return name;
        }

        // Calculates the total that the user has spent  
        public float CalculateAllowance(int selectedYear)
        {
            return allowance - calculatePurchasesAmount(selectedYear);
        }

        public string Summary()
        {
            // Returns a string containing all the information the user needs to know  
            string summary = $"Name: {name}\nBonus: {bonus}";
            return summary;
        }

        private float calculatePurchasesAmount(int selectedYear)
        {
            float totalPurchases = 0;
            foreach (var purchase in purchases)
            {
                if (purchase.GetDate().Year == selectedYear)
                {
                    totalPurchases += purchase.GetAmount();
                }
            }

            return totalPurchases;
        }

        // Deducts the allowance from the user that is selected 
        public void DeductFromAllowance(int amount, DateTime date, string description, int selectedYear)
        {
            if (amount <= CalculateAllowance(selectedYear))
            {
                MessageBox.Show("Purchase Date: " + date.Year);
                purchases.Add(new Purchase(date, description, amount));
                SetBonus(selectedYear); // Check if bonus needs to be updated
            }
            else
            {
                // Message back to the user saying they cannot deduct more than available allowance  
                Console.WriteLine("!!!! Cannot deduct more than the available allowance. !!!!");
            }
        }

        // Create a method that checks if the user is able to make the purchase  
        public bool AvailableAllowance(float purchaseAmount, int selectedYear)
        {
            // Check if the remaining allowance is enough to make the purchase 
            return purchaseAmount <= CalculateAllowance(selectedYear);
        }

        // Gets the bonus of the allowance holder 
        public bool GetBonus()
        {
            return bonus;
        }

        // Summary of what the allowance holder has purchased  
        public string PurchaseSummary(int selectedYear)
        {
            string purchaseSummary = "";
            foreach (var purchase in purchases)
            {
                if (purchase.GetDate().Year == selectedYear)
                {
                    purchaseSummary += purchase.purchaseSummary() + "\n";
                }
            }
            return purchaseSummary;
        }

        // Summary of the allowance holder's status
        public string AllowanceHolderSummary(int selectedYear)
        {
            string summary = $"Name: {name}\n" + PurchaseSummary(selectedYear) + $"Allowance Remaining: ${CalculateAllowance(selectedYear)} \n";

            // Display the bonus activity for the selected year
            if (yearlyBonusActivity.ContainsKey(selectedYear))
            {
                summary += $"Bonus Activity: {yearlyBonusActivity[selectedYear]}\n";
            }

            if (SetBonus(selectedYear))
            {
                summary += "You are entitled to a bonus!\n";
            }
            else
            {
                summary += "You are not entitled to a bonus.\n";
            }


            return summary;
        }

        public override string ToString()
        {
            return AllowanceHolderSummary(DateTime.Now.Year); // Or adjust according to needs
        }
    }
}
