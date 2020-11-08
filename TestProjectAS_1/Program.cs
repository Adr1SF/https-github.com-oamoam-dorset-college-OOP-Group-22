using System;

namespace TestProjectAS_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Administrator admin = new Administrator("SFEIR","Adrien","23209@gmail.com","azerty",23209);
            
            admin.displayFeeInfo();
            admin.updateFee(6000);
            admin.updateFee(5000);
            admin.displayFeeInfo();
            

            Console.WriteLine(admin.PersonalInformation());
            Console.WriteLine(admin.PublicInformation());
        }
    }
}
