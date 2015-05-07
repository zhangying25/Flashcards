using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcard
{
    class ChineseDictionary
    {
        private const string DICTIONARY_FILENAME = "ChineseDictionary.txt";
        private Dictionary<char, Pinyin> dictionary;

        internal ChineseDictionary()
        {
            dictionary = new Dictionary<char, Pinyin>();
        }

        /**
         * Dictionary file format: 
         *     中 zhong1
         *     为 wei2/wei4
         **/
        internal void Load()
        {
            string[] lines = System.IO.File.ReadAllLines(DICTIONARY_FILENAME, Encoding.UTF8);

            dictionary = new Dictionary<char, Pinyin>();
            foreach (string line in lines)
            {
                if (String.IsNullOrWhiteSpace(line))
                {
                    continue;
                }
                string[] values = line.Split(new char[] { ' ' }, 2);
                Debug.Assert(values.Length == 2);
                Debug.Assert(values[0].Length == 1);
                dictionary.Add(values[0][0], new Pinyin(values[1]));
            }
        }

        internal int GetCount()
        {
            return dictionary.Keys.Count;
        }

        private void CheckAvailability(char character)
        {
            if (!dictionary.ContainsKey(character))
            {
                System.Windows.Forms.MessageBox.Show(string.Format("Can't find {0} in dictionary. Please fix!!!", character));
            }
        }

        internal bool IsCorrect(char character, string pinyin)
        {
            CheckAvailability(character);
            return dictionary[character].Match(pinyin);
        }

        internal string GetPinyinHint(char character)
        {
            CheckAvailability(character);
            return dictionary[character].PinyinString;
        }

        internal void Pronounce(char character)
        {
            CheckAvailability(character);
            foreach (string pinyin in dictionary[character].PinyinList)
            {
                Pronouciation.Play(pinyin);
            }
        }
    }
}
