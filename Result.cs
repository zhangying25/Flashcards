using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcard
{
    class Result
    {
        private char character;
        private Pinyin answer;
        private string input;

        internal Result(char character, Pinyin answer, string input)
        {
            this.character = character;
            this.answer = answer;
            this.input = input;
        }

        public string Char
        {
            get { return character.ToString(); }
        }

        public string Answer
        {
            get { return answer.PinyinString; }
        }

        public string Yours
        {
            get { return input; }
        }

        public bool ToneOnlyMistake
        {
            get { 
                foreach (string pinyin in answer.PinyinList) {
                    if ((pinyin.Length == input.Length + 1) && (pinyin.StartsWith(input))) {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
