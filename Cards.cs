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
        private List<Card> studyPlan;
        private int currentCard = 0;

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

            foreach (string line in lines) {
                if (String.IsNullOrWhiteSpace(line)) {
                    continue;
                }
                string[] cardsInfo = line.Split(new char[] { ' ' }, 2);
                if (cardsInfo.Length != 2) {
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

        internal bool AllPassed {
            get { return GetStudyPlanCardCount() == GetCorrectCardCountInPlan(); }
        }

        internal int GetLearnedCardCount()
        {
            return currentCard;
        }

        internal List<Card> GetMisspelledCards()
        {
            List<Card> mistakes = new List<Card>();
            foreach (Card card in studyPlan)
            {
                if (card.EverIncorrect) {
                    mistakes.Add(card);
                }
            }

            return mistakes;
        }

        internal int GetCorrectCardCountInPlan()
        {
            int count = 0;

            foreach (Card card in studyPlan) {
                if (!card.EverIncorrect) {
                    ++count;
                }
            }

            return count;
        }

        internal int GetTotalCardCount()
        {
            int count = 0;

            foreach (string categoary in categories) {
                count += cards[categoary].Length;
            }

            return count;
        }

        internal Card CurrentCard
        {
            get
            {
                if (studyPlan.Count == 0) {
                    throw new ArgumentException("Study plan is empty");
                }

                return studyPlan[currentCard];
            }
        }

        internal Card NextCard
        {
            get
            {
                if (studyPlan.Count == 0) {
                    throw new ArgumentException("Study plan is empty");
                }

                ++currentCard;
                if (currentCard == studyPlan.Count) {
                    currentCard = 0;
                }

                return studyPlan[currentCard];
            }
        }

        internal bool IsStudyPlanFinished()
        {
            return currentCard == studyPlan.Count - 1;
        }

        internal void Reset()
        {
            currentCard = 0;
        }

        internal void CreateStudyPlanOnMisspelledCards()
        {
            Reset();
            studyPlan = this.GetMisspelledCards();
            foreach (Card card in studyPlan) {
                card.Reset();
            }
        }

        internal void CreateStudyPlan(Strategy strategy, int count, params string[] categories)
        {
            Reset();

            switch (strategy) {
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
                    throw new ArgumentException("Unknown strategy: " + strategy);
            }

            if (count > 0 && studyPlan.Count > count) {
                studyPlan = studyPlan.GetRange(0, count);
            }
        }

        private List<Card> CreateSequentialStudyPlan(string[] categories)
        {
            List<Card> plan = new List<Card>();

            foreach (string category in categories) {
                string lesson = cards[category];
                for (int i = 0; i < lesson.Length; ++i) {
                    char character = cards[category][i];
                    Record record = records.GetRecord(character);
                    plan.Add(new Card(character, record));
                }
            }

            return plan;
        }

        private List<Card> CreateRandomStudyPlan(string[] categories)
        {
            List<Card> plan = CreateSequentialStudyPlan(categories);
            List<Card> randomPlan = plan.OrderBy(o => Guid.NewGuid()).ToList();

            return randomPlan;
        }

        private List<Card> CreateTopFailureFirstPlan(string[] categories)
        {
            List<Card> plan = CreateSequentialStudyPlan(categories);
            List<Card> sortedPlan = plan.OrderByDescending(o => o.Record.WrongPercentile).ToList();

            return sortedPlan;
        }
    }
}
