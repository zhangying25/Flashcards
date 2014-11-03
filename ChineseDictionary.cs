using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcard
{
    class ChineseDictionary
    {
        private const string DICTIONARY_FILENAME = "ChineseDictionary.txt";
        private Dictionary<string, Pinyin> dictionary;

        internal ChineseDictionary()
        {
            dictionary = new Dictionary<string, Pinyin>();
        }

        /**
         * Dictionary file format: 
         *     中 zhong1
         *     为 wei2/wei4
         **/
        internal void Load()
        {
            string[] lines = System.IO.File.ReadAllLines(DICTIONARY_FILENAME, Encoding.UTF8);

            dictionary = new Dictionary<string, Pinyin>();
            foreach (string line in lines)
            {
                if (String.IsNullOrWhiteSpace(line))
                {
                    continue;
                }
                string[] values = line.Split(new char[] { ' ' }, 2);
                dictionary.Add(values[0], new Pinyin(values[1]));
            }
        }

        internal int GetCount()
        {
            return dictionary.Keys.Count;
        }

        internal bool IsCorrect(char character, string pinyin)
        {
            return dictionary[character.ToString()].Match(pinyin);
        }

        internal string GetPinyinHint(char character)
        {
            return dictionary[character.ToString()].GetPinyinString();
        }

        internal void Pronounce(char character)
        {
            foreach (string pinyin in dictionary[character.ToString()].GetPinyinList())
            {
                Pronouciation.Play(pinyin);
            }
        }
    }
}
