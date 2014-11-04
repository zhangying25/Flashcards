using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcard
{
    class History
    {
        private const string HISTORY_FILENAME = "History.txt";

        /**
         * History file format: 
         *   studied_character_count  points  start_time            end_time points
         *   20                       15      2013-10-30T14:05:28   2014-11-30T17:15:47
         **/
        internal static void Save(Point award, DateTime startTime)
        {
            if (award.DidntLearnAny())
            {
                return;
            }

            string history = string.Format("{0:D4} {1:D6} {2} {3}", award.GetLearntCharacterCount(), award.GetPoints(), 
                startTime.ToString("s"), DateTime.Now.ToString("s"));

            File.AppendAllLines(HISTORY_FILENAME, new string[] { history }, Encoding.UTF8);
        }

        internal static int GetLatestPoints()
        {
            if (!File.Exists(HISTORY_FILENAME))
            {
                return 0;
            }

            string[] lines = File.ReadAllLines(HISTORY_FILENAME, Encoding.UTF8);
            for (int i = lines.Length - 1; i >= 0; --i)
            {
                if (String.IsNullOrWhiteSpace(lines[i]))
                {
                    continue;
                }

                string[] info = lines[i].Split(' ');
                return int.Parse(info[1]);
            }

            return 0;
        }
    }
}
