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
            source.DataSource = cards.getCategoryList();
            categoryComboBox.DataSource = source;

            cards.createStudyPlan(Strategy.MOST_FAILURE_FIRST, getCurrentCategory());

            updateStatusBar(string.Format("Loaded {0} cards", cards.getCardCount()));
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

        private string getCurrentCategory()
        {
            return categoryComboBox.SelectedItem.ToString();
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
            awardLabel.Text = award.getPoints().ToString();
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
            records.update(getCurrentCharacter(), getCurrentCategory(), correct);
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

        private void categoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cards.createStudyPlan(Strategy.MOST_FAILURE_FIRST, getCurrentCategory());
            displayNextCharacter();
        }

        private void tellmeButton_Click(object sender, EventArgs e)
        {
            showPinyinHint();
            records.increaseWrongCount(getCurrentCharacter(), getCurrentCategory(), 5);
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan duration = DateTime.Now - startTime;
            clockLabel.Text = string.Format("{0}:{1:D2}:{2:D2}", duration.Hours, duration.Minutes, duration.Seconds);
            clockLabel.Refresh();
            updateAward();
        }

        #endregion
    }
}
