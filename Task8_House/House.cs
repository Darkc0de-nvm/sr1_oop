using System.Linq;

public static class House
{
    private static readonly string[] Parts =
    {
        "the horse and the hound and the horn that belonged to",
        "the farmer sowing his corn that kept",
        "the rooster that crowed in the morn that woke",
        "the priest all shaven and shorn that married",
        "the man all tattered and torn that kissed",
        "the maiden all forlorn that milked",
        "the cow with the crumpled horn that tossed",
        "the dog that worried",
        "the cat that killed",
        "the rat that ate",
        "the malt that lay in",
        "the house that Jack built."
    };

    public static string Recite(int verse)
    {
        var selectedParts = Parts.Skip(Parts.Length - verse);
        return "This is " + string.Join(" ", selectedParts);
    }

    public static string Recite(int startVerse, int endVerse)
    {
        var verses = Enumerable
            .Range(startVerse, endVerse - startVerse + 1)
            .Select(v => Recite(v));

        return string.Join("\n", verses);
    }
}