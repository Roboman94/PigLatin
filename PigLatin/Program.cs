using System;
using System.Linq;


namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool proceeding = true;
            while (proceeding == true)
            {
                Console.WriteLine("Enter word here to change to pig latin: ");
                string input = Console.ReadLine().ToLower();
                Console.WriteLine();

                string firstlet = input.Remove(1);
                string remaining = input.Substring(1);
                int vowelValid = VowelValid(input, remaining);
                string remVowel = RemainingIfVowel(input, remaining);
           
                if (vowelValid == 1)
                {
                    Console.WriteLine(firstlet + remVowel + "way");
                }
                else
                {
                    Console.WriteLine(remVowel + firstlet + "ay");
                }

                proceeding = Proceed();

            }
        }

        public static string RemainingIfVowel(string input, string remaining)
        {
            int i = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            foreach (char testedchar in vowels)
            {
                if (input.StartsWith(testedchar))
                {

                    while (remaining.StartsWith(testedchar))
                    {
                        remaining = input.Substring(i);
                        i++;
                    }

                    return remaining;
                }
                else
                {
                    return remaining;
                }

            }
            return "error";
        }

        public static int VowelValid(string input, string remaining)
        {
            int i = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach (char testedchar in vowels)
            {



                if (input.StartsWith(testedchar))
                {
                    return 1;

                }


            }
            return 0;
        }

        public static bool Proceed()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to continue? (y/n) ");
            string proceed = Console.ReadLine();
            if (proceed.ToLower().StartsWith("y"))
            {
                return true;
            }
            if (proceed.ToLower().StartsWith("n"))
            {
                Console.WriteLine("thank you!");
                Console.WriteLine();
                return false;
            }
            else
            {
                Console.WriteLine("Invalid entry. Please try again");
                return Proceed();
            }


        }

    }
}