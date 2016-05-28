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


            // saving the original caret position + forecolor
            int originalIndex = richTextBox2.SelectionStart;
            int originalLength = richTextBox2.SelectionLength;
            Color originalColor = Color.White;

            // MANDATORY - focuses a label before highlighting (avoids blinking)
            //titleLabel.Focus();

            // removes any previous highlighting (so modified words won't remain highlighted)
            richTextBox2.SelectionStart = 0;
            richTextBox2.SelectionLength = richTextBox2.Text.Length;
            richTextBox2.SelectionColor = originalColor;


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
                richTextBox2.SelectionColor = Color.Green;
            }

            foreach (Match m in stringMatches)
            {
                richTextBox2.SelectionStart = m.Index;
                richTextBox2.SelectionLength = m.Length;
                richTextBox2.SelectionColor = Color.DarkViolet;
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
