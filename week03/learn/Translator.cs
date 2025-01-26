public class Translator
{
    public static void Run()
    {
        var englishToGerman = new Translator();
        englishToGerman.AddWord("House", "Haus");
        englishToGerman.AddWord("Car", "Auto");
        englishToGerman.AddWord("Plane", "Flugzeug");
        Console.WriteLine(englishToGerman.Translate("Car")); // Auto
        Console.WriteLine(englishToGerman.Translate("Plane")); // Flugzeug
        Console.WriteLine(englishToGerman.Translate("Train")); // ???
    }

    private Dictionary<string, string> _words = new();

    /// <summary>
    /// Add the translation from 'from_word' to 'to_word'
    /// For example, in a english to german dictionary:
    /// 
    /// my_translator.AddWord("book","buch")
    /// </summary>
    /// <param name="initialWord">The word to translate from</param>
    /// <param name="translateWord">The word to translate to</param>
    /// <returns>fixed array of divisors</returns>
    public void AddWord(string initialWord, string translateWord)
    {
        // ADD YOUR CODE HERE
        _words[initialWord] = translateWord;
    }

    /// <summary>
    /// Translates the from word into the word that this stores as the translation
    /// </summary>
    /// <param name="fromWord">The word to translate</param>
    /// <returns>The translated word or "???" if no translation is available</returns>
    public string Translate(string fromWord)
    {
        // ADD YOUR CODE HERE
        string freshWord = "???";

        if (_words.ContainsKey(fromWord))
        {
            freshWord = _words[fromWord];
        }

        return freshWord;
    }
}