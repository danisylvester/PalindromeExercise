using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {

        public bool IsAPalindrome(string input)
        {
            return input.SequenceEqual(input.Reverse());

        }



    }
}
