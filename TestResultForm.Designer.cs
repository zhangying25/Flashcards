namespace Flashcard
{
    partial class TestResultForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.totalCardLabel = new System.Windows.Forms.Label();
            this.totalCardsCountLabel = new System.Windows.Forms.Label();
            this.correctCardsCountLabel = new System.Windows.Forms.Label();
            this.correctCardsLabel = new System.Windows.Forms.Label();
            this.incorrectCardsCountLabel = new System.Windows.Forms.Label();
            this.incorrectCardsLabel = new System.Windows.Forms.Label();
            this.rateNumberLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.wrongCardsDataGridView = new System.Windows.Forms.DataGridView();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wrongCardsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // totalCardLabel
            // 
            this.totalCardLabel.AutoSize = true;
            this.totalCardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCardLabel.Location = new System.Drawing.Point(409, 38);
            this.totalCardLabel.Name = "totalCardLabel";
            this.totalCardLabel.Size = new System.Drawing.Size(147, 25);
            this.totalCardLabel.TabIndex = 0;
            this.totalCardLabel.Text = "Cards Tested:";
            // 
            // totalCardsCountLabel
            // 
            this.totalCardsCountLabel.AutoSize = true;
            this.totalCardsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCardsCountLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.totalCardsCountLabel.Location = new System.Drawing.Point(553, 34);
            this.totalCardsCountLabel.Name = "totalCardsCountLabel";
            this.totalCardsCountLabel.Size = new System.Drawing.Size(53, 37);
            this.totalCardsCountLabel.TabIndex = 1;
            this.totalCardsCountLabel.Text = "99";
            // 
            // correctCardsCountLabel
            // 
            this.correctCardsCountLabel.AutoSize = true;
            this.correctCardsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctCardsCountLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.correctCardsCountLabel.Location = new System.Drawing.Point(553, 78);
            this.correctCardsCountLabel.Name = "correctCardsCountLabel";
            this.correctCardsCountLabel.Size = new System.Drawing.Size(53, 37);
            this.correctCardsCountLabel.TabIndex = 3;
            this.correctCardsCountLabel.Text = "99";
            // 
            // correctCardsLabel
            // 
            this.correctCardsLabel.AutoSize = true;
            this.correctCardsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctCardsLabel.Location = new System.Drawing.Point(409, 84);
            this.correctCardsLabel.Name = "correctCardsLabel";
            this.correctCardsLabel.Size = new System.Drawing.Size(94, 25);
            this.correctCardsLabel.TabIndex = 2;
            this.correctCardsLabel.Text = "Correct :";
            // 
            // incorrectCardsCountLabel
            // 
            this.incorrectCardsCountLabel.AutoSize = true;
            this.incorrectCardsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectCardsCountLabel.ForeColor = System.Drawing.Color.Red;
            this.incorrectCardsCountLabel.Location = new System.Drawing.Point(553, 122);
            this.incorrectCardsCountLabel.Name = "incorrectCardsCountLabel";
            this.incorrectCardsCountLabel.Size = new System.Drawing.Size(35, 37);
            this.incorrectCardsCountLabel.TabIndex = 5;
            this.incorrectCardsCountLabel.Text = "0";
            // 
            // incorrectCardsLabel
            // 
            this.incorrectCardsLabel.AutoSize = true;
            this.incorrectCardsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectCardsLabel.Location = new System.Drawing.Point(409, 128);
            this.incorrectCardsLabel.Name = "incorrectCardsLabel";
            this.incorrectCardsLabel.Size = new System.Drawing.Size(107, 25);
            this.incorrectCardsLabel.TabIndex = 4;
            this.incorrectCardsLabel.Text = "Incorrect :";
            // 
            // rateNumberLabel
            // 
            this.rateNumberLabel.AutoSize = true;
            this.rateNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateNumberLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rateNumberLabel.Location = new System.Drawing.Point(553, 169);
            this.rateNumberLabel.Name = "rateNumberLabel";
            this.rateNumberLabel.Size = new System.Drawing.Size(81, 37);
            this.rateNumberLabel.TabIndex = 7;
            this.rateNumberLabel.Text = "99%";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.Location = new System.Drawing.Point(409, 175);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(69, 25);
            this.rateLabel.TabIndex = 6;
            this.rateLabel.Text = "Rate :";
            // 
            // wrongCardsDataGridView
            // 
            this.wrongCardsDataGridView.AllowUserToAddRows = false;
            this.wrongCardsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongCardsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.wrongCardsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.wrongCardsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.wrongCardsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.wrongCardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.wrongCardsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.wrongCardsDataGridView.Location = new System.Drawing.Point(12, 29);
            this.wrongCardsDataGridView.Name = "wrongCardsDataGridView";
            this.wrongCardsDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.wrongCardsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.wrongCardsDataGridView.Size = new System.Drawing.Size(356, 273);
            this.wrongCardsDataGridView.TabIndex = 29;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(488, 261);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(127, 41);
            this.okButton.TabIndex = 30;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // TestResultForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.okButton;
            this.ClientSize = new System.Drawing.Size(646, 327);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.wrongCardsDataGridView);
            this.Controls.Add(this.rateNumberLabel);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.incorrectCardsCountLabel);
            this.Controls.Add(this.incorrectCardsLabel);
            this.Controls.Add(this.correctCardsCountLabel);
            this.Controls.Add(this.correctCardsLabel);
            this.Controls.Add(this.totalCardsCountLabel);
            this.Controls.Add(this.totalCardLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TestResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Result";
            ((System.ComponentModel.ISupportInitialize)(this.wrongCardsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalCardLabel;
        private System.Windows.Forms.Label correctCardsLabel;
        private System.Windows.Forms.Label incorrectCardsLabel;
        private System.Windows.Forms.Label rateLabel;
        internal System.Windows.Forms.DataGridView wrongCardsDataGridView;
        internal System.Windows.Forms.Label totalCardsCountLabel;
        internal System.Windows.Forms.Label correctCardsCountLabel;
        internal System.Windows.Forms.Label incorrectCardsCountLabel;
        internal System.Windows.Forms.Label rateNumberLabel;
        private System.Windows.Forms.Button okButton;
    }
}