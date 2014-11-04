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
        private ChineseDictionary dictionary;
        private Cards cards;
        private Records records;
        private Point award;
        private DateTime startTime = DateTime.Now;

        public MainForm()
        {
            InitializeComponent();
            LoadDictionary();
            LoadRecords();
            LoadFlashCards();
            InitializeAward();
            DisplayNextCharacter();
        }

        #region initialization

        private void LoadDictionary()
        {
            dictionary = new ChineseDictionary();
            dictionary.Load();

            UpdateStatusBar(string.Format("Loaded dictionary entry: {0:D}", dictionary.GetCount()));
        }

        private void LoadFlashCards()
        {
            cards = new Cards(records);
            cards.Load();

            BindingSource source = new BindingSource();
            source.DataSource = Enum.GetValues(typeof(Strategy));
            strategyComboBox.DataSource = source;
            categoryCheckedListBox.Items.AddRange(cards.GetCategoryList().ToArray());
            categoryCheckedListBox.SetItemChecked(0, true);
            CreateStudyPlan();

            UpdateStatusBar(string.Format("Loaded {0} cards", cards.GetTotalCardCount()));
        }

        private void LoadRecords()
        {
            records = new Records();
            records.Load();
        }

        private void InitializeAward()
        {
            award = new Point(History.GetLatestPoints());
        }

        #endregion

        #region private methods

        private void CreateStudyPlan()
        {
            Strategy strategy;
            Enum.TryParse(strategyComboBox.SelectedValue.ToString(), out strategy);
            cards.CreateStudyPlan(strategy, GetCurrentCategory());
            UpdateStatusBar(string.Format("Created study plan: {0}", cards.GetStudyPlanCardCount()));
        }

        private void ShowResult(bool right)
        {
            resultPictureBox.Image = right ? flashcard.Properties.Resources.Right : flashcard.Properties.Resources.Wrong;
            resultPictureBox.Visible = true;
            resultPictureBox.Refresh();
        }

        private void ClearResult()
        {
            pinyinTextBox.Text = "";
            resultPictureBox.Visible = false;
        }

        private string[] GetCurrentCategory()
        {
            return categoryCheckedListBox.CheckedItems.Cast<string>().ToArray();
        }

        private void DisplayNextCharacter()
        {
            ClearResult();
            HidePinyinHint();
            characterLabel.Text = cards.GetCard();
        }

        private void UpdateStatusBar(string status)
        {
            statusLabel.Text = status;
        }

        private void ShowPinyinHint()
        {
            pinyinLabel.Text = dictionary.GetPinyinHint(GetCurrentCharacter());
            pinyinLabel.Visible = true;
            pinyinLabel.Refresh();
        }

        private void HidePinyinHint()
        {
            pinyinLabel.Visible = false;
        }

        private void UpdateAward()
        {
            int limit = 100; // how many points are allowed for each trophy icon
            int points = award.GetPoints();
            int medal = points - points / limit * limit;
            int trophy = points / limit - points / limit / limit * limit;
            int hercules = points / limit / limit;

            if (points > 0)
            {
                awardMedalLabel.Text = medal.ToString();
                awardMedalLabel.Visible = true;
                awardMedalPictureBox.Visible = true;
            }
            if (points >= 10)
            {
                awardTrophyLabel.Text = trophy.ToString();
                awardTrophyLabel.Visible = true;
                awardTrophyPictureBox.Visible = true;
            }
            if (points >= 100)
            {
                awardHerculesLabel.Text = hercules.ToString();
                awardHerculesLabel.Visible = true;
                awardHerculesPictureBox.Visible = true;
            }
        }

        private char GetCurrentCharacter()
        {
            Debug.Assert(characterLabel.Text != null);
            Debug.Assert(characterLabel.Text.Length == 1);
            return characterLabel.Text[0];
        }

        private void CheckResultAndMoveToNext()
        {
            ShowPinyinHint();
            bool correct = dictionary.IsCorrect(GetCurrentCharacter(), pinyinTextBox.Text);
            records.Update(GetCurrentCharacter(), correct);
            ShowResult(correct);
            dictionary.Pronounce(GetCurrentCharacter());

            System.Threading.Thread.Sleep(1000);
            if (correct)
            {
                DisplayNextCharacter();
                UpdateStatusBar(string.Format("Studied {0} words", award.LearnOneMore()));
            }
            else
            {
                ClearResult();
            }
        }

        private void SetAllCategoryCheckState(CheckState state)
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
            records.Save();
            History.Save(award, startTime);
        }

        private void pinyinTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            CheckResultAndMoveToNext();
        }

        private void tellmeButton_Click(object sender, EventArgs e)
        {
            ShowPinyinHint();
            records.IncreaseWrongCount(GetCurrentCharacter(), 5);
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan duration = DateTime.Now - startTime;
            timerStatusLabel.Text = string.Format("{0}:{1:D2}:{2:D2}", duration.Hours, duration.Minutes, duration.Seconds);
            UpdateAward();
        }

        private void allCategoryButton_Click(object sender, EventArgs e)
        {
            SetAllCategoryCheckState(CheckState.Checked);
        }

        private void noneCategoryButton_Click(object sender, EventArgs e)
        {
            SetAllCategoryCheckState(CheckState.Unchecked);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            CreateStudyPlan();
            DisplayNextCharacter();
        }

        #endregion
    }
}
