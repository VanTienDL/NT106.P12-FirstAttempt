using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad_FirstAttempt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void oPENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog vantien = new OpenFileDialog();
            vantien.Title = "Open";
            vantien.Filter = "Text Document(*.txt)|*.txt|All files(*.*)|*.*";
            if(vantien.ShowDialog() == DialogResult.OK) { richTextBox1.LoadFile(vantien.FileName,RichTextBoxStreamType.PlainText); }
            this.Text = vantien.FileName;
        }

        private void sAVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog vt = new SaveFileDialog
            {
                Title = "Save any type",
                Filter = "Rich Text Format (*.rtf)|*.rtf|Text Document (*.txt)|*.txt|All Files (*.*)|*.*"
            };

            
            if (vt.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(vt.FileName).ToLower();
                if (extension == ".txt")
                {
                    richTextBox1.SaveFile(vt.FileName, RichTextBoxStreamType.PlainText);
                }
                else
                {
                    richTextBox1.SaveFile(vt.FileName, RichTextBoxStreamType.RichText);
                }
                this.Text = vt.FileName;
            }
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectALLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt= new FontDialog();
            if(fnt.ShowDialog()== DialogResult.OK)
                richTextBox1.Font= fnt.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fnt = new ColorDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = fnt.Color;
        }

        private void sAVEASTEXTFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            SaveFileDialog vantien = new SaveFileDialog();
            vantien.Title = "Save";
            vantien.Filter = "Text Document(*.txt)|*.txt|All files(*.*)|*.*";
            if (vantien.ShowDialog() == DialogResult.OK) { richTextBox1.SaveFile(vantien.FileName, RichTextBoxStreamType.PlainText); }
            this.Text = vantien.FileName;
        }
    }
}
