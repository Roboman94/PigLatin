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

            Console.WriteLine("Enter word here to change to pig latin: ");
            string input = Console.ReadLine();
            Console.WriteLine();

            //string const2 = " ";
            string firstlet = input.Remove(1);
            string remaining = input.Substring(1);
            int vowelValid = VowelValid(input, remaining);
            string remVowel = RemainingIfVowel(input, remaining);
            //string remConst = RemainingConst(input, remaining, const2);


            if (vowelValid == 1)
            {
                Console.WriteLine(firstlet + remVowel + "way");

            }
            else
            {
                Console.WriteLine(remVowel + firstlet + "ay");
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
    }








}