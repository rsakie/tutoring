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

            //villians boxGhost = new villians();
            //villians badGuy2 = new villians("EHHH", "Street Cloths",75);
            //badGuy2.EvilPowers = badGuy2.GetPowers();
            ////Console.WriteLine(badGuy2.EvilPowers);
            //Console.WriteLine(badGuy2.GetPowers());
            //        int[] numberInArray = { 4, 5, 10, 12, 23 };
            //        Sum(numberInArray);
            //    }

            //    static public void Sum(int[] myArray)
            //{
            //    int sum = 0;
            //    for (int i = 0; i < myArray.Length; i++)
            //    {
            //        sum += myArray[i];
            //    }
            //    Console.WriteLine(sum);
            //}
            //public static void sayHello(string Name)
            //{
            //    Console.WriteLine("John");
            //}
            //public static void sayGoodbye()
            //{
            //    //    Console.WriteLine("Goodbye");
            //}
            //    int firstNumber = 8;
            //        int secondNumber = 4;

            //    static public int Add(int firstNumber, int secondNumber)
            //{            int sumIt = firstNumber + secondNumber;
            //    return (sumIt);
            string[] allWords = { "hello", "friends", "happiest" };
            string longestWord = PrintLongestWord(allWords);
            Console.WriteLine(longestWord);
        }
        public static string PrintLongestWord(string[] words)
        //{// input: "hello", "friends", "happiest"
        //output: "happiest"
        {
            int longestStringLength = 0;
            foreach (string word in words)
            {
                if (word.Length > longestStringLength)
                {
                    longestStringLength = word.Length;
                }
            }
            foreach (string word in words)
            {
                if (word.Length == longestStringLength)
                {
                    return word;
                }
            }
            return "there is no longest word";





        }
    }

}

