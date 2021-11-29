using System;

namespace Open_Lab_03._08
{
    public class Checker
    {
        public bool IsPlural(string word)
        {
             word = word.Trim();
            if (word.EndsWith("s"))
            {
                return true;
            }
            return false;
        }
    }
}
