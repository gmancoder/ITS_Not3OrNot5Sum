/*

Program: Not 3 or Not 5 Sum
Author: Graham R.Brewer

Description: User enters a number (n) and the program sums all numbers from 1 to n*n skipping numbers if they are divisible by 3 or divisible by 5. Numbers divisible by both 3 and 5 are included in the summerization. Once a summerization concludes, it is displayed to the user. The user can then enter another number or "end" to stop the program.

Pseudocode assumptions:
- Assuming standard AND/OR statements for combining conditionals (not stated in the language specifications)

*/

using System;

namespace Not3OrNot5Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber;
            string line;
            int square;

            Console.WriteLine("Enter a number or 'end' to quit");
            line = Console.ReadLine();
            do
            {
                int sum = 0;
                if (line != "end")
                {
                    if (Int32.TryParse(line, out inputNumber))
                    {
                        square = inputNumber * inputNumber;
                        if (square > 0)
                        {
                            foreach (int countNumber in System.Linq.Enumerable.Range(1, square))
                            {
                                if ((countNumber % 3 == 0 && countNumber % 5 == 0) || (countNumber % 3 != 0 && countNumber % 5 != 0))
                                {
                                    //Console.WriteLine(countNumber);
                                    sum = sum + countNumber;
                                }
                            }
                        }
                        Console.WriteLine(sum);
                    }
                }
                Console.WriteLine("Enter a number or 'end' to quit");
                line = Console.ReadLine();
            }
            while (line != "end");
        }
    }
}
