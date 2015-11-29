using System;
using System.IO;

namespace Mogel1
{
    class Program
    {
        static void Main()
        {
            DirectoryInfo di = new DirectoryInfo("Data");
            if (di.Exists)
            {
                di.Delete(true);
            }
            di.Create();

            StreamWriter sv = File.CreateText("Data\\money.txt");

            sv.WriteLine("Hello");
            int debitSum = 0;
            // set income
            for (int i = 0; i < 5; i++)
            {

                int debitInt;
                string debit;
                Console.WriteLine("Enter your income:");

                debit = Console.ReadLine();
                int.TryParse(debit, out debitInt);
                debitSum += debitInt;
                int.TryParse(debit, out debitInt);
            }
            sv.WriteLine("Your income:" + debitSum.ToString());
            sv.WriteLine();
          
            // set outcome
            string credit;
            
            int creditSum = 0;

            for (int i = 0; i < 5; i++)
            {
                int creditInt;
                Console.WriteLine("Enter your outcome:");
                credit = Console.ReadLine();
                int.TryParse(credit, out creditInt);
                creditSum += creditInt;


            }

            sv.WriteLine("Your outcome:" + creditSum.ToString());
            int balance = debitSum - creditSum;

            sv.WriteLine("Your balance:" + balance.ToString());
            if (balance>0)
            {
                sv.WriteLine("You in plus");

            }
            else
            {
                sv.WriteLine("You have debts");
            }

            sv.Close();

        }
    }
}
