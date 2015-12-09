using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInvestigation
{
    class Program
    {
        static void Main(string[] args)
        {
            MoneyEntry me = new MoneyEntry();

            Console.WriteLine("Hello");
            Console.Write("Enter sum: ");
            string amount = Console.ReadLine();
            Console.Write("Enter date: ");
            string date = Console.ReadLine();
            me.InitWithString(amount,date);

            Console.Write("Your Entry: ");
            Console.WriteLine(me.ToString());
            if (me.isDebit) 
            Console.WriteLine("You have debdt");
            else
            Console.WriteLine("You have income");
            Console.ReadKey();
        }
    }
}
