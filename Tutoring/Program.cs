using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoring
{
    class Program
    {
        static void Main(string[] args)
      
        {
                int[] numberInArray = { 4, 5, 10, 12, 23 };
                Sum(numberInArray);
            }

            static public void Sum(int[] myArray)
        {
            int sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }
            Console.WriteLine(sum);
        }
    }
}
