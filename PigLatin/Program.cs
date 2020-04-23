using System;
using System.Text;
using System.Linq;
using System.Runtime.CompilerServices;

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

                //string const2 = " ";
                string firstlet = input.Remove(1);
                string remaining = input.Substring(1);
                int vowelValid = VowelValid(input, remaining);
                string remVowel = RemainingIfVowel(input, remaining);
                //string remConst = RemainingConst(input, remaining, const2);
                string[] constspl1 = null;
                string[] constspl2 = ConstSpl(input, remaining, constspl1);

                if (vowelValid == 1)
                {
                    Console.WriteLine(firstlet + remVowel + "way");
                    Console.WriteLine("{0}", constspl2);

                }
                else
                {
                    Console.WriteLine(remVowel + firstlet + "ay");
                    Console.WriteLine("{0}", constspl2);
                }

                proceeding = Proceed();


            }
        }


        //  public static string RemainingConst(string input, string remaining, string const2)
        //  {
        //    int i = 0;
        ////    char[] const1 = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };
        //   foreach (char testedchar in const1)
        //    {
        //      if (input.StartsWith(testedchar))
        //      {

        //          while (remaining.StartsWith(testedchar))
        ///           {
        ///              const2 = remaining;
        //               i++;
        //            }

        //            return const2;
        //        }
        //        else
        //        {
        //            return "error";
        //        }

        //    }
        //    return "error";
        //}





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





        public static string[] ConstSpl(string input, string remaining, string[] constspl1)
        {
            int i = 0;
            char[] vowels = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };
            foreach (char testedchar in vowels)
            {

                while (remaining.StartsWith(testedchar))
                {
                    remaining = input.Substring(i);
                    i++;
                }

                if (input.StartsWith(testedchar))
                {

                    constspl1 = input.Split(testedchar);
                }
                {
                    return null;

                }


            }
            return constspl1;
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