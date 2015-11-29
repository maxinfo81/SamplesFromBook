using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorting
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            int[] bubbleSortArray = new int[7];
            for (int i = 0; i < bubbleSortArray.Length; i++)
            {
                Console.Write("{0} - number: ", i + 1);
                bubbleSortArray[i] = Int32.Parse(Console.ReadLine());
            }
            int sort;
            for (int i = 0; i < bubbleSortArray.Length; i++)
            {
                for (int j = i+1; j < bubbleSortArray.Length; j++)
                {
                    
                    if (bubbleSortArray[i] > bubbleSortArray[j])
                    {
                        
                        sort = bubbleSortArray[i];
                        bubbleSortArray[i] = bubbleSortArray[j] ;
                        bubbleSortArray[j] = sort;
                       
                    } 
                }
                Console.WriteLine(bubbleSortArray[i]);
            }
            
        }
     
    }
}
