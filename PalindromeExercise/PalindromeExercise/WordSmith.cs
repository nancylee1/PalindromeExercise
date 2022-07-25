using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            if (word == null) 
            { 
                return false;
            }   
            return word.Replace(" ", "").ToLower().SequenceEqual(word.Replace(" ", "").ToLower().Reverse());
        }
    }
}
