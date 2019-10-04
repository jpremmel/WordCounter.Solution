
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
                if (word == sentence)
                {
                    repeats = 1;
                }
            }
            return repeats;
        }
    }
}