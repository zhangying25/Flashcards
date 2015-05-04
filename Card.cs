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

        internal Card(char character, Record record)
        {
            this.character = character;
            this.record = record;
            this.correct = null;
        }

        internal char GetCharacter()
        {
            return character;
        }

        internal Record GetRecord()
        {
            return record;
        }

        internal void UpdateStatus(bool correct)
        {
            this.correct = correct;
        }

        internal bool IsCorrect()
        {
            return correct ?? false;
        }
    }
}
