using ClothingAllowanceAppV1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingAllowanceAppV2

{

    public class AllowanceManager

    {
        private List<AllowanceHolder> allowanceHolders = new List<AllowanceHolder>();
        private readonly List<string> NAMES = new List<string> { "Nikau Ranui", "Hana Ranui", "Tia Ranui" };
        private readonly List<string> BONUS = new List<string> { "Splash Planet", "Bowling", "Movies" };
        private int selectedYear = DateTime.Now.Year;
        public AllowanceManager()
        {
            foreach (var name in NAMES)
            {
                allowanceHolders.Add(new AllowanceHolder(name));
            }

        }


        //get the name of the allowance holder
        public List<string> GetAllHolderNames()
        {
            return allowanceHolders.Select(h => h.GetName()).ToList();
        }

        //get the name of the bonus
        public List<string> GetBonus()
        {
            return BONUS;
        }
       
        public int GetSelectYear()
        {

            return selectedYear;
        
        }
        public List<string> AllHolderNames()
        {
            return allowanceHolders.Select(h => h.GetName()).ToList();
        }


        public AllowanceHolder GetAllowanceHolderByName(string name)
        {
            return allowanceHolders.FirstOrDefault(holder => holder.GetName().Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public string GetAllowanceHolderSummary(string name)
        {
            var holder = GetAllowanceHolderByName(name);
            return holder != null ? holder.AllowanceHolderSummary(selectedYear) : "Allowance holder not found.";
        }

        internal string GetAllowanceHolderSummary(object selectedName)
        {
            throw new NotImplementedException();
        }

        public int CalculateAvailableAllowance(string searchName)
        {
            // for each loop allowance holder in allowance holders 
            foreach (AllowanceHolder allowanceHolder in allowanceHolders)

            {
                // if allowance holder name is = searchName 
                if (allowanceHolder.GetName().Equals(searchName, StringComparison.OrdinalIgnoreCase))

                {
                    // get allowance by calling GetAllowance method 
                    return (int)allowanceHolder.GetAllowance();
                }
            }

            return 0; // or some other value indicating the user was not found 

        }


        //method that will check if selected allowance holder is on track for bonus 
        public int BonusTracker(string searchName)

        {
            foreach (AllowanceHolder allowanceHolder in allowanceHolders)
            {
                if (allowanceHolder.GetName().Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    return allowanceHolder.GetBonus() ? 1 : 0; // 1 if on track for bonus, 0 if not 
                }

            }
            return -1; // user not found          
        }


        //method that will deduct allowance that user wants to spend 
        public string DeductAllowance(string searchName, int amount, DateTime date, string bonus, string description)

        {
            foreach (AllowanceHolder allowanceHolder in allowanceHolders)
            {
                //only deduct allowance if the user has enough otherwise promit a message 
                if (allowanceHolder.GetName().Equals(searchName))
                {
                    if (allowanceHolder.AvailableAllowance(amount, selectedYear))
                    {
                        allowanceHolder.DeductFromAllowance(amount, date, description, selectedYear);
                        return $"Deducted {amount} from {searchName}'s allowance. Remaining allowance: {allowanceHolder.GetAllowance()}";
                    }

                    else
                    {
                        // only deduct allowance if the user has enough otherwise prompt a message saying that they are unable to make a purchase 
                        return $"Unable to deduct {amount}. Insufficient allowance.";
                    }
                }

            }

            return "Allowance holder not found.";

        }
        //method that will set bonus activity for a chosen allowance holder 

        public string SetBonus(string searchName, string activity, int year)

        {

            foreach (AllowanceHolder allowanceHolder in allowanceHolders)

            {

                if (allowanceHolder.GetName().Equals(searchName))

                {

                    // Assuming the SetBonus method is intended to set a bonus activity. 

                    allowanceHolder.SetBonusActivity(activity, year);

                    return $"Set bonus activity for {searchName} to '{activity}'.";

                }

            }

            return "Allowance holder not found.";

        }
        public void SetYear(int selectedYear)
        {
            this.selectedYear = selectedYear;
        }

        //Creates New Allowance Holder
        public void AddAllowanceHolder(AllowanceHolder newAllowanceHolder)
        {
            allowanceHolders.Add(newAllowanceHolder);
        }

   
        public string AllowanceHolderSummary()

        {

            //provide a string with infomation like name, allowance deducted, what they have purchased ith the price attached to it 

            string allowanceHolderSummary = "";

            foreach (var allowanceHolder in allowanceHolders)

            {

                allowanceHolderSummary += allowanceHolder.AllowanceHolderSummary(selectedYear);

            }

            return allowanceHolderSummary;

        }

    }
}