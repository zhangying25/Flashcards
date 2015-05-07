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
        private string answer;
        private string input;

        internal Result(char character, string answer, string input)
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
            get { return answer; }
        }

        public string Yours
        {
            get { return input; }
        }
    }
}
