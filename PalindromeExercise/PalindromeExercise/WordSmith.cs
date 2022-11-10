using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PalindromeExercise
{
    public class WordSmith
    {        
        public bool IsAPalindrome(string word)
        {
            var small = word.ToLower();
            var back = "";
            for (int i = small.Length -1; i >= 0; i--)
            {
                back += small[i];
            }
            if (back == small)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }//In your WordSmith class, you will create a method (IsAPalindrome) that will take a parameter of type string 
    //and return a value of type bool. If the given input is a palindrome – return true, else return false. 
    //You will finish this method after you write your tests.
    //Write you test method in the UnitTest1.cs file - located in the PalindromeExerciseTests project file
    

    //In UnitTest1.cs, remove the Fact portion and replace it with:
}
