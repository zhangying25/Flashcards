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
            this.characterLabel = new System.Windows.Forms.Label();
            this.pinyinTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.spaceStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pinyinLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.clockLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tellmeButton = new System.Windows.Forms.Button();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.awardLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.spaceStatusLabel.Size = new System.Drawing.Size(584, 17);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::flashcard.Properties.Resources.medal_icon;
            this.pictureBox1.Location = new System.Drawing.Point(778, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
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
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(19, 66);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(146, 21);
            this.categoryComboBox.TabIndex = 12;
            this.categoryComboBox.SelectionChangeCommitted += new System.EventHandler(this.categoryComboBox_SelectionChangeCommitted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 567);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.awardLabel);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label awardLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
    }
}

