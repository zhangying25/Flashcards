using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcard
{
    class Records
    {
        private const string RECORDS_FILENAME = "Records.txt";
        private Dictionary<char, Record> records;

        /**
         * Records file format: 
         *   word category count_of_right count_of_wrong date_of_last_study
         *     困 第一册   15              2              2013-10-30T14:05:28
         *     难 第三册   12              28             2014-11-30T17:15:47
         **/
        internal void load()
        {
            records = new Dictionary<char, Record>();
            if (!File.Exists(RECORDS_FILENAME))
            {
                return;
            }

            string[] lines = File.ReadAllLines(RECORDS_FILENAME, Encoding.UTF8);
            foreach (string line in lines)
            {
                if (String.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] info = line.Split(' ');
                Debug.Assert(info.Length == 5, "Should include 5 parts: character, category, right count, wrong count, and recent study date");
                Debug.Assert(info[0].Length == 1, "The first column is the Chinese character");

                records.Add(info[0][0], new Record(info[1], int.Parse(info[2]), int.Parse(info[3]), DateTime.Parse(info[4])));
            }
        }

        internal void save()
        {
            List<string> lines = new List<string>();
            foreach (char character in records.Keys)
            {
                Record record = records[character];
                lines.Add(string.Format("{0} {1}", character, records[character].ToString()));
            }
            File.WriteAllLines(RECORDS_FILENAME, lines, Encoding.UTF8);
        }

        internal void update(char character, string category, bool correct)
        {
            if (records.ContainsKey(character))
            {
                records[character].updateCount(correct);
            }
            else
            {
                records.Add(character, new Record(category, correct));
            }
        }

        internal void increaseWrongCount(char character, string category, int count)
        {
            if (records.ContainsKey(character))
            {
                records[character].updateWrongCount(count);
            }
            else
            {
                records.Add(character, new Record(category, 0, count));
            }
        }

        internal Record getRecord(char character)
        {
            if (!records.ContainsKey(character))
            {
                return Record.New();
            }

            return records[character];
        }
    }
}
