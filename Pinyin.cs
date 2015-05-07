using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcard
{
    class Pinyin
    {
        private List<string> values;

        internal Pinyin(string values)
        {
            this.values = new List<string>();
            this.values.AddRange(values.Split('/'));
        }

        internal bool Match(string input)
        {
            foreach (string value in values)
            {
                if (value.Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        internal string PinyinString
        {
            get { return string.Join(", ", values); }
        }

        internal List<string> PinyinList
        {
            get { return values; }
        }
    }
}
