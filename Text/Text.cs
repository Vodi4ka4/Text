using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Text
{
    public partial class Text : Form
    {
        public Text()
        {
            InitializeComponent();
        }

        private void Text_Load(object sender, EventArgs e)
        {

        }

        private void button_open_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Текстовые файлы (*.txt)|*.txt"
            };

            if (dialog.ShowDialog() == DialogResult.OK && File.Exists(dialog.FileName))
            {
                Text_text.LoadFile(dialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void button_save_file_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "Текстовые файлы(.txt) |.txt",
                RestoreDirectory = false
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Text_text.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void button_copy_Click(object sender, EventArgs e)
        {
            if (Text_text.SelectedText.Length > 0)
            {
                Text_text.Copy();
            }
            else
            {
                MessageBox.Show("Выделите текст для копирования");
            }
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            try
            {
                Text_text.Paste();
            }
            catch
            {
                MessageBox.Show("Вставка данных такого формата недоступна");
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            Text_text.SelectAll();
            Text_text.SelectionBackColor = Text_text.BackColor;

            Regex regex = new Regex(Regex.Escape(textBox_search.Text), RegexOptions.IgnoreCase);

            MatchCollection matches = regex.Matches(Text_text.Text);

            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    Text_text.SelectionStart = match.Index;
                    Text_text.SelectionLength = match.Length;
                    Text_text.SelectionBackColor = Color.Yellow;
                }
            }
            else
            {
                MessageBox.Show("Текст не найден");
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_old.Text == "" || textBox_new.Text == "")
            {
                MessageBox.Show("Укажите все обязательные поля для замены");
                return;
            }

            Text_text.Text = Text_text.Text.Replace(textBox_old.Text, textBox_new.Text);
        }

        private void button_fat_Click(object sender, EventArgs e)
        {
            if (Text_text.SelectionFont != null)
            {
                FontStyle currentStyle = Text_text.SelectionFont.Style;
                FontStyle newStyle = currentStyle ^ FontStyle.Bold;
                Text_text.SelectionFont = new Font(Text_text.SelectionFont, newStyle);
            }
        }

        private void button_italics_Click(object sender, EventArgs e)
        {
            if (Text_text.SelectionFont != null)
            {
                FontStyle currentStyle = Text_text.SelectionFont.Style;
                FontStyle newStyle = currentStyle ^ FontStyle.Italic;
                Text_text.SelectionFont = new Font(Text_text.SelectionFont, newStyle);
            }
        }

        private void button_emphasized_Click(object sender, EventArgs e)
        {
            if (Text_text.SelectionFont != null)
            {
                FontStyle currentStyle = Text_text.SelectionFont.Style;
                FontStyle newStyle = currentStyle ^ FontStyle.Strikeout;
                Text_text.SelectionFont = new Font(Text_text.SelectionFont, newStyle);
            }
        }

        private void button_Font_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                if (Text_text.SelectedText.Length > 0)
                {
                    Text_text.SelectionFont = fd.Font;
                }
                else
                {
                    Text_text.Font = fd.Font;
                }
            }
        }
    }
}
