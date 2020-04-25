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
                //Prompts user to enter message
                string input = Console.ReadLine().ToLower().Trim();
                //turns input to lowercase and cleans out trailing spaces
                string[] words = input.Split();
                //sends message to string array each word is an index

                foreach (string word in words)
                {

                    TranslateWord(word);
                }
                //for each word in the message, convert to piglatin

                //fin?
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
            //Calls FirstVowel method and returns first vowel index
            if (firstVowelIndex == 0)
            //if first letter starts with a vowel
            {
                output = input + "way";
                //output is input and ending in way
            }
            else if (firstVowelIndex == -1)
            //if no vowels are found
            {
                output = input;
                //output is input
            }
            else
            //contains vowel But starts with consonants
            {
                string prefix = input.Substring(firstVowelIndex);
                //makes string with substring starting at the first vowel index

                string postfix = input.Substring(0, firstVowelIndex) + "ay";
                //makes string with substring of consonants before the first vowel index, then ending with ay

                output = prefix + postfix;
                //arranges vowel before consonants and ends in ay
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
                //reassigns letter as indexed letter in word array
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
                //if cooresponding vowel matches indexed letter variable from FirstVowel(letter)
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
