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

        internal static Record NewRecord()
        {
            return new Record(0, 0, DateTime.Now);
        }

        internal static Record NewCorrectRecord()
        {
            return new Record(1, 0, DateTime.Now);
        }

        internal static Record NewWrongRecord()
        {
            return new Record(0, 1, DateTime.Now);
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

        public int RightCount
        {
            get { return rightCount; }
        }

        public int WrongCount
        {
            get { return wrongCount; }
        }

        public int WrongPercentile
        {
            get { return wrongCount * 100 / (wrongCount + rightCount); }
        }

        internal void Update(bool correct)
        {
            if (correct) {
                ++rightCount;
            } else {
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
