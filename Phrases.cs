using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcard
{
    class Phrases
    {
        private HashSet<String> values = new HashSet<string>();
        private const string PHRASES_FILENAME = "Phrases.txt";

        internal void Load()
        {
            string[] lines = System.IO.File.ReadAllLines(PHRASES_FILENAME, Encoding.UTF8);

            foreach (string line in lines)
            {
                if (String.IsNullOrWhiteSpace(line))
                {
                    continue;
                }
                foreach (String phrase in line.Split(new char[] { ' ' })) 
                {
                    if (String.IsNullOrWhiteSpace(phrase))
                    {
                        continue;
                    }
                    if (!values.Contains(phrase))
                    {
                        values.Add(phrase);
                    }
                }
            }
        }

        internal List<String> GetPhrasesContainsCharacter(char character)
        {
            List<String> phraseSet = new List<string>();

            foreach (String phrase in values)
            {
                if (phrase.Contains(character))
                {
                    phraseSet.Add(phrase);
                }
            }

            return phraseSet;
        }

        internal int GetCount()
        {
            return values.Count;
        }
    }
}
