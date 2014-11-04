using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcard
{
    class Cards
    {
        private const string FLASH_CARD_FILENAME = "FlashCards.txt";
        private Records records;
        private Dictionary<string, string> cards;
        private List<string> categories;
        private List<KeyValuePair<char, Record>> studyPlan;
        private int currentCard = -1;

        internal Cards(Records records)
        {
            this.records = records;
        }

        /**
         * Flash cards file format: 
         *     Lesson-1 困难
         *     Lesson-2 勤劳勇敢
         **/
        internal void Load()
        {
            string[] lines = System.IO.File.ReadAllLines(FLASH_CARD_FILENAME, Encoding.UTF8);
            
            cards = new Dictionary<string, string>();
            categories = new List<string>();

            foreach (string line in lines)
            {
                if (String.IsNullOrWhiteSpace(line))
                {
                    continue;
                }
                string[] cardsInfo = line.Split(new char[] { ' ' }, 2);
                if (cardsInfo.Length != 2)
                {
                    continue;
                }
                categories.Add(cardsInfo[0]);
                cards.Add(cardsInfo[0], cardsInfo[1]);
            }

            // Make the new words show up on the top
            categories.Reverse();
        }

        internal List<string> GetCategoryList()
        {
            return categories;
        }

        internal int GetStudyPlanCardCount()
        {
            return studyPlan.Count;
        }

        internal int GetTotalCardCount()
        {
            int count = 0;

            foreach (string categoary in categories)
            {
                count += cards[categoary].Length;
            }

            return count;
        }

        internal string GetCard()
        {
            if (studyPlan.Count == 0)
            {
                return null;
            }

            ++currentCard;
            if (currentCard == studyPlan.Count)
            {
                currentCard = 0;
            }

            return studyPlan[currentCard].Key.ToString();
        }

        internal void Reset()
        {
            currentCard = -1;
        }

        internal void CreateStudyPlan(Strategy strategy, params string[] categories)
        {
            Reset();

            switch (strategy)
            {
                case Strategy.RANDOM:
                    studyPlan = CreateRandomStudyPlan(categories);
                    break;
                case Strategy.SEQUENCIAL:
                    studyPlan = CreateSequentialStudyPlan(categories);
                    break;
                case Strategy.MOST_FAILURE_FIRST:
                    studyPlan = CreateTopFailureFirstPlan(categories);
                    break;
                default:
                    throw new ArgumentException("Unknown strategy " + strategy);
            }
        }

        private List<KeyValuePair<char, Record>> CreateSequentialStudyPlan(string[] categories)
        {
            List<KeyValuePair<char, Record>> plan = new List<KeyValuePair<char, Record>>();

            foreach (string category in categories)
            {
                string lesson = cards[category];
                for (int i = 0; i < lesson.Length; ++i)
                {
                    char character = cards[category][i];
                    Record record = records.GetRecord(character);
                    plan.Add(new KeyValuePair<char, Record>(character, record));
                }
            }

            return plan;
        }

        private List<KeyValuePair<char, Record>> CreateRandomStudyPlan(string[] categories)
        {
            List<KeyValuePair<char, Record>> plan = CreateSequentialStudyPlan(categories);
            List<KeyValuePair<char, Record>> randomPlan = plan.OrderBy(o => Guid.NewGuid()).ToList();

            return randomPlan;
        }

        private List<KeyValuePair<char, Record>> CreateTopFailureFirstPlan(string[] categories)
        {
            List<KeyValuePair<char, Record>> plan = CreateSequentialStudyPlan(categories);
            List<KeyValuePair<char, Record>> sortedPlan = plan.OrderByDescending(o => o.Value.GetWrongPercentile()).ToList();

            return sortedPlan;
        }
    }
}
