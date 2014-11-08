namespace Flashcard
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pinyinTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.spaceStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pointsStatusLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.pinyinLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.strategyComboBox = new System.Windows.Forms.ComboBox();
            this.categoryCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.allCategoryButton = new System.Windows.Forms.Button();
            this.noneCategoryButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.gameTimerLabel = new System.Windows.Forms.Label();
            this.phrasesListBox = new System.Windows.Forms.ListBox();
            this.gameButton = new System.Windows.Forms.Button();
            this.awardHerculesPictureBox = new System.Windows.Forms.PictureBox();
            this.awardTrophyPictureBox = new System.Windows.Forms.PictureBox();
            this.awardMedalPictureBox = new System.Windows.Forms.PictureBox();
            this.tellMeButton = new System.Windows.Forms.Button();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.characterLabel = new System.Windows.Forms.Label();
            this.awardJediPictureBox = new System.Windows.Forms.PictureBox();
            this.awardYodaPictureBox = new System.Windows.Forms.PictureBox();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.awardHerculesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardTrophyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardMedalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardJediPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardYodaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pinyinTextBox
            // 
            this.pinyinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinyinTextBox.Location = new System.Drawing.Point(347, 482);
            this.pinyinTextBox.Name = "pinyinTextBox";
            this.pinyinTextBox.Size = new System.Drawing.Size(107, 35);
            this.pinyinTextBox.TabIndex = 3;
            this.pinyinTextBox.Text = "zi";
            this.pinyinTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pinyinTextBox_KeyDown);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.spaceStatusLabel,
            this.timerStatusLabel,
            this.pointsStatusLable});
            this.statusStrip.Location = new System.Drawing.Point(0, 541);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(834, 26);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(88, 21);
            this.statusLabel.Text = "statusLabel";
            // 
            // spaceStatusLabel
            // 
            this.spaceStatusLabel.Name = "spaceStatusLabel";
            this.spaceStatusLabel.Size = new System.Drawing.Size(619, 21);
            this.spaceStatusLabel.Spring = true;
            // 
            // timerStatusLabel
            // 
            this.timerStatusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerStatusLabel.Image = global::flashcard.Properties.Resources.sand_clock2;
            this.timerStatusLabel.Name = "timerStatusLabel";
            this.timerStatusLabel.Size = new System.Drawing.Size(77, 21);
            this.timerStatusLabel.Text = "0:00:00";
            // 
            // pointsStatusLable
            // 
            this.pointsStatusLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsStatusLable.Image = global::flashcard.Properties.Resources.Coins;
            this.pointsStatusLable.Name = "pointsStatusLable";
            this.pointsStatusLable.Size = new System.Drawing.Size(35, 21);
            this.pointsStatusLable.Text = "0";
            // 
            // pinyinLabel
            // 
            this.pinyinLabel.AutoSize = true;
            this.pinyinLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinyinLabel.Location = new System.Drawing.Point(342, 427);
            this.pinyinLabel.Name = "pinyinLabel";
            this.pinyinLabel.Size = new System.Drawing.Size(55, 28);
            this.pinyinLabel.TabIndex = 8;
            this.pinyinLabel.Text = "hint";
            this.pinyinLabel.Visible = false;
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // strategyComboBox
            // 
            this.strategyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.strategyComboBox.FormattingEnabled = true;
            this.strategyComboBox.Location = new System.Drawing.Point(19, 34);
            this.strategyComboBox.Name = "strategyComboBox";
            this.strategyComboBox.Size = new System.Drawing.Size(146, 21);
            this.strategyComboBox.TabIndex = 12;
            // 
            // categoryCheckedListBox
            // 
            this.categoryCheckedListBox.FormattingEnabled = true;
            this.categoryCheckedListBox.Location = new System.Drawing.Point(19, 70);
            this.categoryCheckedListBox.Name = "categoryCheckedListBox";
            this.categoryCheckedListBox.Size = new System.Drawing.Size(146, 334);
            this.categoryCheckedListBox.TabIndex = 13;
            // 
            // allCategoryButton
            // 
            this.allCategoryButton.Location = new System.Drawing.Point(19, 410);
            this.allCategoryButton.Name = "allCategoryButton";
            this.allCategoryButton.Size = new System.Drawing.Size(66, 23);
            this.allCategoryButton.TabIndex = 14;
            this.allCategoryButton.Text = "All";
            this.allCategoryButton.UseVisualStyleBackColor = true;
            this.allCategoryButton.Click += new System.EventHandler(this.allCategoryButton_Click);
            // 
            // noneCategoryButton
            // 
            this.noneCategoryButton.Location = new System.Drawing.Point(100, 410);
            this.noneCategoryButton.Name = "noneCategoryButton";
            this.noneCategoryButton.Size = new System.Drawing.Size(65, 23);
            this.noneCategoryButton.TabIndex = 15;
            this.noneCategoryButton.Text = "None";
            this.noneCategoryButton.UseVisualStyleBackColor = true;
            this.noneCategoryButton.Click += new System.EventHandler(this.noneCategoryButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(19, 440);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(146, 23);
            this.startButton.TabIndex = 16;
            this.startButton.Text = "Restart";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // gameTimerLabel
            // 
            this.gameTimerLabel.AutoSize = true;
            this.gameTimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTimerLabel.Location = new System.Drawing.Point(704, 382);
            this.gameTimerLabel.Name = "gameTimerLabel";
            this.gameTimerLabel.Size = new System.Drawing.Size(66, 25);
            this.gameTimerLabel.TabIndex = 22;
            this.gameTimerLabel.Text = "01:00";
            this.gameTimerLabel.Visible = false;
            // 
            // phrasesListBox
            // 
            this.phrasesListBox.ColumnWidth = 70;
            this.phrasesListBox.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phrasesListBox.FormattingEnabled = true;
            this.phrasesListBox.ItemHeight = 16;
            this.phrasesListBox.Location = new System.Drawing.Point(577, 70);
            this.phrasesListBox.MultiColumn = true;
            this.phrasesListBox.Name = "phrasesListBox";
            this.phrasesListBox.Size = new System.Drawing.Size(208, 228);
            this.phrasesListBox.TabIndex = 27;
            this.phrasesListBox.Visible = false;
            // 
            // gameButton
            // 
            this.gameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gameButton.BackgroundImage = global::flashcard.Properties.Resources.game;
            this.gameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameButton.Location = new System.Drawing.Point(690, 425);
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(95, 92);
            this.gameButton.TabIndex = 21;
            this.gameButton.UseVisualStyleBackColor = true;
            this.gameButton.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // awardHerculesPictureBox
            // 
            this.awardHerculesPictureBox.Image = global::flashcard.Properties.Resources.hercules;
            this.awardHerculesPictureBox.Location = new System.Drawing.Point(686, 5);
            this.awardHerculesPictureBox.Name = "awardHerculesPictureBox";
            this.awardHerculesPictureBox.Size = new System.Drawing.Size(56, 50);
            this.awardHerculesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.awardHerculesPictureBox.TabIndex = 19;
            this.awardHerculesPictureBox.TabStop = false;
            this.awardHerculesPictureBox.Visible = false;
            // 
            // awardTrophyPictureBox
            // 
            this.awardTrophyPictureBox.Image = global::flashcard.Properties.Resources.trophy;
            this.awardTrophyPictureBox.Location = new System.Drawing.Point(731, 5);
            this.awardTrophyPictureBox.Name = "awardTrophyPictureBox";
            this.awardTrophyPictureBox.Size = new System.Drawing.Size(56, 50);
            this.awardTrophyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.awardTrophyPictureBox.TabIndex = 17;
            this.awardTrophyPictureBox.TabStop = false;
            this.awardTrophyPictureBox.Visible = false;
            // 
            // awardMedalPictureBox
            // 
            this.awardMedalPictureBox.Image = global::flashcard.Properties.Resources.mdeal;
            this.awardMedalPictureBox.Location = new System.Drawing.Point(778, 5);
            this.awardMedalPictureBox.Name = "awardMedalPictureBox";
            this.awardMedalPictureBox.Size = new System.Drawing.Size(56, 50);
            this.awardMedalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.awardMedalPictureBox.TabIndex = 10;
            this.awardMedalPictureBox.TabStop = false;
            this.awardMedalPictureBox.Visible = false;
            // 
            // tellMeButton
            // 
            this.tellMeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tellMeButton.BackgroundImage = global::flashcard.Properties.Resources.dont_know;
            this.tellMeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tellMeButton.Location = new System.Drawing.Point(575, 425);
            this.tellMeButton.Name = "tellMeButton";
            this.tellMeButton.Size = new System.Drawing.Size(95, 92);
            this.tellMeButton.TabIndex = 7;
            this.tellMeButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.tellMeButton.UseVisualStyleBackColor = true;
            this.tellMeButton.Click += new System.EventHandler(this.tellmeButton_Click);
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.Location = new System.Drawing.Point(575, 324);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(95, 83);
            this.resultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resultPictureBox.TabIndex = 6;
            this.resultPictureBox.TabStop = false;
            this.resultPictureBox.Visible = false;
            // 
            // characterLabel
            // 
            this.characterLabel.Font = new System.Drawing.Font("KaiTi", 255.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.characterLabel.Image = global::flashcard.Properties.Resources.Frame;
            this.characterLabel.Location = new System.Drawing.Point(240, 66);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(330, 341);
            this.characterLabel.TabIndex = 2;
            this.characterLabel.Text = "字";
            this.characterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // awardJediPictureBox
            // 
            this.awardJediPictureBox.Image = global::flashcard.Properties.Resources.lego_jedi;
            this.awardJediPictureBox.Location = new System.Drawing.Point(642, 5);
            this.awardJediPictureBox.Name = "awardJediPictureBox";
            this.awardJediPictureBox.Size = new System.Drawing.Size(56, 50);
            this.awardJediPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.awardJediPictureBox.TabIndex = 23;
            this.awardJediPictureBox.TabStop = false;
            this.awardJediPictureBox.Visible = false;
            // 
            // awardYodaPictureBox
            // 
            this.awardYodaPictureBox.Image = global::flashcard.Properties.Resources.lego_yoda;
            this.awardYodaPictureBox.Location = new System.Drawing.Point(597, 5);
            this.awardYodaPictureBox.Name = "awardYodaPictureBox";
            this.awardYodaPictureBox.Size = new System.Drawing.Size(56, 50);
            this.awardYodaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.awardYodaPictureBox.TabIndex = 25;
            this.awardYodaPictureBox.TabStop = false;
            this.awardYodaPictureBox.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 567);
            this.Controls.Add(this.awardMedalPictureBox);
            this.Controls.Add(this.phrasesListBox);
            this.Controls.Add(this.gameTimerLabel);
            this.Controls.Add(this.gameButton);
            this.Controls.Add(this.awardHerculesPictureBox);
            this.Controls.Add(this.awardTrophyPictureBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.noneCategoryButton);
            this.Controls.Add(this.allCategoryButton);
            this.Controls.Add(this.categoryCheckedListBox);
            this.Controls.Add(this.strategyComboBox);
            this.Controls.Add(this.pinyinLabel);
            this.Controls.Add(this.tellMeButton);
            this.Controls.Add(this.resultPictureBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pinyinTextBox);
            this.Controls.Add(this.characterLabel);
            this.Controls.Add(this.awardJediPictureBox);
            this.Controls.Add(this.awardYodaPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flash Card";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.awardHerculesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardTrophyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardMedalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardJediPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardYodaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label characterLabel;
        private System.Windows.Forms.TextBox pinyinTextBox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.Button tellMeButton;
        private System.Windows.Forms.Label pinyinLabel;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.ToolStripStatusLabel spaceStatusLabel;
        private System.Windows.Forms.PictureBox awardMedalPictureBox;
        private System.Windows.Forms.ComboBox strategyComboBox;
        private System.Windows.Forms.CheckedListBox categoryCheckedListBox;
        private System.Windows.Forms.Button allCategoryButton;
        private System.Windows.Forms.Button noneCategoryButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox awardTrophyPictureBox;
        private System.Windows.Forms.PictureBox awardHerculesPictureBox;
        private System.Windows.Forms.Button gameButton;
        private System.Windows.Forms.ToolStripStatusLabel timerStatusLabel;
        private System.Windows.Forms.Label gameTimerLabel;
        private System.Windows.Forms.PictureBox awardJediPictureBox;
        private System.Windows.Forms.PictureBox awardYodaPictureBox;
        private System.Windows.Forms.ListBox phrasesListBox;
        private System.Windows.Forms.ToolStripStatusLabel pointsStatusLable;
    }
}

