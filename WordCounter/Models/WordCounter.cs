
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
                string[] sentenceArray = sentence.Split(" ");
                char[] punctuation = { '.', ',', '-', '/', '"', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '=', ';', ':', '<', '>', '?', '{', '}', '[', ']', '\'', '|', '`', '~' };
                for (int i = 0; i < sentenceArray.Length; i++)
                {
                    
                }
                for (int i = 0; i < sentenceArray.Length; i++)
                {
                    if (sentenceArray[i] == word)
                    {
                        repeats++;
                    }
                }
            }
            return repeats;
        }
    }
}