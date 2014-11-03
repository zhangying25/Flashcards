﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcard
{
    class Point
    {
        private int points = 0;
        private int learntCharacterCount = 0;

        internal Point(int initialCount)
        {
            points = initialCount;
        }

        internal int LearnOneMore()
        {
            return ++learntCharacterCount;
        }

        internal int getLearntCharacterCount()
        {
            return learntCharacterCount;
        }

        internal bool DidntLearnAny()
        {
            return learntCharacterCount == 0;
        }

        internal int GetPoints()
        {
            return points + learntCharacterCount / 20;
        }
    }
}