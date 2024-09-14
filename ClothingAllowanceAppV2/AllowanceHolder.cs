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

        //attributes or fields 
        private string name;
        private float allowance;
        private bool bonus;
        private List<Purchase> purchases;
        private string bonusActivity;
        //methods and functions 
        //constructs an allowance holder object  

        public AllowanceHolder(string name)

        {
            this.name = name;
            this.bonusActivity = bonusActivity;
            this.purchases = new List<Purchase>();
            //Set the initial allowance to $300 
            this.allowance = 300;
            //set bonus to true 
            bonus = true;



        }



        //method that will set bonus activity 

        public string SetBonus(string selectedActivity)

        {

            return "";

        }



        //Method used to set the allowance 

        public void SetAllowance(float amount)

        {

            allowance = amount;

        }



        //Gets the allowance the allowance holder want's to do 

        public float GetAllowance()

        {

            return allowance;

        }



        //Determines if the user is still intitiled to an allowance  

        public void SetBonus(int selectedYear)
        {
            //if user is bellow $50 
            if (CalculateAllowance(selectedYear) <= 50)

            {
                bonus = false;
            }

        }


        //Gets name of the child who has purchased clothes  
        public string GetName()
        {
            return name;
        }

        //calculates the total that the user has spent  

        public float CalculateAllowance(int selectedYear)

        {
            return allowance - calculatePurchasesAmount(selectedYear);
        }



        public string Summary()

        {
            //returns a string containing all the infomation the user need to know  
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



        //Deducts the allowance from the user that is selected 

        public void DeductFromAllowance(int amount, DateTime date, string description, int selectedYear)

        {
            if (amount <= CalculateAllowance(selectedYear))
            {              
                
                MessageBox.Show("Purchase Date: " + date.Year);
                purchases.Add(new Purchase(date, description, amount));
                SetBonus(selectedYear);
            }



            else
            {

                //Message back to the user saying they can not deduct more than $300  
                Console.WriteLine("!!!! Cannot deduct more than the available allowance. !!!!");

            }

        }



        //create a method that checks if the user is able to make the purchase  
        public bool AvailableAllowance(float purchaseAmount, int selectedYear)

        {
            // check if the remaining allowance is enough to make the purchase 
            return purchaseAmount <= CalculateAllowance(selectedYear);
        }


        //sets the bonus activity for the user. 
        public void SetBonusActivity(string bonusActivity)

        {

            this.bonusActivity = bonusActivity;

        }

        // Gets the bonus of the allowance holder 

        public bool GetBonus()

        {
            return bonus;
        }


        //summary of what the allowance holder has purchased  
        public string PurchaseSummary(int selectedYear)
        {
            string purchaseSummary = "";
            foreach (var purchase in purchases)
            {
                if (purchase.GetDate().Year== selectedYear)
                {
                    purchaseSummary += purchase.purchaseSummary() + "\n";
                }
           
            }
            return purchaseSummary;
        }


        public string AllowanceHolderSummary(int selectedYear)

        {

     
            string allowanceHolderSummary = $"Name: {name}\n" + PurchaseSummary(selectedYear) + $"Allowance Remaining: ${CalculateAllowance(selectedYear)} \n";
            if (bonus)
            {
                allowanceHolderSummary += $"Bonus Activity: {bonusActivity}\n";
            }

            return allowanceHolderSummary;

        }


        public string ToString()

        {
            return "";
        }



    }

}