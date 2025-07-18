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
    /// <param name="fromWord">The word to translate from</param>
    /// <param name="toWord">The word to translate to</param>
    /// <returns>fixed array of divisors</returns>
    public void AddWord(string fromWord, string toWord)
    {
        // The AddWord function should allow the user to add word translations (e.g. english to german)
        if (string.IsNullOrWhiteSpace(fromWord) || string.IsNullOrWhiteSpace(toWord))
        {
            throw new ArgumentException("Both fromWord and toWord must be non-empty strings.");
        }

        _words[fromWord] = toWord;
        // If the fromWord already exists, it will be updated with the new toWord
        // If it does not exist, it will be added to the dictionary
        Console.WriteLine($"Added translation: {fromWord} -> {toWord}");
        // This line is just for debugging purposes, you can remove it if you want
    }

    /// <summary>
    /// Translates the from word into the word that this stores as the translation
    /// </summary>
    /// <param name="fromWord">The word to translate</param>
    /// <returns>The translated word or "???" if no translation is available</returns>
    public string Translate(string fromWord)
    {
        // ADD YOUR CODE HERE
        if (string.IsNullOrWhiteSpace(fromWord))
        {
            throw new ArgumentException("fromWord must be a non-empty string.");
        }
        return _words.TryGetValue(fromWord, out var toWord) ? toWord : "???";
    }
}