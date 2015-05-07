using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcard
{
    class Card
    {
        private char character;
        private Record record;
        private bool? correct;
        private string input;

        internal Card(char character, Record record)
        {
            this.character = character;
            this.record = record;
            this.correct = null;
            this.input = null;
        }

        public char Character
        {
            get { return character; }
        }

        public Record Record
        {
            get { return record; }
        }

        internal bool CheckResult(ChineseDictionary dictionary, string input)
        {
            this.input = input;
            bool correct = dictionary.IsCorrect(character, input);
            this.correct = correct;
            record.Update(correct);
            return correct;
        }

        public bool IsCorrect()
        {
            return correct ?? false;
        }

        public string Answer
        {
            get { return input; }
        }
    }
}
