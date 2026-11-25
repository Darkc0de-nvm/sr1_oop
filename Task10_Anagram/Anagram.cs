using System;
using System.Linq;

public class Anagram
{
    private readonly string baseWordLower;
    private readonly string sortedBaseWord;

    public Anagram(string baseWord)
    {
        baseWordLower = baseWord.ToLower();
        sortedBaseWord = SortLetters(baseWordLower);
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        return potentialMatches
            .Where(IsAnagram)
            .ToArray();
    }

    private bool IsAnagram(string candidate)
    {
        string candidateLower = candidate.ToLower();

        if (candidateLower == baseWordLower)
        {
            return false;
        }

        return SortLetters(candidateLower) == sortedBaseWord;
    }

    private static string SortLetters(string word)
    {
        char[] chars = word.ToCharArray();
        Array.Sort(chars);
        return new string(chars);
    }
}