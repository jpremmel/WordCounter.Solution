namespace SentenceTools
{
    public class RepeatCounter
    {
        public string CheckValidity(string sentenceInput, string wordInput)
        {
            string output = "valid";
            bool valid = true;
            if (wordInput.Contains(" "))
            {
                valid = false;
            }
            if (!valid)
            {
                output = "Can only search for a single word. Please try again.";
            }
            return output;
        }
        public int CountRepeats(string sentenceInput, string wordInput)
        {
            int repeats = 0;
            string word = wordInput.ToLower();
            string sentence = sentenceInput.ToLower();
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
            return repeats;
        }
    }
}