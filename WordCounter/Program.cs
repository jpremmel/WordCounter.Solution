using System;
using SentenceTools;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();
        Console.WriteLine("Enter the word you'd like to count:");
        string word = Console.ReadLine();
        RepeatCounter counter = new RepeatCounter();
        string checkValidity = counter.CheckValidity(sentence, word);
        if (checkValidity == "valid")
        {
            int repeats = counter.CountRepeats(sentence, word);
            Console.WriteLine("Number of times '" + word + "' was found: " + repeats);
        }
        else
        {
            Console.WriteLine(checkValidity);
            Main();
        }
    }
}