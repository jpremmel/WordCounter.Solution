
namespace SentenceTools
{
    public class RepeatCounter
    {
        public int CountRepeats(string sentenceInput, string wordInput)
        {
            string word = wordInput.ToLower();
            string sentence = sentenceInput.ToLower();
            int repeats = 0;
            if (word.Contains(" "))
            {
                repeats = -1;
            }
            else
            {
                string[] words = sentence.Split(" ");
                char[] punctuation = { '.', ',', '-', '/', '"', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '=', ';', ':', '<', '>', '?', '{', '}', '[', ']', '|', '`', '~' };
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = words[i].Trim(punctuation);
                    if (words[i] == word)
                    {
                        repeats++;
                    }
                }
            }
            return repeats;
        }
    }
}