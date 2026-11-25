using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        char[] cleaned = phrase
            .Select(c => c == '-' ? ' ' : c)
            .Where(c => char.IsLetter(c) || c == ' ')
            .ToArray();

        string[] words = new string(cleaned)
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        char[] acronym = words
            .Select(word => char.ToUpper(word[0]))
            .ToArray();

        return new string(acronym);
    }
}