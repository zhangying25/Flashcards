using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flashcard
{
    class Record
    {
        private int rightCount;
        private int wrongCount;
        private DateTime recentStudy;

        internal static Record New()
        {
            return new Record(false);
        }

        internal Record(int rightCount, int wrongCount, DateTime recentStudy)
        {
            this.rightCount = rightCount;
            this.wrongCount = wrongCount;
            this.recentStudy = recentStudy;
        }

        internal Record(int rightCount, int wrongCount)
            : this(rightCount, wrongCount, DateTime.Now)
        {
        }

        internal Record(bool correct) : this(correct ? 1 : 0, correct ? 0 : 1, DateTime.Now)
        {
        }

        internal void updateRecentStudyTime()
        {
            recentStudy = DateTime.Now;
        }

        internal void updateWrongCount(int count)
        {
            wrongCount += count;
            updateRecentStudyTime();
        }

        internal int getRightCount()
        {
            return rightCount;
        }

        internal int getWrongCount()
        {
            return wrongCount;
        }

        internal int getWrongPercentile()
        {
            return wrongCount * 100 / (wrongCount + rightCount);
        }

        internal void updateCount(bool correct)
        {
            if (correct)
            {
                ++rightCount;
            }
            else
            {
                ++wrongCount;
            }
            updateRecentStudyTime();
        }

        public override string ToString()
        {
            return string.Format("{0:D4} {1:D4} {2}", rightCount, wrongCount, recentStudy.ToString("s"));
        }
    }
}
