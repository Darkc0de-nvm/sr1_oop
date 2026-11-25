using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        if (string.IsNullOrWhiteSpace(statement))
        {
            return "Fine. Be that way!";
        }

        string trimmed = statement.Trim();

        bool isQuestion = trimmed.EndsWith('?');
        bool isYelling = trimmed.Any(char.IsLetter) && trimmed.ToUpper() == trimmed;

        if (isYelling && isQuestion)
        {
            return "Calm down, I know what I'm doing!";
        }

        if (isYelling)
        {
            return "Whoa, chill out!";
        }

        if (isQuestion)
        {
            return "Sure.";
        }

        return "Whatever.";
    }
}