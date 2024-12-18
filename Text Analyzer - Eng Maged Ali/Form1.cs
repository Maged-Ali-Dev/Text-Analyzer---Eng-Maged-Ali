using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHunspell;

namespace Text_Analyzer___Eng_Maged_Ali
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Attach event handlers for text changes and form load
            txtInput.TextChanged += txtInput_TextChanged;
            this.Load += Form1_Load; // Subscribe to the Load event
        }

        // Form Load event: Sets the active control to txtInput when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtInput; // Explicitly set the active control to txtInput
        }

        // TextChanged event handler: Called when the text in txtInput changes
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            UpdateTextDirection(); // Update the text direction based on the input text
        }

        // Updates the text direction based on whether the text is Arabic or English
        private void UpdateTextDirection()
        {
            // If the text contains Arabic characters, set RightToLeft to Yes
            if (IsArabic(txtInput.Text))
            {
                txtInput.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                // Otherwise, set RightToLeft to No (left-to-right for English)
                txtInput.RightToLeft = RightToLeft.No;
            }

            // Update the alignment for the first word after changing the text direction
            HandleFirstWordAlignment();
        }

        // Check if the text contains Arabic characters using regular expression
        private bool IsArabic(string text)
        {
            return Regex.IsMatch(text, @"\p{IsArabic}");
        }

        // Check if the text contains English characters using regular expression
        private bool IsEnglish(string text)
        {
            return Regex.IsMatch(text, @"[a-zA-Z]");
        }

        // Adjust alignment for the first word based on the detected language
        private void HandleFirstWordAlignment()
        {
            // If the first word is Arabic, re-render the text
            if (IsArabic(txtInput.Text) && !txtInput.Text.StartsWith(" "))
            {
                txtInput.SelectionStart = txtInput.Text.Length;
                txtInput.ScrollToCaret();
            }
            // If the first word is English, ensure proper left alignment
            else if (IsEnglish(txtInput.Text) && !txtInput.Text.StartsWith(" "))
            {
                txtInput.SelectionStart = txtInput.Text.Length;
                txtInput.ScrollToCaret();
            }
        }

        // Analyze the input text when the "Analyze" button is clicked
        private async void btnAnalyze_Click(object sender, EventArgs e)
        {
            txtGrammarFeedback.Text = "";
            string inputText = txtInput.Text;

            // Check if input text is empty or contains only whitespace
            if (string.IsNullOrWhiteSpace(inputText))
            {
                MessageBox.Show("Please enter some text to analyze.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnAnalyze.Enabled = false;
            pictureBox1.Visible = true;
            await Task.Delay(5000);  // Delay for 5 seconds (you can change this value)

            // Perform your analysis after the delay
            
            // Perform text analysis
            int wordCount = GetWordCount(inputText);
            int letterCount = GetLetterCount(inputText);
            int sentenceCount = GetSentenceCount(inputText);
            string mostFrequentWord = GetMostFrequentWord(inputText);
            double averageReadingTime = GetAverageReadingTime(wordCount);
            int characterCount = GetCharacterCount(inputText);
            string grammarFeedback = CheckGrammar(inputText);

            // Display results in respective text boxes
            txtWordCount.Text = wordCount.ToString();
            txtLetterCount.Text = letterCount.ToString();
            txtSentenceCount.Text = sentenceCount.ToString();
            txtMostFrequentWord.Text = mostFrequentWord;
            txtAverageReadingTime.Text = averageReadingTime.ToString("0.00") + " minutes";
            txtCharacterCount.Text = characterCount.ToString();
            txtGrammarFeedback.Text = grammarFeedback;
            
            pictureBox1.Visible = false;
            btnAnalyze.Enabled = true;
        }

        // Helper method to count words in the text
        private int GetWordCount(string text)
        {
            return Regex.Matches(text, "\\b\\w+\\b").Count;
        }

        // Helper method to count the total number of characters in the text
        private int GetCharacterCount(string text)
        {
            return text.Length;
        }

        // Helper method to count the total number of letters in the text (ignores numbers and symbols)
        private int GetLetterCount(string text)
        {
            return text.Count(char.IsLetter);
        }

        // Helper method to count the number of sentences in the text
        private int GetSentenceCount(string text)
        {
            return Regex.Matches(text, "[.!?](\\s|$)").Count;
        }

        // Calculates the average reading time based on the word count (200 words per minute average speed)
        private double GetAverageReadingTime(int wordCount)
        {
            const double wordsPerMinute = 200.0; // Average reading speed
            return wordCount / wordsPerMinute;
        }

        // Get the most frequent word in the text
        private string GetMostFrequentWord(string text)
        {
            var words = Regex.Matches(text.ToLower(), "\\b\\w+\\b")
                             .Cast<Match>()
                             .Select(m => m.Value);

            return words.GroupBy(w => w)
                        .OrderByDescending(g => g.Count())
                        .FirstOrDefault()?.Key ?? "N/A";
        }

        // Check grammar and spelling using Hunspell (detects language and suggests corrections)
        private string CheckGrammar(string text)
        {
            // Determine if the text is Arabic or English
            bool isArabic = IsArabic(text);

            // Use the corresponding language dictionary files based on detected language
            string affFile = isArabic ? "ar.aff" : "en_US.aff";
            string dicFile = isArabic ? "ar.dic" : "en_US.dic";

            // Check if dictionary files exist
            if (!System.IO.File.Exists(affFile) || !System.IO.File.Exists(dicFile))
            {
                return "Dictionary files not found for the selected language.";
            }

            // Use Hunspell to check spelling
            using (var hunspell = new Hunspell(affFile, dicFile))
            {
                var words = Regex.Matches(text, "\\b\\w+\\b")
                                 .Cast<Match>()
                                 .Select(m => m.Value)
                                 .ToList();

                string corrections = "";
                var incorrectWords = new List<string>();

                // Check each word for spelling errors
                foreach (var word in words)
                {
                    if (!hunspell.Spell(word))
                    {
                        var suggestions = hunspell.Suggest(word);
                        corrections += $"{word}: {string.Join(", ", suggestions)}\n";
                        incorrectWords.Add(word);
                    }
                }

                // Highlight incorrect words in the input text
                HighlightIncorrectWords(text, incorrectWords);

                return string.IsNullOrWhiteSpace(corrections)
                    ? "No spelling errors detected."
                    : corrections;
            }
        }

        // Highlights incorrect words in the RichTextBox with red color
        private void HighlightIncorrectWords(string text, List<string> incorrectWords)
        {
            // First, clear the text to remove any previous formatting
            txtInput.Text = text;

            // Track where we are in the text
            int index = 0;

            // Loop through the incorrect words and highlight them
            foreach (var word in incorrectWords)
            {
                int wordStartIndex = text.IndexOf(word, index);

                // Loop through all occurrences of the incorrect word
                while (wordStartIndex >= 0)
                {
                    // Select the word in the RichTextBox
                    txtInput.Select(wordStartIndex, word.Length);

                    // Change the color to red for the selected word
                    txtInput.SelectionColor = Color.Red;

                    // Update the index to start searching after the current word
                    index = wordStartIndex + word.Length;

                    // Find the next occurrence of the same word
                    wordStartIndex = text.IndexOf(word, index);
                }
            }

            // Reset the text color to black after processing all incorrect words
            txtInput.Select(0, 0);
            txtInput.SelectionColor = Color.Black;
        }
    }
}
