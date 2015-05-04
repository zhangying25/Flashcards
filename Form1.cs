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
        private Phrases phrases;
        private Cards cards;
        private Records records;
        private Point award;
        private Mode mode = Mode.LEARNING;
        private DateTime startTime = DateTime.Now;
        private int timer;
        private static int GAME_DURATION_SECONDS = 60;

        public MainForm()
        {
            InitializeComponent();
            LoadDictionary();
            LoadPhrases();
            LoadRecords();
            LoadFlashCards();
            InitializeAward();
            DisplayCard(cards.GetCurrentCard());
        }

        #region initialization

        private void LoadPhrases()
        {
            phrases = new Phrases();
            phrases.Load();

            UpdateStatusBar(string.Format("Loaded phrases: {0:D}", phrases.GetCount()));
        }

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
            CreateStudyPlan(-1);
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

        private void CreateStudyPlan(int count)
        {
            cards.CreateStudyPlan(GetCurrentStrategy(), count, GetCurrentCategory());
            UpdateStatusBar(string.Format("Created study plan: {0} characters", cards.GetStudyPlanCardCount()));
        }

        private void ShowResult(bool right)
        {
            resultPictureBox.Image = right ? Flashcard.Properties.Resources.Right : Flashcard.Properties.Resources.Wrong;
            resultPictureBox.Visible = true;
            resultPictureBox.Refresh();
        }

        private void ClearResult()
        {
            pinyinTextBox.Text = "";
            resultPictureBox.Visible = false;
        }

        private Strategy GetCurrentStrategy()
        {
            Strategy strategy;
            Enum.TryParse(strategyComboBox.SelectedValue.ToString(), out strategy);
            return strategy;
        }

        private void SetCurrentStrategy(Strategy strategy)
        {
            strategyComboBox.Text = strategy.ToString();
        }

        private string[] GetCurrentCategory()
        {
            return categoryCheckedListBox.CheckedItems.Cast<string>().ToArray();
        }

        private void DisplayCard(Card card)
        {
            ClearResult();
            HidePinyinHint();
            HidePhrase();
            characterLabel.Text = card.GetCharacter().ToString();
            pinyinTextBox.Focus();
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

        private void HidePhrase()
        {
            phrasesListBox.Visible = false;
        }

        private void HidePinyinHint()
        {
            pinyinLabel.Visible = false;
        }

        private void UpdateAward()
        {
            int points = award.GetPoints();
            pointsStatusLable.Text = points.ToString();
            awardMedalPictureBox.Visible = points > 0;
            awardTrophyPictureBox.Visible = points > 10;
            awardHerculesPictureBox.Visible = points > 100;
            awardJediPictureBox.Visible = points > 200;
            awardYodaPictureBox.Visible = points > 300;
            awardBatmanPictureBox.Visible = points > 400;
            awardHaloPictureBox.Visible = points > 500;
            awardKillerPictureBox.Visible = points > 600;
            awardPumpkinPictureBox.Visible = points > 700;
            awardSpongeBobPictureBox.Visible = points > 800;
            awardBigHero6PictureBox.Visible = points > 900;
            awardMePictureBox.Visible = points > 1000;
            awardFrozonPictureBox.Visible = points > 1100;
        }

        private char GetCurrentCharacter()
        {
            Debug.Assert(characterLabel.Text != null);
            Debug.Assert(characterLabel.Text.Length == 1);
            return characterLabel.Text[0];
        }

        private void ShowPhrases(List<String> phrases)
        {
            phrasesListBox.DataSource = phrases;
            phrasesListBox.Visible = true;
        }

        private void CheckResultAndMoveToNext()
        {
            ShowPinyinHint();
            bool correct = dictionary.IsCorrect(GetCurrentCharacter(), pinyinTextBox.Text);
            records.Update(GetCurrentCharacter(), correct);
            cards.GetCurrentCard().UpdateStatus(correct);
            ShowResult(correct);
            dictionary.Pronounce(GetCurrentCharacter());

            switch (mode)
            {
                case Mode.LEARNING:
                    System.Threading.Thread.Sleep(1000);
                    if (correct) {
                        DisplayCard(cards.GetNextCard());
                        award.LearnOneMore();
                        UpdateStatusBar(string.Format("Studied {0} of {1} cards", cards.GetLearnedCardCount(), 
                            cards.GetStudyPlanCardCount()));
                    } else {
                        ShowPhrases(phrases.GetPhrasesContainsCharacter(GetCurrentCharacter()));
                        ClearResult();
                    }
                    break;
                case Mode.TEST:
                    if (cards.IsStudyPlanFinished()) {
                        FinishTest("Well Done");
                        break;
                    }
                    System.Threading.Thread.Sleep(300);
                    DisplayCard(cards.GetNextCard());
                    UpdateStatusBar(string.Format("Tested {0} of {1} words", cards.GetLearnedCardCount(), 
                        cards.GetStudyPlanCardCount()));
                    break;
                case Mode.GAME:
                    System.Threading.Thread.Sleep(300);
                    DisplayCard(cards.GetNextCard());
                    if (correct) {
                        award.EarnOneGamePoint();
                    }
                    break;
                default:
                    throw new ArgumentException("Unknown mode: " + mode);
            }
        }

        private void SetAllCategoryCheckState(CheckState state)
        {
            for (int i = 0; i <= (categoryCheckedListBox.Items.Count - 1); i++) {
                categoryCheckedListBox.SetItemCheckState(i, state);
            }  
        }

        private void FinishTest(string reason)
        {
            int correct = cards.GetCorrectCardCountInPlan();
            int total = cards.GetStudyPlanCardCount();
            string mistakes = cards.GetWrongCharacters();
            MessageBox.Show(
                string.Format("{0}. {1} of {2} ({3}%) words are correct. The following characters are not correct: \n\n{4}", 
                reason, correct, total, correct * 100 / total, mistakes),
                "Good Try!", MessageBoxButtons.OK);
            SetMode(Mode.LEARNING, -1, 0);
        }

        private void FinishGame()
        {
            MessageBox.Show(string.Format("You just earn {0} points", award.GetGamePoints()), "Good Game!", MessageBoxButtons.OK);
            award.FinishGame();
            SetMode(Mode.LEARNING, -1, 0);
        }

        private void UpdateClock()
        {
            TimeSpan duration = DateTime.Now - startTime;
            timerStatusLabel.Text = string.Format("{0}:{1:D2}:{2:D2}", duration.Hours, duration.Minutes, duration.Seconds);
        }

        private void UpdateTimer()
        {
            --timer;

            if (timer < 0) {
                return;
            } else if (timer > 0) {
                int leftMinutes = timer / 60;
                int leftSeconds = timer - leftMinutes * 60;
                gameTimerLabel.Text = string.Format("{0:D2}:{1:D2}", leftMinutes, leftSeconds);
                return;
            }

            switch (mode) {
                case Mode.GAME:
                    FinishGame();
                    break;
                case Mode.TEST:
                    FinishTest("Time is up");
                    break;
                default:
                    throw new ArgumentException("Unknown mode: " + mode);
            }
        }

        private void SetMode(Mode mode, int count, int durationMinute)
        {
            this.mode = mode;
            timer = durationMinute * 60;
            ClearResult();

            switch (mode) {
                case Mode.LEARNING:
                    SetCurrentStrategy(Strategy.MOST_FAILURE_FIRST);

                    strategyComboBox.Enabled = true;
                    categoryCheckedListBox.Enabled = true;
                    allCategoryButton.Enabled = true;
                    noneCategoryButton.Enabled = true;
                    startButton.Enabled = true;
                    tellMeButton.Enabled = true;
                    gameButton.Enabled = true;
                    testButton.Enabled = true;
                    gameTimerLabel.Visible = false;
                    break;
                case Mode.TEST:
                    strategyComboBox.Enabled = false;
                    categoryCheckedListBox.Enabled = false;
                    allCategoryButton.Enabled = false;
                    noneCategoryButton.Enabled = false;
                    startButton.Enabled = false;
                    tellMeButton.Enabled = false;
                    gameButton.Enabled = false;
                    testButton.Enabled = true;
                    gameTimerLabel.Visible = true;
                    break;
                case Mode.GAME:
                    SetCurrentStrategy(Strategy.RANDOM);

                    strategyComboBox.Enabled = false;
                    categoryCheckedListBox.Enabled = false;
                    allCategoryButton.Enabled = false;
                    noneCategoryButton.Enabled = false;
                    startButton.Enabled = false;
                    tellMeButton.Enabled = false;
                    testButton.Enabled = false;
                    gameTimerLabel.Visible = true;
                    break;
                default:
                    throw new ArgumentException("Unknown mode: " + mode);
            }

            CreateStudyPlan(count);
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
            if (e.KeyCode != Keys.Enter) {
                return;
            }

            CheckResultAndMoveToNext();
        }

        private void tellmeButton_Click(object sender, EventArgs e)
        {
            ShowPinyinHint();
            records.IncreaseWrongCount(GetCurrentCharacter(), 5);
            pinyinTextBox.Focus();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            UpdateClock();
            if (mode == Mode.GAME || mode == Mode.TEST) {
                UpdateTimer();
            } else {
                UpdateAward();
            }
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
            CreateStudyPlan(-1);
            DisplayCard(cards.GetCurrentCard());
        }

        private void gameButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Try to answer as much as you can in 1 minute.", "Let's PLAY!", MessageBoxButtons.OKCancel);
            pinyinTextBox.Focus();
            if (result == DialogResult.Cancel) {
                return;
            }

            SetMode(Mode.GAME, -1, GAME_DURATION_SECONDS);
            DisplayCard(cards.GetCurrentCard());
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            TestForm test = new TestForm();
            DialogResult result = test.ShowDialog();
            pinyinTextBox.Focus();
            if (result == DialogResult.Cancel)
            {
                return;
            }

            SetMode(Mode.TEST, test.GetCharacterCount(), test.GetDurationMinute());
            DisplayCard(cards.GetCurrentCard());
        }

        #endregion
    }
}
