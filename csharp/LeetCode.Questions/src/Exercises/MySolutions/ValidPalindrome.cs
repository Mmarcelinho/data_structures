using System.Reflection.Metadata.Ecma335;

namespace Exercises.MySolutions;

public class ValidPalindrome
{
    // static void Main()
    // {
    //     string s = "race a car";
    //     var ValidPalindrome = new ValidPalindrome();
    //     ValidPalindrome.IsPalindrome(s);
    // }
    public bool IsPalindrome(string s)
    {
        List<char> sCharList = new();
        var sLeft = 0;
        var sRight = 0;
        foreach (var letter in s.ToLower())
        {

            if (char.IsLetterOrDigit(letter))
                sCharList.Add(letter);
        }

        sRight = sCharList.Count - 1;

        while (sLeft < sRight)
        {
            if (sCharList[sLeft] != sCharList[sRight])
            {
                return false;
            }

            sLeft++;
            sRight--;
        }
        return true;
    }
}
