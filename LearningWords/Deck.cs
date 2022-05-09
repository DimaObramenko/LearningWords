using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LearningWords
{
    class Deck
    {
        private string path;
        
        public Deck(string path)
        {
            this.path = path + ".txt";
        }
        public Deck() { }

        public void CreateNewDeck(Dictionary<string, string> newDeck)
        {
            using (var writer = new StreamWriter(path))
            {
                foreach (var pair in newDeck)
                {
                    writer.WriteLine($"{pair.Key},{pair.Value}");
                }
                writer.Close();
            }
        }

        public void AddNewWord(string word, string translation)
        {
            using (var writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"{word},{translation}");
                //writer.Close();
            }
        }

        public void AddNewDeck(string deckName)
        {
            using (var writer = new StreamWriter("decks.txt", true))
            {
                writer.WriteLine(deckName);
            }
            using (var writer = new StreamWriter(path))
            {
                writer.Close();
            }
        }

        public Dictionary<string, string> GetWordsFromDeck()
        {
            var dict = File.ReadLines(path).Select(line => line.Split(','))
                .Where(arr => arr.Length == 2).ToDictionary(arr => arr[0], arr => arr[1]);
            return dict;
        }

        public int GetNumberAllWordsInDeck()
        {
            string[] lines = File.ReadAllLines(path);
            return lines.Length;
        }

        public void IKnowThisWord(string word)
        {
            string[] lines = File.ReadAllLines(path);
            using (var writer = new StreamWriter(path))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] arr = lines[i].Split(new char[] { ',' });
                    if (arr[0] == word)
                    {
                        lines[i] = lines[i].Replace(",", "!");
                    }

                    writer.WriteLine($"{lines[i]}");
                }
            }
        }

        public int GetNumberOfWords(string deckName)
        {
            string[] lines = File.ReadAllLines(path);
            return lines.Length;
        }
    }
}
