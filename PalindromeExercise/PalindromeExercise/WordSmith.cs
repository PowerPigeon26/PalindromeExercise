using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            var charArray = word.ToCharArray().Reverse().ToArray();
            
            return (word.ToLower() == (new string(charArray)).ToLower());
        }

        public bool IsASuperPalindrome(string word)
        {
            string simpleString = new string(word.Where(x => !char.IsPunctuation(x)).Where(x => x != ' ').ToArray());
            string reversedString = new string(simpleString.ToCharArray().Reverse().ToArray());

            return (simpleString.ToLower() == reversedString.ToLower());
        }
    }
}
