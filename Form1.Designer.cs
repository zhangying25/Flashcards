﻿namespace Flashcard
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
            this.characterLabel = new System.Windows.Forms.Label();
            this.pinyinTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.spaceStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pinyinLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.clockLabel = new System.Windows.Forms.Label();
            this.awardMedalPictureBox = new System.Windows.Forms.PictureBox();
            this.tellmeButton = new System.Windows.Forms.Button();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.awardLabel = new System.Windows.Forms.Label();
            this.strategyComboBox = new System.Windows.Forms.ComboBox();
            this.categoryCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.allCategoryButton = new System.Windows.Forms.Button();
            this.noneCategoryButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.awardMedalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // characterLabel
            // 
            this.characterLabel.AutoSize = true;
            this.characterLabel.Font = new System.Drawing.Font("文鼎习字体", 255.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.characterLabel.Location = new System.Drawing.Point(171, 66);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(503, 387);
            this.characterLabel.TabIndex = 2;
            this.characterLabel.Text = "字";
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
            this.spaceStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 545);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(834, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(66, 17);
            this.statusLabel.Text = "statusLabel";
            // 
            // spaceStatusLabel
            // 
            this.spaceStatusLabel.Name = "spaceStatusLabel";
            this.spaceStatusLabel.Size = new System.Drawing.Size(753, 17);
            this.spaceStatusLabel.Spring = true;
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
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.Location = new System.Drawing.Point(12, 18);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(106, 37);
            this.clockLabel.TabIndex = 9;
            this.clockLabel.Text = "0:00:00";
            // 
            // awardMedalPictureBox
            // 
            this.awardMedalPictureBox.Image = global::flashcard.Properties.Resources.medal_icon;
            this.awardMedalPictureBox.Location = new System.Drawing.Point(778, 5);
            this.awardMedalPictureBox.Name = "awardMedalPictureBox";
            this.awardMedalPictureBox.Size = new System.Drawing.Size(56, 50);
            this.awardMedalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.awardMedalPictureBox.TabIndex = 10;
            this.awardMedalPictureBox.TabStop = false;
            this.awardMedalPictureBox.Visible = false;
            // 
            // tellmeButton
            // 
            this.tellmeButton.BackgroundImage = global::flashcard.Properties.Resources.dont_know;
            this.tellmeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tellmeButton.Location = new System.Drawing.Point(662, 427);
            this.tellmeButton.Name = "tellmeButton";
            this.tellmeButton.Size = new System.Drawing.Size(95, 92);
            this.tellmeButton.TabIndex = 7;
            this.tellmeButton.UseVisualStyleBackColor = true;
            this.tellmeButton.Click += new System.EventHandler(this.tellmeButton_Click);
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.Image = global::flashcard.Properties.Resources.Right;
            this.resultPictureBox.Location = new System.Drawing.Point(662, 325);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(95, 83);
            this.resultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resultPictureBox.TabIndex = 6;
            this.resultPictureBox.TabStop = false;
            this.resultPictureBox.Visible = false;
            // 
            // awardLabel
            // 
            this.awardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awardLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.awardLabel.Location = new System.Drawing.Point(706, 18);
            this.awardLabel.Name = "awardLabel";
            this.awardLabel.Size = new System.Drawing.Size(72, 23);
            this.awardLabel.TabIndex = 11;
            this.awardLabel.Text = "0";
            this.awardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.awardLabel.Visible = false;
            // 
            // strategyComboBox
            // 
            this.strategyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.strategyComboBox.FormattingEnabled = true;
            this.strategyComboBox.Location = new System.Drawing.Point(19, 66);
            this.strategyComboBox.Name = "strategyComboBox";
            this.strategyComboBox.Size = new System.Drawing.Size(146, 21);
            this.strategyComboBox.TabIndex = 12;
            // 
            // categoryCheckedListBox
            // 
            this.categoryCheckedListBox.FormattingEnabled = true;
            this.categoryCheckedListBox.Location = new System.Drawing.Point(19, 100);
            this.categoryCheckedListBox.Name = "categoryCheckedListBox";
            this.categoryCheckedListBox.Size = new System.Drawing.Size(146, 304);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 567);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.noneCategoryButton);
            this.Controls.Add(this.allCategoryButton);
            this.Controls.Add(this.categoryCheckedListBox);
            this.Controls.Add(this.strategyComboBox);
            this.Controls.Add(this.awardLabel);
            this.Controls.Add(this.awardMedalPictureBox);
            this.Controls.Add(this.clockLabel);
            this.Controls.Add(this.pinyinLabel);
            this.Controls.Add(this.tellmeButton);
            this.Controls.Add(this.resultPictureBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pinyinTextBox);
            this.Controls.Add(this.characterLabel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flash Card";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.awardMedalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label characterLabel;
        private System.Windows.Forms.TextBox pinyinTextBox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.Button tellmeButton;
        private System.Windows.Forms.Label pinyinLabel;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.ToolStripStatusLabel spaceStatusLabel;
        private System.Windows.Forms.PictureBox awardMedalPictureBox;
        private System.Windows.Forms.Label awardLabel;
        private System.Windows.Forms.ComboBox strategyComboBox;
        private System.Windows.Forms.CheckedListBox categoryCheckedListBox;
        private System.Windows.Forms.Button allCategoryButton;
        private System.Windows.Forms.Button noneCategoryButton;
        private System.Windows.Forms.Button startButton;
    }
}
