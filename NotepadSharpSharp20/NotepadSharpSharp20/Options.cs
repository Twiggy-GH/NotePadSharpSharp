using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NotepadSharpSharp20
{
    public partial class Options : Form
    {
        public static string fileLocation;
        public Options()
        {
            InitializeComponent();
            INIParser.checkINI();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(fileLocation) && Path.GetExtension(fileLocation) == ".txt")
            {
                Launcher.forms[1].Show();
                Launcher.forms[0].Hide();
                INIParser.editINI(fileLocation);
            }
            else
            {
                MessageBox.Show("Please choose a text file", "Wrong File Type",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogBox = new OpenFileDialog();
            dialogBox.Title = "Open Text File";
            dialogBox.Filter = "TXT files|*.txt";
            dialogBox.InitialDirectory = @"C:\";
            if (dialogBox.ShowDialog() == DialogResult.OK)
            {
                fileLocation = dialogBox.FileName.ToString();
                txtbxFileBrowser.Text = fileLocation;
            }
        }
    }
}
