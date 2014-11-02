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

        internal bool match(string input)
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

        internal string getPinyinString()
        {
            return string.Join(", ", values);
        }
    }
}
