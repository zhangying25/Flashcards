using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcard
{
    class Point
    {
        private int historyPoints = 0;
        private int totalGamePoints = 0;
        private int gamePoints = 0;
        private int learntCharacterCount = 0;

        internal Point(int initialCount)
        {
            historyPoints = initialCount;
        }

        internal void EarnOneGamePoint()
        {
            ++gamePoints;
        }

        internal void FinishGame()
        {
            totalGamePoints += gamePoints;
            gamePoints = 0;
        }

        internal void LearnOneMore()
        {
            ++learntCharacterCount;
        }

        internal int GetLearntCharacterCount()
        {
            return learntCharacterCount;
        }

        internal int GetGamePoints()
        {
            return gamePoints;
        }

        internal bool DidntLearnAny()
        {
            return learntCharacterCount == 0 && totalGamePoints == 0;
        }

        internal int GetPoints()
        {
            return historyPoints + totalGamePoints + learntCharacterCount / 10;
        }
    }
}
