using System;

namespace gc_Bonus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isContinue = false;

            do
            {
                Console.WriteLine("This application will convert percent grades to letter grades");
                Console.Write("Please input your percent grade: ");
                string userInput = Console.ReadLine();
                int numGrade;
                Int32.TryParse(userInput, out numGrade);

                Console.Write("Grade: ");

                if (numGrade >= 88)
                {
                    Console.WriteLine("A");
                }

                else if (numGrade <= 87 && numGrade >= 80)
                {
                    Console.WriteLine("B");
                }

                else if (numGrade <= 79 && numGrade >= 67)
                {
                    Console.WriteLine("C");
                }

                else if (numGrade <= 66 && numGrade >= 60)
                {
                    Console.WriteLine("D");
                }

                else if (numGrade <= 59)
                {
                    Console.WriteLine("F");
                }

                Console.WriteLine("Would you like to calculate another grade? y/n");
                string response = Console.ReadLine();

                if (response == "y" || response == "Y")
                {
                    isContinue = true;
                }

                else
                {
                    isContinue = false;
                }

            } while (isContinue == true);
        }
    }
}
