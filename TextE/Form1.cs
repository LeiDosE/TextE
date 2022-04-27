using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace TextE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt";
            Check();
            
        }

        private void Check()
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                 @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

            Regex regExp = new Regex(pattern);

            foreach (Match match in regExp.Matches(richTextBox1.Text))
            {
                richTextBox1.Select(match.Index, match.Length);
                richTextBox1.SelectionColor = Color.Blue;
            }
        }
        private void SaveAsStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, richTextBox1.Text);
            MessageBox.Show("Файл сохранен!");
        }
        private void OpenStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename);
            richTextBox1.Text = fileText;

            MessageBox.Show("Файл открыт!");
        }

        private void SaveStripMenuItem1_Click(object sender, EventArgs e)
        {

        }


        /// /////////////////////////////


        private void CopyStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
                richTextBox1.Copy();
        }
        private void PasteStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
                richTextBox1.Paste();
        }

        private void CutStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
                richTextBox1.Cut();
        }

        private void FontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        /// /////////////////////////////////////////

        private void InfoStripMenuItem1_Click(object sender, EventArgs e)
        {

            char[] ch = richTextBox1.Text.ToCharArray();
            var dCount = ch.Where((n) => n >= '0' && n <= '9').Count();

            int vCount = 0, cCount = 0;

            foreach(char c in richTextBox1.Text)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    if (c == 'i' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                        vCount++;
                    else
                        if (c == 'I' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                        vCount++;
                    else
                        cCount++;
                }
                    
            }

            var authorPages = 1;

            if(richTextBox1.Text.Length > 1800)
                authorPages++;

            var emptyLineCount = richTextBox1.Lines.Count(x => string.IsNullOrEmpty(x));
            var lineCount = richTextBox1.Lines.Count();
            var Bytes = richTextBox1.Text.Length * sizeof(Char);
            MessageBox.Show("\nCharacter count is " + richTextBox1.Text.Length + "\nSize in Bytes " + Bytes + "\nLine number is " 
                + lineCount.ToString() + "\nEmpty line " + emptyLineCount + "\nAuthor pages " + authorPages +
                "\nNumber of Vowels is " + vCount + "\nNumber of Consonants is " + cCount +
                "\nDigit number is " + dCount + "\nSpecial symbol is " + richTextBox1.Text.Count(char.IsPunctuation));
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                richTextBox1.ContextMenuStrip = contextMenuStrip1;
        }

        private void CopyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
                richTextBox1.Copy();
        }

        private void PasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
                richTextBox1.Paste();
        }

        private void CutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
                richTextBox1.Cut();
        }


    }
}
