using System;

class LetterCounter
{
    
    public int CountOccurrences(string inputString, char letterToCount)
    {
        int count = 0;
        foreach (char c in inputString)
        {
            if (char.ToUpper(c) == char.ToUpper(letterToCount))
            {
                count++;
            }
        }
        return count;
    }
}
