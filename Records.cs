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
         *   word count_of_right count_of_wrong date_of_last_study
         *     困     15            2             2013-10-30T14:05:28
         *     难     12           28             2014-11-30T17:15:47
         **/
        internal void Load()
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
                Debug.Assert(info.Length == 4, "Should include 4 parts: character, right count, wrong count, and recent study date");
                Debug.Assert(info[0].Length == 1, "The first column is the Chinese character");

                records.Add(info[0][0], new Record(int.Parse(info[1]), int.Parse(info[2]), DateTime.Parse(info[3])));
            }
        }

        internal void Save()
        {
            List<string> lines = new List<string>();
            foreach (char character in records.Keys) {
                Record record = records[character];
                lines.Add(string.Format("{0} {1}", character, records[character].ToString()));
            }
            File.WriteAllLines(RECORDS_FILENAME, lines, Encoding.UTF8);
        }

        internal void Update(char character, bool correct)
        {
            if (records.ContainsKey(character)) {
                records[character].Update(correct);
            } else {
                records.Add(character, correct ? Record.NewCorrectRecord() : Record.NewWrongRecord());
            }
        }

        internal void IncreaseWrongCount(char character, int count)
        {
            if (records.ContainsKey(character)) {
                records[character].UpdateWrongCount(count);
            } else {
                records.Add(character, new Record(0, count));
            }
        }

        internal Record GetRecord(char character)
        {
            if (!records.ContainsKey(character)) {
                return Record.NewRecord();
            }

            return records[character];
        }
    }
}
