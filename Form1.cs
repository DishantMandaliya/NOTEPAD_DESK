using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad_Desk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //code for new option in file menu
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        //code for open file menu 
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new file is a local variable 
            OpenFileDialog newfile = new OpenFileDialog();
            newfile.Title = "open";
            newfile.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";//gets all the types of files
            //if some one clicks on open it open a dialog box 
            if (newfile.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(newfile.FileName, RichTextBoxStreamType.PlainText);
            this.Text = newfile.FileName;

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog newfile = new SaveFileDialog();
            newfile.Title = "save";
            newfile.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";//gets all the types of files
            //if some one clicks on open it open a dialog box 
            if (newfile.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(newfile.FileName, RichTextBoxStreamType.PlainText);
            this.Text = newfile.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = System.DateTime.Now.ToString();
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

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = fnt.Font;

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if (clr.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = clr.Color;
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Dishant Mandaliya");
        }
    }
}
