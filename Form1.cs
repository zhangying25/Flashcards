using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace Flashcard
{
    public partial class MainForm : Form
    {
        private const string DICTIONARY_FILENAME = "ChineseDictionary.txt";
        private Dictionary<string, Pinyin> dictionary;
        private Cards cards;
        private Records records;
        private Point award;
        private DateTime startTime = DateTime.Now;

        public MainForm()
        {
            InitializeComponent();
            LoadDictionary();
            loadRecords();
            loadFlashCards();
            initializeAward();
            displayNextCharacter();
        }

        #region initialization
        /**
         * Dictionary file format: 
         *     中 zhong1
         *     为 wei2/wei4
         **/
        private void LoadDictionary()
        {
            string[] lines = System.IO.File.ReadAllLines(DICTIONARY_FILENAME, Encoding.UTF8);
            
            dictionary = new Dictionary<string,Pinyin>();
            int i = 0;
            foreach (string line in lines)
            {
                if (String.IsNullOrWhiteSpace(line))
                {
                    continue;
                }
                string[] values = line.Split(new char[] {' '}, 2);
                dictionary.Add(values[0], new Pinyin(values[1]));
                updateStatusBar("Loaded dictionary entry: " + (++i));
            }
        }

        private void loadFlashCards()
        {
            cards = new Cards(records);
            cards.load();

            BindingSource source = new BindingSource();
            source.DataSource = Enum.GetValues(typeof(Strategy));
            strategyComboBox.DataSource = source;
            categoryCheckedListBox.Items.AddRange(cards.getCategoryList().ToArray());
            categoryCheckedListBox.SetItemChecked(0, true);
            createStudyPlan();

            updateStatusBar(string.Format("Loaded {0} cards", cards.getTotalCardCount()));
        }

        private void loadRecords()
        {
            records = new Records();
            records.load();
        }

        private void initializeAward()
        {
            award = new Point(History.getLatestPoints());
        }

        #endregion

        #region private methods

        private void createStudyPlan()
        {
            Strategy strategy;
            Enum.TryParse(strategyComboBox.SelectedValue.ToString(), out strategy);
            cards.createStudyPlan(strategy, getCurrentCategory());
            updateStatusBar(string.Format("Created study plan: {0}", cards.getStudyPlanCardCount()));
        }

        private void showResult(bool right)
        {
            resultPictureBox.Image = right ? flashcard.Properties.Resources.Right : flashcard.Properties.Resources.Wrong;
            resultPictureBox.Visible = true;
            resultPictureBox.Refresh();
        }

        private Pinyin getCurrentCharacterPinyin()
        {
            string character = characterLabel.Text;
            return dictionary[character];
        }

        private void clearResult()
        {
            pinyinTextBox.Text = "";
            resultPictureBox.Visible = false;
        }

        private string[] getCurrentCategory()
        {
            return categoryCheckedListBox.CheckedItems.Cast<string>().ToArray();
        }

        private void displayNextCharacter()
        {
            clearResult();
            hidePinyinHint();
            characterLabel.Text = cards.getCard();
        }

        private void updateStatusBar(string status)
        {
            statusLabel.Text = status;
        }

        private void showPinyinHint()
        {
            pinyinLabel.Text = getCurrentCharacterPinyin().getPinyinString();
            pinyinLabel.Visible = true;
            pinyinLabel.Refresh();
        }

        private void hidePinyinHint()
        {
            pinyinLabel.Visible = false;
        }

        private void updateAward()
        {
            int points = award.getPoints();
            if (points == 0)
            {
                return;
            }

            awardLabel.Text = points.ToString();
            awardLabel.Visible = true;
            awardMedalPictureBox.Visible = true;
        }

        private char getCurrentCharacter()
        {
            Debug.Assert(characterLabel.Text != null);
            Debug.Assert(characterLabel.Text.Length == 1);
            return characterLabel.Text[0];
        }

        private void checkResultAndMoveToNext()
        {
            showPinyinHint();
            Pinyin expectedPinyin = getCurrentCharacterPinyin();
            bool correct = expectedPinyin.match(pinyinTextBox.Text);
            records.update(getCurrentCharacter(), correct);
            showResult(correct);

            System.Threading.Thread.Sleep(1000);
            if (correct)
            {
                displayNextCharacter();
                updateStatusBar(string.Format("Studied {0} words", award.learnOneMore()));
            }
            else
            {
                clearResult();
            }
        }

        private void setAllCategoryCheckState(CheckState state)
        {
            for (int i = 0; i <= (categoryCheckedListBox.Items.Count - 1); i++)
            {
                categoryCheckedListBox.SetItemCheckState(i, state);
            }  
        }

        #endregion

        #region event handling

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            records.save();
            History.save(award, startTime);
        }

        private void pinyinTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            checkResultAndMoveToNext();
        }

        private void tellmeButton_Click(object sender, EventArgs e)
        {
            showPinyinHint();
            records.increaseWrongCount(getCurrentCharacter(), 5);
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan duration = DateTime.Now - startTime;
            clockLabel.Text = string.Format("{0}:{1:D2}:{2:D2}", duration.Hours, duration.Minutes, duration.Seconds);
            clockLabel.Refresh();
            updateAward();
        }

        private void allCategoryButton_Click(object sender, EventArgs e)
        {
            setAllCategoryCheckState(CheckState.Checked);
        }

        private void noneCategoryButton_Click(object sender, EventArgs e)
        {
            setAllCategoryCheckState(CheckState.Unchecked);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            createStudyPlan();
            displayNextCharacter();
        }

        #endregion
    }
}
