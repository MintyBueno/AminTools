using System.Diagnostics;

namespace AminTools;

public class HilfeText
{
    public static string TitelMacher(string programmname, string beschreibung, string ersteller)
    {
        return $"{programmname} von {ersteller}\n{beschreibung}\n";
    }
    public static string Warnung(string text)
    {
        return $"WARNUNG!!! {text}";
    }
    public static string Trennlinie(int länge)
    {
        return new string('-', länge);
    }

}