This project is a text analyzer application built with C# and Windows Forms. It uses the NHunspell library for grammar and spelling checking and various text processing techniques to analyze user input. Below is a detailed breakdown of the code.

![1](https://github.com/user-attachments/assets/1f7a92de-2fdb-41e9-b825-8ad17696f08c)


 ![2](https://github.com/user-attachments/assets/82953423-991b-41a9-9b47-0a2709cc317d)


 1. Namespace and Imports

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; 
using System.Drawing; using System.Linq; using System.Text; using System.Text.RegularExpressions; 
using System.Threading.Tasks; using System.Windows.Forms; using NHunspell;

These are the necessary namespaces:
- System.Windows.Forms: For the graphical user interface (GUI).
- System.Text.RegularExpressions: For pattern matching using regular expressions.
- NHunspell: A library for spelling and grammar checking.
- System.Linq: For functional-style operations like `GroupBy` and `Select`.



 2. Class Structure

public partial class Form1 : Form

This defines a Windows Form, inheriting from `Form`. The class includes event handlers and methods for analyzing text input.



 3. Constructor

public Form1()
{
    InitializeComponent();

    // Attach event handlers for text changes and form load
    txtInput.TextChanged += txtInput_TextChanged;
    this.Load += Form1_Load; 
}

The constructor initializes the form and wires up two key event handlers:
1. `txtInput.TextChanged`: Triggers when the user modifies the text in the input field (`txtInput`).
2. `Form1_Load`: Fires when the form loads.



 4. Form Load Event

private void Form1_Load(object sender, EventArgs e)
{
    this.ActiveControl = txtInput; 
}

Sets the active control to `txtInput` when the form opens, ensuring the text box is ready for input.



 5. TextChanged Event Handler

private void txtInput_TextChanged(object sender, EventArgs e)
{
    UpdateTextDirection();
}

Every time the user types something in the `txtInput`, this handler is triggered. It calls `UpdateTextDirection()` to dynamically adjust the text's direction and alignment.



 6. Text Direction Update

private void UpdateTextDirection()
{
    if (IsArabic(txtInput.Text))
    {
        txtInput.RightToLeft = RightToLeft.Yes;
    }
    else
    {
        txtInput.RightToLeft = RightToLeft.No;
    }
    HandleFirstWordAlignment();
}

This method determines the writing direction:
- Right-to-left (RTL) for Arabic text.
- Left-to-right (LTR) for English text.
- It also ensures the first word is aligned correctly using `HandleFirstWordAlignment()`.



 7. Language Detection

private bool IsArabic(string text)
{
    return Regex.IsMatch(text, @"\p{IsArabic}");
}

private bool IsEnglish(string text)
{
    return Regex.IsMatch(text, @"[a-zA-Z]");
}

- `IsArabic`: Uses a regex to detect Arabic Unicode characters.
- `IsEnglish`: Checks for English letters (a-z, A-Z).



 8. First Word Alignment

private void HandleFirstWordAlignment()
{
    if (IsArabic(txtInput.Text) && !txtInput.Text.StartsWith(" "))
    {
        txtInput.SelectionStart = txtInput.Text.Length;
        txtInput.ScrollToCaret();
    }
    else if (IsEnglish(txtInput.Text) && !txtInput.Text.StartsWith(" "))
    {
        txtInput.SelectionStart = txtInput.Text.Length;
        txtInput.ScrollToCaret();
    }
}

Ensures the first word aligns correctly based on the detected language. For both Arabic and English, it moves the caret to the end of the text.



 9. Analyze Button Click

private async void btnAnalyze_Click(object sender, EventArgs e)
{
    txtGrammarFeedback.Text = "";
    string inputText = txtInput.Text;

    if (string.IsNullOrWhiteSpace(inputText))
    {
        MessageBox.Show("Please enter some text to analyze.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }
    btnAnalyze.Enabled = false;
    pictureBox1.Visible = true;
    await Task.Delay(5000);

    // Perform analysis
    int wordCount = GetWordCount(inputText);
    int letterCount = GetLetterCount(inputText);
    int sentenceCount = GetSentenceCount(inputText);
    string mostFrequentWord = GetMostFrequentWord(inputText);
    double averageReadingTime = GetAverageReadingTime(wordCount);
    int characterCount = GetCharacterCount(inputText);
    string grammarFeedback = CheckGrammar(inputText);

    // Display results
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

When the Analyze button is clicked:
1. Validation: Ensures the text input is not empty.
2. Analysis Execution:
   - Word Count: Total number of words.
   - Letter Count: Letters excluding numbers/symbols.
   - Sentence Count: Based on punctuation.
   - Most Frequent Word: Using LINQ grouping.
   - Reading Time: Assuming 200 words/min.
   - Grammar Feedback: Using NHunspell.
3. UI Updates: Populates results in the respective UI controls.



 10. Text Analysis Helpers
- Word Count:
    
    private int GetWordCount(string text) => Regex.Matches(text, "\\b\\w+\\b").Count;
    
    Uses regex to find all word boundaries (`\b`).
  
- Character Count:
    
    private int GetCharacterCount(string text) => text.Length;
    

- Letter Count:
    
    private int GetLetterCount(string text) => text.Count(char.IsLetter);
    

- Sentence Count:
    
    private int GetSentenceCount(string text) => Regex.Matches(text, "[.!?](\\s|$)").Count;
    
    Matches end-of-sentence punctuation marks.

- Most Frequent Word:
    
    private string GetMostFrequentWord(string text)
    {
        var words = Regex.Matches(text.ToLower(), "\\b\\w+\\b")
                         .Cast<Match>()
                         .Select(m => m.Value);

        return words.GroupBy(w => w)
                    .OrderByDescending(g => g.Count())
                    .FirstOrDefault()?.Key ?? "N/A";
    }
    

- Average Reading Time:
    
    private double GetAverageReadingTime(int wordCount) => wordCount / 200.0;
    



 11. Grammar and Spelling Check

private string CheckGrammar(string text)
{
    bool isArabic = IsArabic(text);
    string affFile = isArabic ? "ar.aff" : "en_US.aff";
    string dicFile = isArabic ? "ar.dic" : "en_US.dic";

    if (!System.IO.File.Exists(affFile) || !System.IO.File.Exists(dicFile))
    {
        return "Dictionary files not found for the selected language.";
    }

    using (var hunspell = new Hunspell(affFile, dicFile))
    {
        var words = Regex.Matches(text, "\\b\\w+\\b")
                         .Cast<Match>()
                         .Select(m => m.Value)
                         .ToList();

        string corrections = "";
        var incorrectWords = new List<string>();

        foreach (var word in words)
        {
            if (!hunspell.Spell(word))
            {
                var suggestions = hunspell.Suggest(word);
                corrections += $"{word}: {string.Join(", ", suggestions)}\n";
                incorrectWords.Add(word);
            }
        }

        HighlightIncorrectWords(text, incorrectWords);

        return string.IsNullOrWhiteSpace(corrections) ? "No spelling errors detected." : corrections;
    }
}

- Detects the language of the text.
- Uses NHunspell to spell-check each word.
- Highlights incorrect words in red in the input box.



 12. Word Highlighting

private void HighlightIncorrectWords(string text, List<string> incorrectWords)

Highlights incorrect words in `txtInput` using `RichTextBox`'s selection color capabilities.



 
This code implements a robust text analyzer with features like:
- Dynamic language detection (Arabic/English).
- Word, letter, character, and sentence counting.
- Reading time estimation.
- Spelling and grammar checks with suggestions.
- Rich text highlighting for incorrect words.
