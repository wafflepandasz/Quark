using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Quark : Form
    {
        public Quark()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamWriter sr = new System.IO.StreamWriter(sfd.FileName))
                {
                    foreach (var line in richTextBox2.Lines)
                    {
                        sr.WriteLine(line);
                    }
                }
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName))
                {
                    richTextBox2.Text = sr.ReadToEnd();
                }
            }
        }

        
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            // getting keywords/functions
            string keywords = @"\b(public|private|partial|static|namespace|class|using|void|foreach|in|var|function|if|for|while)\b";
            MatchCollection keywordMatches = Regex.Matches(richTextBox2.Text, keywords);

            // getting types/classes from the text 
            string types = @"\b(Console)\b";
            MatchCollection typeMatches = Regex.Matches(richTextBox2.Text, types);

            // getting comments (inline or multiline)
            string comments = @"(\/\/.+?$|\/\*.+?\*\/)";
            MatchCollection commentMatches = Regex.Matches(richTextBox2.Text, comments, RegexOptions.Multiline);

            // getting strings
            string strings = "\".+?\"";
            MatchCollection stringMatches = Regex.Matches(richTextBox2.Text, strings);

            // getting numbers
            string numbers1 = "1";
            MatchCollection numbers1Matches = Regex.Matches(richTextBox2.Text, numbers1);

            string numbers2 = "2";
            MatchCollection numbers2Matches = Regex.Matches(richTextBox2.Text, numbers2);

            string numbers3 = "3";
            MatchCollection numbers3Matches = Regex.Matches(richTextBox2.Text, numbers3);

            string numbers4 = "4";
            MatchCollection numbers4Matches = Regex.Matches(richTextBox2.Text, numbers4);

            string numbers5 = "5";
            MatchCollection numbers5Matches = Regex.Matches(richTextBox2.Text, numbers5);

            string numbers6 = "6";
            MatchCollection numbers6Matches = Regex.Matches(richTextBox2.Text, numbers6);

            string numbers7 = "7";
            MatchCollection numbers7Matches = Regex.Matches(richTextBox2.Text, numbers7);

            string numbers8 = "8";
            MatchCollection numbers8Matches = Regex.Matches(richTextBox2.Text, numbers8);

            string numbers9 = "9";
            MatchCollection numbers9Matches = Regex.Matches(richTextBox2.Text, numbers9);

            string numbers0 = "0";
            MatchCollection numbers0Matches = Regex.Matches(richTextBox2.Text, numbers0);

            // saving the original caret position + forecolor
            int originalIndex = richTextBox2.SelectionStart;
            int originalLength = richTextBox2.SelectionLength;
            Color originalColor = Color.White;



        // MANDATORY - focuses a label before highlighting (avoids blinking)
        label1.Focus();

        // removes any previous highlighting (so modified words won't remain highlighted)
        richTextBox2.SelectionStart = 0;
            richTextBox2.SelectionLength = richTextBox2.Text.Length;
            richTextBox2.SelectionColor = originalColor;

            // MANDATORY - focuses a label before highlighting (avoids blinking)
            label1.Focus();

            // scanning...
            foreach (Match m in keywordMatches)
            {
                richTextBox2.SelectionStart = m.Index;
                richTextBox2.SelectionLength = m.Length;
                richTextBox2.SelectionColor = Color.DeepPink;
            }


            foreach (Match m in typeMatches)
            {
                richTextBox2.SelectionStart = m.Index;
                richTextBox2.SelectionLength = m.Length;
                richTextBox2.SelectionColor = Color.DarkCyan;
            }

            foreach (Match m in commentMatches)
            {
                richTextBox2.SelectionStart = m.Index;
                richTextBox2.SelectionLength = m.Length;
                richTextBox2.SelectionColor = Color.MediumSpringGreen;
            }

            foreach (Match m in stringMatches)
            {
                richTextBox2.SelectionStart = m.Index;
                richTextBox2.SelectionLength = m.Length;
                richTextBox2.SelectionColor = Color.DarkOrange;
            }

            foreach (Match m in numbers1Matches)
            {
                richTextBox2.SelectionStart = m.Index;
                richTextBox2.SelectionLength = m.Length;
                richTextBox2.SelectionColor = Color.Cyan;
            }

            foreach (Match m in numbers2Matches)
            {
                richTextBox2.SelectionStart = m.Index;
                richTextBox2.SelectionLength = m.Length;
                richTextBox2.SelectionColor = Color.Cyan;
            }

            foreach (Match m in numbers3Matches)
            {
                richTextBox2.SelectionStart = m.Index;
                richTextBox2.SelectionLength = m.Length;
                richTextBox2.SelectionColor = Color.Cyan;
            }

            foreach (Match m in numbers4Matches)
            {
                richTextBox2.SelectionStart = m.Index;
                richTextBox2.SelectionLength = m.Length;
                richTextBox2.SelectionColor = Color.Cyan;
            }

            foreach (Match m in numbers5Matches)
            {
                richTextBox2.SelectionStart = m.Index;
                richTextBox2.SelectionLength = m.Length;
                richTextBox2.SelectionColor = Color.Cyan;
            }


            foreach (Match m in numbers6Matches)
            {
                richTextBox2.SelectionStart = m.Index;
                richTextBox2.SelectionLength = m.Length;
                richTextBox2.SelectionColor = Color.Cyan;
            }

            foreach (Match m in numbers7Matches)
            {
                richTextBox2.SelectionStart = m.Index;
                richTextBox2.SelectionLength = m.Length;
                richTextBox2.SelectionColor = Color.Cyan;
            }

            foreach (Match m in numbers8Matches)
            {
                richTextBox2.SelectionStart = m.Index;
                richTextBox2.SelectionLength = m.Length;
                richTextBox2.SelectionColor = Color.Cyan;
            }

            foreach (Match m in numbers9Matches)
            {
                richTextBox2.SelectionStart = m.Index;
                richTextBox2.SelectionLength = m.Length;
                richTextBox2.SelectionColor = Color.Cyan;
            }

            foreach (Match m in numbers0Matches)
            {
                richTextBox2.SelectionStart = m.Index;
                richTextBox2.SelectionLength = m.Length;
                richTextBox2.SelectionColor = Color.Cyan;
            }

            // restoring the original colors, for further writing
            richTextBox2.SelectionStart = originalIndex;
            richTextBox2.SelectionLength = originalLength;
            richTextBox2.SelectionColor = originalColor;

            // giving back the focus
            richTextBox2.Focus();   
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamWriter sr = new System.IO.StreamWriter(sfd.FileName))
                {
                    foreach (var line in richTextBox2.Lines)
                    {
                        sr.WriteLine(line);
                    }
                }
            }
        }
    }
}
