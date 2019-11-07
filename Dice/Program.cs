using System;
using System.Collections.Generic;

namespace Dice
{
    class Program
    {

        static void Main(string[] args)
        {
            //string userInput;
            //int intVal;
            int dice;
            int face = 20;
            int test = 10000000;
            Random random = new Random();


            //Console.Write("input: ");
            //userInput = Console.ReadLine();
            //intVal = Convert.ToInt32(userInput);

            IDictionary<int, int> dict = new SortedDictionary<int, int>();

            for (int i = 1; i <= face; i++)
            {
                dict.Add(i, 0);
            }

            for (int i = 0; i < test; i++)
            {
                dice = random.Next(1, face + 1);
                dict[dice] += 1;
            }

            int tmp = 0;
            
            foreach (KeyValuePair<int, int> kp in dict)
            {
                Console.WriteLine(kp);
                tmp += kp.Value;
                
            }
            Console.WriteLine(tmp);
        }

    }
}

