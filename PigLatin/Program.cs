using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool proceeding = true;
            while (proceeding == true)
            {
                Console.WriteLine("Welcome to the PigLatin generator!");
                Console.WriteLine("Please enter message");
                string input = Console.ReadLine().ToLower().Trim();
                string[] words = input.Split();
                //Prompts user to enter message
                //turns input to lowercase and cleans unneccassary spaces
                //sends message to string array and splits words

                foreach (string word in words)
                {
                    TranslateWord(word);
                }
                //for each word in the message, convert to piglatin
                //fin
                proceeding = Proceed();
            }
        }


        public static void TranslateWord(string input)
        {
            char[] word = input.ToCharArray();
            //takes user word and changes it to a char array
            string output = "";
            //define output as ""
            int firstVowelIndex = FirstVowel(word);
            //Calls FirstVowel method and returns index position of vowel
            if (firstVowelIndex == 0)
            //if vowel index starts with a vowel
            {
                output = input + "way";
                //resulting output as input ending in way
            }
            else if (firstVowelIndex == -1)
            //if no vowels are found
            {
                output = input;
                //print output as input
            }
            else
            //if not starting with a vowel
            {
                string prefix = input.Substring(firstVowelIndex);
                
                //makes string with substring of consonants starting with the first vowel index

                string postfix = input.Substring(0, firstVowelIndex) + "ay";
               
                //makes string with substring of consonants before the first vowel index, then ending with ay
                output = prefix + postfix;
                //arranges vowel before consonants-ay
            }
            
            Console.Write(output + " ");
            //result
        }

        public static int FirstVowel(char[] word)
        {
            for (int i = 0; i < word.Length; i++)
            //loop for length of word array
            {
                char letter = word[i];
                //reassigns letter as current letter in word array
                if (IsVowel(letter))
                //if indexed letter is a vowel
                {
                    return i;
                    //return index position of vowel
                }
            }
            Console.WriteLine("Error: Vowel not found. Vowels are necessary for PigLatin!");
            return -1;
            //returns error message if no vowels are found
        }


        public static bool IsVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            //Creates array of vowels

            foreach (char vowel in vowels)
            //for each cooresponding vowel
            {
                if (vowel == c)
                //if cooresponding vowel matches indexed letter variable
                {
                    return true;
                }
            }
            return false;
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
