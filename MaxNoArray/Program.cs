using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int max = numbers[2];
            // int n=Convert.ToInt32(Console.ReadLine());
            
            for(int i = 1; i <numbers.Length ; i++)
            {
                if(numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.Write("maximum number is :" + max);

        }
        
    }
}
