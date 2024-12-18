namespace Text_Analyzer___Eng_Maged_Ali
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtWordCount = new System.Windows.Forms.TextBox();
            this.txtLetterCount = new System.Windows.Forms.TextBox();
            this.txtSentenceCount = new System.Windows.Forms.TextBox();
            this.txtCharacterCount = new System.Windows.Forms.TextBox();
            this.txtMostFrequentWord = new System.Windows.Forms.TextBox();
            this.txtAverageReadingTime = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGrammarFeedback = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtWordCount
            // 
            this.txtWordCount.Location = new System.Drawing.Point(351, 217);
            this.txtWordCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWordCount.Name = "txtWordCount";
            this.txtWordCount.ReadOnly = true;
            this.txtWordCount.Size = new System.Drawing.Size(274, 24);
            this.txtWordCount.TabIndex = 0;
            this.txtWordCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLetterCount
            // 
            this.txtLetterCount.Location = new System.Drawing.Point(351, 266);
            this.txtLetterCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLetterCount.Name = "txtLetterCount";
            this.txtLetterCount.ReadOnly = true;
            this.txtLetterCount.Size = new System.Drawing.Size(274, 24);
            this.txtLetterCount.TabIndex = 3;
            this.txtLetterCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSentenceCount
            // 
            this.txtSentenceCount.Location = new System.Drawing.Point(351, 319);
            this.txtSentenceCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSentenceCount.Name = "txtSentenceCount";
            this.txtSentenceCount.ReadOnly = true;
            this.txtSentenceCount.Size = new System.Drawing.Size(274, 24);
            this.txtSentenceCount.TabIndex = 4;
            this.txtSentenceCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCharacterCount
            // 
            this.txtCharacterCount.Location = new System.Drawing.Point(351, 374);
            this.txtCharacterCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCharacterCount.Name = "txtCharacterCount";
            this.txtCharacterCount.ReadOnly = true;
            this.txtCharacterCount.Size = new System.Drawing.Size(274, 24);
            this.txtCharacterCount.TabIndex = 5;
            this.txtCharacterCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMostFrequentWord
            // 
            this.txtMostFrequentWord.Location = new System.Drawing.Point(351, 423);
            this.txtMostFrequentWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMostFrequentWord.Name = "txtMostFrequentWord";
            this.txtMostFrequentWord.ReadOnly = true;
            this.txtMostFrequentWord.Size = new System.Drawing.Size(274, 24);
            this.txtMostFrequentWord.TabIndex = 6;
            this.txtMostFrequentWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAverageReadingTime
            // 
            this.txtAverageReadingTime.Location = new System.Drawing.Point(351, 469);
            this.txtAverageReadingTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAverageReadingTime.Name = "txtAverageReadingTime";
            this.txtAverageReadingTime.ReadOnly = true;
            this.txtAverageReadingTime.Size = new System.Drawing.Size(274, 24);
            this.txtAverageReadingTime.TabIndex = 7;
            this.txtAverageReadingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(351, 528);
            this.btnAnalyze.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(274, 75);
            this.btnAnalyze.TabIndex = 8;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(164, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Letter Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(164, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "WordCount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(164, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sentence Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(164, 378);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Character Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(164, 425);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Most Frequent Word";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(164, 469);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Average Reading Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(794, 217);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Grammar Feedback";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(257, 18);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(495, 155);
            this.txtInput.TabIndex = 16;
            this.txtInput.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Enter your text here...";
            // 
            // txtGrammarFeedback
            // 
            this.txtGrammarFeedback.Location = new System.Drawing.Point(754, 242);
            this.txtGrammarFeedback.Name = "txtGrammarFeedback";
            this.txtGrammarFeedback.Size = new System.Drawing.Size(218, 361);
            this.txtGrammarFeedback.TabIndex = 18;
            this.txtGrammarFeedback.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Text_Analyzer___Eng_Maged_Ali.Properties.Resources.Magnify_1x_0_7s_200px_200px;
            this.pictureBox1.Location = new System.Drawing.Point(798, 340);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 107);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(996, 638);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtGrammarFeedback);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.txtAverageReadingTime);
            this.Controls.Add(this.txtMostFrequentWord);
            this.Controls.Add(this.txtCharacterCount);
            this.Controls.Add(this.txtSentenceCount);
            this.Controls.Add(this.txtLetterCount);
            this.Controls.Add(this.txtWordCount);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Analyzer Eng Maged Ali";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWordCount;
        private System.Windows.Forms.TextBox txtLetterCount;
        private System.Windows.Forms.TextBox txtSentenceCount;
        private System.Windows.Forms.TextBox txtCharacterCount;
        private System.Windows.Forms.TextBox txtMostFrequentWord;
        private System.Windows.Forms.TextBox txtAverageReadingTime;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtGrammarFeedback;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

