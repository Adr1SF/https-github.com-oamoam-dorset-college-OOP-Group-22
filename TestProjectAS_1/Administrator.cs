using System;
using System.Collections.Generic;

namespace TestProjectAS_1
{
    public class Administrator : User
    {
        

        // For the IFee
        public double amount { get; set; }
        public DateTime deadline { get; set; }
        public SortedList<DateTime,double> amountMemory { get; set; } 
        
        public Administrator(string lastName, string firstName, string email, string password, int userID): base(lastName, firstName, email, password, userID)
        {

            deadline = new DateTime(2021, 8, 1);
            amount = 7800;
            amountMemory=new SortedList<DateTime, double>();
        }

        public void displayFeeInfo()
        {
            string answer = $" The amount of the fee is {amount} euros. You have to pay it before {deadline} \n";
            
            answer += " The memory of your amount is : \n";
            foreach (KeyValuePair<DateTime, double> memory in amountMemory)
            {
                answer += "-> You paid " + memory.Value + " euros the "+memory.Key+" \n";
            }
            
            Console.WriteLine(answer);
        }

        public void updateFee(double newFee)
        {
            amountMemory.Add(DateTime.Now, amount-newFee);
            amount = newFee;
            Console.WriteLine("The new fee is "+amount);
        }




    }
}
