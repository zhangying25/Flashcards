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
            this.awardFrozonPictureBox = new System.Windows.Forms.PictureBox();
            this.awardMePictureBox = new System.Windows.Forms.PictureBox();
            this.awardBigHero6PictureBox = new System.Windows.Forms.PictureBox();
            this.awardSpongeBobPictureBox = new System.Windows.Forms.PictureBox();
            this.awardPumpkinPictureBox = new System.Windows.Forms.PictureBox();
            this.testButton = new System.Windows.Forms.Button();
            this.awardBatmanPictureBox = new System.Windows.Forms.PictureBox();
            this.awardMedalPictureBox = new System.Windows.Forms.PictureBox();
            this.gameButton = new System.Windows.Forms.Button();
            this.awardHerculesPictureBox = new System.Windows.Forms.PictureBox();
            this.awardTrophyPictureBox = new System.Windows.Forms.PictureBox();
            this.tellMeButton = new System.Windows.Forms.Button();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.characterLabel = new System.Windows.Forms.Label();
            this.awardJediPictureBox = new System.Windows.Forms.PictureBox();
            this.awardYodaPictureBox = new System.Windows.Forms.PictureBox();
            this.awardKillerPictureBox = new System.Windows.Forms.PictureBox();
            this.awardHaloPictureBox = new System.Windows.Forms.PictureBox();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.awardFrozonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardMePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardBigHero6PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardSpongeBobPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardPumpkinPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardBatmanPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardMedalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardHerculesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardTrophyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardJediPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardYodaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardKillerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardHaloPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pinyinTextBox
            // 
            this.pinyinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinyinTextBox.Location = new System.Drawing.Point(269, 482);
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
            this.timerStatusLabel.Image = global::Flashcard.Properties.Resources.sand_clock2;
            this.timerStatusLabel.Name = "timerStatusLabel";
            this.timerStatusLabel.Size = new System.Drawing.Size(77, 21);
            this.timerStatusLabel.Text = "0:00:00";
            // 
            // pointsStatusLable
            // 
            this.pointsStatusLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsStatusLable.Image = global::Flashcard.Properties.Resources.Coins;
            this.pointsStatusLable.Name = "pointsStatusLable";
            this.pointsStatusLable.Size = new System.Drawing.Size(35, 21);
            this.pointsStatusLable.Text = "0";
            // 
            // pinyinLabel
            // 
            this.pinyinLabel.AutoSize = true;
            this.pinyinLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinyinLabel.Location = new System.Drawing.Point(264, 427);
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
            this.strategyComboBox.Location = new System.Drawing.Point(19, 66);
            this.strategyComboBox.Name = "strategyComboBox";
            this.strategyComboBox.Size = new System.Drawing.Size(188, 21);
            this.strategyComboBox.TabIndex = 12;
            // 
            // categoryCheckedListBox
            // 
            this.categoryCheckedListBox.FormattingEnabled = true;
            this.categoryCheckedListBox.Location = new System.Drawing.Point(19, 100);
            this.categoryCheckedListBox.Name = "categoryCheckedListBox";
            this.categoryCheckedListBox.Size = new System.Drawing.Size(188, 304);
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
            this.noneCategoryButton.Location = new System.Drawing.Point(142, 410);
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
            this.startButton.Size = new System.Drawing.Size(188, 23);
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
            this.phrasesListBox.Font = new System.Drawing.Font("NSimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phrasesListBox.FormattingEnabled = true;
            this.phrasesListBox.ItemHeight = 21;
            this.phrasesListBox.Location = new System.Drawing.Point(577, 70);
            this.phrasesListBox.MultiColumn = true;
            this.phrasesListBox.Name = "phrasesListBox";
            this.phrasesListBox.Size = new System.Drawing.Size(208, 214);
            this.phrasesListBox.TabIndex = 27;
            this.phrasesListBox.Visible = false;
            // 
            // awardFrozonPictureBox
            // 
            this.awardFrozonPictureBox.Image = global::Flashcard.Properties.Resources.frozen;
            this.awardFrozonPictureBox.Location = new System.Drawing.Point(213, 5);
            this.awardFrozonPictureBox.Name = "awardFrozonPictureBox";
            this.awardFrozonPictureBox.Size = new System.Drawing.Size(56, 50);
            this.awardFrozonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.awardFrozonPictureBox.TabIndex = 36;
            this.awardFrozonPictureBox.TabStop = false;
            this.awardFrozonPictureBox.Visible = false;
            // 
            // awardMePictureBox
            // 
            this.awardMePictureBox.Image = global::Flashcard.Properties.Resources.me;
            this.awardMePictureBox.Location = new System.Drawing.Point(252, 5);
            this.awardMePictureBox.Name = "awardMePictureBox";
            this.awardMePictureBox.Size = new System.Drawing.Size(56, 50);
            this.awardMePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.awardMePictureBox.TabIndex = 35;
            this.awardMePictureBox.TabStop = false;
            this.awardMePictureBox.Visible = false;
            // 
            // awardBigHero6PictureBox
            // 
            this.awardBigHero6PictureBox.Image = global::Flashcard.Properties.Resources.BigHero6;
            this.awardBigHero6PictureBox.Location = new System.Drawing.Point(301, 5);
            this.awardBigHero6PictureBox.Name = "awardBigHero6PictureBox";
            this.awardBigHero6PictureBox.Size = new System.Drawing.Size(56, 50);
            this.awardBigHero6PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.awardBigHero6PictureBox.TabIndex = 34;
            this.awardBigHero6PictureBox.TabStop = false;
            this.awardBigHero6PictureBox.Visible = false;
            // 
            // awardSpongeBobPictureBox
            // 
            this.awardSpongeBobPictureBox.Image = global::Flashcard.Properties.Resources.spongebob;
            this.awardSpongeBobPictureBox.Location = new System.Drawing.Point(351, 5);
            this.awardSpongeBobPictureBox.Name = "awardSpongeBobPictureBox";
            this.awardSpongeBobPictureBox.Size = new System.Drawing.Size(56, 50);
            this.awardSpongeBobPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.awardSpongeBobPictureBox.TabIndex = 33;
            this.awardSpongeBobPictureBox.TabStop = false;
            this.awardSpongeBobPictureBox.Visible = false;
            // 
            // awardPumpkinPictureBox
            // 
            this.awardPumpkinPictureBox.Image = global::Flashcard.Properties.Resources.Pumpkin;
            this.awardPumpkinPictureBox.Location = new System.Drawing.Point(403, 5);
            this.awardPumpkinPictureBox.Name = "awardPumpkinPictureBox";
            this.awardPumpkinPictureBox.Size = new System.Drawing.Size(56, 50);
            this.awardPumpkinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.awardPumpkinPictureBox.TabIndex = 32;
            this.awardPumpkinPictureBox.TabStop = false;
            this.awardPumpkinPictureBox.Visible = false;
            // 
            // testButton
            // 
            this.testButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.testButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("testButton.BackgroundImage")));
            this.testButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.testButton.Location = new System.Drawing.Point(575, 427);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(95, 92);
            this.testButton.TabIndex = 31;
            this.testButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // awardBatmanPictureBox
            // 
            this.awardBatmanPictureBox.Image = global::Flashcard.Properties.Resources.lego_batman;
            this.awardBatmanPictureBox.Location = new System.Drawing.Point(547, 5);
            this.awardBatmanPictureBox.Name = "awardBatmanPictureBox";
            this.awardBatmanPictureBox.Size = new System.Drawing.Size(56, 50);
            this.awardBatmanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.awardBatmanPictureBox.TabIndex = 28;
            this.awardBatmanPictureBox.TabStop = false;
            this.awardBatmanPictureBox.Visible = false;
            // 
            // awardMedalPictureBox
            // 
            this.awardMedalPictureBox.Image = global::Flashcard.Properties.Resources.mdeal;
            this.awardMedalPictureBox.Location = new System.Drawing.Point(778, 5);
            this.awardMedalPictureBox.Name = "awardMedalPictureBox";
            this.awardMedalPictureBox.Size = new System.Drawing.Size(56, 50);
            this.awardMedalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.awardMedalPictureBox.TabIndex = 10;
            this.awardMedalPictureBox.TabStop = false;
            this.awardMedalPictureBox.Visible = false;
            // 
            // gameButton
            // 
            this.gameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gameButton.BackgroundImage = global::Flashcard.Properties.Resources.game;
            this.gameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameButton.Location = new System.Drawing.Point(692, 427);
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(95, 92);
            this.gameButton.TabIndex = 21;
            this.gameButton.UseVisualStyleBackColor = true;
            this.gameButton.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // awardHerculesPictureBox
            // 
            this.awardHerculesPictureBox.Image = global::Flashcard.Properties.Resources.hercules;
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
            this.awardTrophyPictureBox.Image = global::Flashcard.Properties.Resources.trophy;
            this.awardTrophyPictureBox.Location = new System.Drawing.Point(731, 5);
            this.awardTrophyPictureBox.Name = "awardTrophyPictureBox";
            this.awardTrophyPictureBox.Size = new System.Drawing.Size(56, 50);
            this.awardTrophyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.awardTrophyPictureBox.TabIndex = 17;
            this.awardTrophyPictureBox.TabStop = false;
            this.awardTrophyPictureBox.Visible = false;
            // 
            // tellMeButton
            // 
            this.tellMeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tellMeButton.BackgroundImage = global::Flashcard.Properties.Resources.dont_know;
            this.tellMeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tellMeButton.Location = new System.Drawing.Point(457, 427);
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
            this.characterLabel.Image = global::Flashcard.Properties.Resources.Frame;
            this.characterLabel.Location = new System.Drawing.Point(240, 66);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(330, 341);
            this.characterLabel.TabIndex = 2;
            this.characterLabel.Text = "字";
            this.characterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // awardJediPictureBox
            // 
            this.awardJediPictureBox.Image = global::Flashcard.Properties.Resources.lego_jedi;
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
            this.awardYodaPictureBox.Image = global::Flashcard.Properties.Resources.lego_yoda;
            this.awardYodaPictureBox.Location = new System.Drawing.Point(597, 5);
            this.awardYodaPictureBox.Name = "awardYodaPictureBox";
            this.awardYodaPictureBox.Size = new System.Drawing.Size(56, 50);
            this.awardYodaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.awardYodaPictureBox.TabIndex = 25;
            this.awardYodaPictureBox.TabStop = false;
            this.awardYodaPictureBox.Visible = false;
            // 
            // awardKillerPictureBox
            // 
            this.awardKillerPictureBox.Image = global::Flashcard.Properties.Resources.lego_killer;
            this.awardKillerPictureBox.Location = new System.Drawing.Point(451, 5);
            this.awardKillerPictureBox.Name = "awardKillerPictureBox";
            this.awardKillerPictureBox.Size = new System.Drawing.Size(56, 50);
            this.awardKillerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.awardKillerPictureBox.TabIndex = 30;
            this.awardKillerPictureBox.TabStop = false;
            this.awardKillerPictureBox.Visible = false;
            // 
            // awardHaloPictureBox
            // 
            this.awardHaloPictureBox.Image = global::Flashcard.Properties.Resources.lego_halo;
            this.awardHaloPictureBox.Location = new System.Drawing.Point(496, 5);
            this.awardHaloPictureBox.Name = "awardHaloPictureBox";
            this.awardHaloPictureBox.Size = new System.Drawing.Size(56, 50);
            this.awardHaloPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.awardHaloPictureBox.TabIndex = 29;
            this.awardHaloPictureBox.TabStop = false;
            this.awardHaloPictureBox.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 567);
            this.Controls.Add(this.awardMePictureBox);
            this.Controls.Add(this.awardBigHero6PictureBox);
            this.Controls.Add(this.awardSpongeBobPictureBox);
            this.Controls.Add(this.awardPumpkinPictureBox);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.awardBatmanPictureBox);
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
            this.Controls.Add(this.awardKillerPictureBox);
            this.Controls.Add(this.awardHaloPictureBox);
            this.Controls.Add(this.awardFrozonPictureBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.awardFrozonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardMePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardBigHero6PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardSpongeBobPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardPumpkinPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardBatmanPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardMedalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardHerculesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardTrophyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardJediPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardYodaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardKillerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awardHaloPictureBox)).EndInit();
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
        private System.Windows.Forms.PictureBox awardBatmanPictureBox;
        private System.Windows.Forms.PictureBox awardHaloPictureBox;
        private System.Windows.Forms.PictureBox awardKillerPictureBox;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.PictureBox awardPumpkinPictureBox;
        private System.Windows.Forms.PictureBox awardSpongeBobPictureBox;
        private System.Windows.Forms.PictureBox awardBigHero6PictureBox;
        private System.Windows.Forms.PictureBox awardMePictureBox;
        private System.Windows.Forms.PictureBox awardFrozonPictureBox;
    }
}

