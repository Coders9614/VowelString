using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelString
{
    internal class Program
    {
        static void Main()
        {
            // Test cases
            string a = "hello";
            string b = "avacado";
            string c = "intelligent";
            Console.WriteLine($"Oringal chcaracters: {a}");
            Console.WriteLine(ReverseVowels(a)); // Output: "holle"
            Console.WriteLine($"Oringal chcaracters: {b}");
            Console.WriteLine(ReverseVowels(b)); // Output: "ovacada"
            Console.WriteLine($"Oringal chcaracters: {c}");
            Console.WriteLine(ReverseVowels(c)); // Output: "entillegint"
            Console.ReadKey();
        }

        static string ReverseVowels(string s)
        {

            if ( s == null )//edge case is null return null
            {
                
                return s;
            }
            // Define vowels
            HashSet<char> vowels = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            // Use a list to store the vowels in the string
            Stack<char> vowelStock = new Stack<char>();

            // Collect all the vowels from the string
            foreach (char c in s)
            {
                if (vowels.Contains(c))
                {
                    vowelStock.Push(c);
                }
            }

            // Create an array to store the result
            char[] result = s.ToCharArray();
            

            // Replace the vowels in the original string with the reversed vowels from the stack
            for (int i = 0; i < result.Length; i++)
            {
                if (vowels.Contains(result[i]))
                {
                    result[i] = vowelStock.Pop();
                }
            }

  
            // Convert the result array back to a string and return it
            return new string(result);
        }
    }
}

