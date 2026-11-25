using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        var result = new StringBuilder();

        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                char rotated = (char)(((c - offset + shiftKey) % 26) + offset);

                result.Append(rotated);
            }
            else
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }
}