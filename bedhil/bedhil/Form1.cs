using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bedhil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // alamat startup folder
        String startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.FileName = "cmd.exe";
            startInfo.WorkingDirectory = @tBWorkDirectory.Text;
            startInfo.Arguments = "/c " + tBTestCommand.Text;
            process.StartInfo = startInfo;
            process.Start();
        }

        private void buttonSearchWorkDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                tBWorkDirectory.Text = folderDlg.SelectedPath;
            }
        }

        public static string[] arr = new string[3];
        ListViewItem itm;

        private void addTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 x = new Form2();
                x.ShowDialog();

                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
            catch (Exception)
            {

                throw;
            }
        }



        private void cBTray_CheckedChanged(object sender, EventArgs e)
        {
            if (cBTray.CheckState == CheckState.Checked)
            {
                this.Visible = false;

                //tampilkan judul notif message pada tray icon
                notifyIcon1.BalloonTipTitle = "Bedhil - GUI Task Automaton";

                //tampilkan informasi notif message pada tray icon
                notifyIcon1.BalloonTipText = "Monitoring here..";

                //durasi penampilan notif message tray icon
                notifyIcon1.ShowBalloonTip(2);
            }
            else
            {
                this.Visible = true;
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void executeTaskRunnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonShoot.PerformClick();
        }

        private void loadConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "*.bin|*.bin";
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ListViewItem[] items = null;

                    // Deserialize the items from the binary file.
                    using (System.IO.FileStream fs = System.IO.File.OpenRead(dlg.FileName))
                    {
                        System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        items = (ListViewItem[])bf.Deserialize(fs);
                    }

                    listView1.Items.Clear();
                    // Load the items into the listView1.Items collection.
                    listView1.Items.AddRange(items);
                }
            }
        }

        private void saveConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "*.bin|*.bin";
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ListViewItem[] items = new ListViewItem[listView1.Items.Count];
                    listView1.Items.CopyTo(items, 0);

                    // Serialize the items and save it to a file.
                    using (System.IO.FileStream fs = System.IO.File.Create(dlg.FileName))
                    {
                        System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        bf.Serialize(fs, items);
                    }
                }
            }
        }

        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hideInTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            //tampilkan judul notif message pada tray icon
            notifyIcon1.BalloonTipTitle = "Bedhil - GUI Task Automaton";

            //tampilkan informasi notif message pada tray icon
            notifyIcon1.BalloonTipText = "Monitoring here..";

            //durasi penampilan notif message tray icon
            notifyIcon1.ShowBalloonTip(2);
        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                if (cBNoWindow.Checked == true)
                {
                    startInfo.CreateNoWindow = true;
                    startInfo.FileName = "cmd.exe";
                    startInfo.WorkingDirectory = @listView1.Items[i].SubItems[1].Text;
                    startInfo.Arguments = "/c " + listView1.Items[i].SubItems[2].Text;
                    process.StartInfo = startInfo;
                    process.Start();
                }
                else
                {
                    startInfo.CreateNoWindow = false;
                    startInfo.FileName = "cmd.exe";
                    startInfo.WorkingDirectory = @listView1.Items[i].SubItems[1].Text;
                    startInfo.Arguments = "/c " + listView1.Items[i].SubItems[2].Text;
                    process.StartInfo = startInfo;
                    process.Start();
                }
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // MessageBox.Show(listView1.SelectedItems[0].Index);
            }
        }

        private void executeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            ListViewItem item = listView1.SelectedItems[0];
            if (cBNoWindow.Checked == true)
            {
                startInfo.CreateNoWindow = true;
                startInfo.FileName = "cmd.exe";
                startInfo.WorkingDirectory = @item.SubItems[1].Text;
                startInfo.Arguments = "/c " + item.SubItems[2].Text;
                process.StartInfo = startInfo;
                process.Start();
            }
            else
            {
                startInfo.CreateNoWindow = false;
                startInfo.FileName = "cmd.exe";
                startInfo.WorkingDirectory = @item.SubItems[1].Text;
                startInfo.Arguments = "/c " + item.SubItems[2].Text;
                process.StartInfo = startInfo;
                process.Start();
            }
        }

        private void removeTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(eachItem);
            }
        }

        private void proTaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Designed By Gun Gun Febrianza", "Programmer Tanah Air Indonesia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
