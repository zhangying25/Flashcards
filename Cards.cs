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
        private Strategy strategy = Strategy.SEQUENCE;

        internal Cards(Records records)
        {
            this.records = records;
        }

        /**
         * Flash cards file format: 
         *     Lesson-1 困难
         *     Lesson-2 勤劳勇敢
         **/
        internal void load()
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
        }

        internal List<string> getCategoryList()
        {
            return categories;
        }

        internal int getCardCount()
        {
            int count = 0;

            foreach (string categoary in categories)
            {
                count += cards[categoary].Length;
            }

            return count;
        }

        internal string getCard()
        {
            ++currentCard;
            if (currentCard == studyPlan.Count)
            {
                currentCard = 0;
            }

            return studyPlan[currentCard].Key.ToString();
        }

        internal void reset()
        {
            currentCard = -1;
        }

        internal void createStudyPlan(Strategy strategy, params string[] categories)
        {
            reset();

            switch (strategy)
            {
                case Strategy.SEQUENCE:
                    studyPlan = createSequentialStudyPlan(categories);
                    break;
                case Strategy.MOST_FAILURE_FIRST:
                    studyPlan = createTopFailureFirstPlan(categories);
                    break;
                default:
                    throw new ArgumentException("Unknown strategy " + strategy);
            }
        }

        private List<KeyValuePair<char, Record>> createSequentialStudyPlan(string[] categories)
        {
            List<KeyValuePair<char, Record>> plan = new List<KeyValuePair<char, Record>>();

            foreach (string category in categories)
            {
                string lesson = cards[category];
                for (int i = 0; i < lesson.Length; ++i)
                {
                    char character = cards[category][i];
                    Record record = records.getRecord(character);
                    plan.Add(new KeyValuePair<char, Record>(character, record));
                }
            }

            return plan;
        }

        private List<KeyValuePair<char, Record>> createTopFailureFirstPlan(string[] categories)
        {
            List<KeyValuePair<char, Record>> plan = createSequentialStudyPlan(categories);

            List<KeyValuePair<char, Record>> sortedPlan = plan.OrderByDescending(o => o.Value.getWrongPercentile()).ToList();

            return sortedPlan;
        }
    }
}
