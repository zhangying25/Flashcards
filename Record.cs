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

        internal void UpdateRecentStudyTime()
        {
            recentStudy = DateTime.Now;
        }

        internal void UpdateWrongCount(int count)
        {
            wrongCount += count;
            UpdateRecentStudyTime();
        }

        internal int GetRightCount()
        {
            return rightCount;
        }

        internal int GetWrongCount()
        {
            return wrongCount;
        }

        internal int GetWrongPercentile()
        {
            return wrongCount * 100 / (wrongCount + rightCount);
        }

        internal void UpdateCount(bool correct)
        {
            if (correct)
            {
                ++rightCount;
            }
            else
            {
                ++wrongCount;
            }
            UpdateRecentStudyTime();
        }

        public override string ToString()
        {
            return string.Format("{0:D4} {1:D4} {2}", rightCount, wrongCount, recentStudy.ToString("s"));
        }
    }
}
