using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flashcard
{
    class Record
    {
        private string category;
        private int rightCount;
        private int wrongCount;
        private DateTime recentStudy;

        internal static Record New()
        {
            return new Record(null, false);
        }

        internal Record(string category, int rightCount, int wrongCount, DateTime recentStudy)
        {
            this.category = category;
            this.rightCount = rightCount;
            this.wrongCount = wrongCount;
            this.recentStudy = recentStudy;
        }

        internal Record(string category, int rightCount, int wrongCount)
            : this(category, rightCount, wrongCount, DateTime.Now)
        {
        }

        internal Record(string category, bool correct) : this(category, correct ? 1 : 0, correct ? 0 : 1, DateTime.Now)
        {
        }

        internal string getCategory()
        {
            return category;
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
            return string.Format("{0} {1:D4} {2:D4} {3}", category, rightCount, wrongCount, recentStudy.ToString("s"));
        }
    }
}
