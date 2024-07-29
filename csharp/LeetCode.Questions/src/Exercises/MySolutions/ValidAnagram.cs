namespace Exercises.MySolutions;

    public class ValidAnagram
    {
        // static void Main()
        // {
        //     var s = "bat";
        //     var t = "tab";
        //     var anagram = new ValidAnagram();
        //     anagram.AreAnagrams(s,t);
        // }
        public bool AreAnagrams(string s, string t) {
        if(s.Length != t.Length) return false;
        if(s == t) return true;

        var sList = new List<char>();
        var tList = new List<char>();
        int sLetter = 0;
        int tLetter = 0;

        for(int i = 0; i < s.Length; i++)
        {
            sList.Add(s[i]);
            tList.Add(t[i]);
        }

        for(int i = 0; i < s.Length; i++)
        {
            sLetter += sList[i] - 'a';
            tLetter += tList[i] - 'a';
        }
         if(sLetter != tLetter)
            return false;

        return true;
    }

    }
