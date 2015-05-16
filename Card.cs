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
        // count of correct
        private int correct;
        // count of incorrect
        private int incorrect;
        private string input;

        internal Card(char character, Record record)
        {
            this.character = character;
            this.record = record;
            this.correct = 0;
            this.incorrect = 0;
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

        internal void Reset()
        {
            correct = 0;
            incorrect = 0;
        }

        internal bool CheckResult(ChineseDictionary dictionary, string input)
        {
            this.input = input;
            bool correct = dictionary.IsCorrect(character, input);
            if (correct) {
                ++this.correct;
            }
            else {
                ++this.incorrect;
            }
            record.Update(correct);
            return correct;
        }

        public bool EverIncorrect
        {
            get { return incorrect > 0; }
        }

        public string Answer
        {
            get { return input; }
        }
    }
}
