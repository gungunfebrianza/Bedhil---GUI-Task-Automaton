using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bedhil
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (tbWorkDir.Text != String.Empty && tbApplicationName.Text != String.Empty && tBAppCommand.Text != String.Empty)
            {
                Form1.arr[0] = tbApplicationName.Text;
                Form1.arr[1] = @tbWorkDir.Text;
                Form1.arr[2] = tBAppCommand.Text;
                this.Close();
            } else
            {
                MessageBox.Show("Fill Task Information", "Bedhil - Task Automaton", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void tbApplicationName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                tbWorkDir.Focus();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tbWorkDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbWorkDir.Text = folderDlg.SelectedPath;
                tBAppCommand.Focus();
            }
        }

        private void tBAppCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                buttonDone.Focus();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            tbWorkDir.Enabled = true;
            tbWorkDir.Text = "";
            tbApplicationName.Text = "";
            tBAppCommand.Text = "";
        }

        private void tbWorkDir_Enter(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbWorkDir.Text = folderDlg.SelectedPath;
                tBAppCommand.Focus();
            }
        }
    }
}
