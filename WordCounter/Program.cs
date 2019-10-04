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
        int repeats = counter.CountRepeats(sentence, word);
        if (repeats == -1)
        {
            Console.WriteLine("Can only search for a single word. Please try again.");
            Main();
        }
        else
        {
            Console.WriteLine("Number of times '" + word + "' was found: " + repeats);
        }

    }
}