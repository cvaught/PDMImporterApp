using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace PDMImporterApp
{
    public partial class Form1 : Form
    {

        #region Handle form loading

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.loadDefaults();
        }

        private void loadDefaults()
        {
            this.textBox_vaultName.Text = Properties.Settings.Default.VaultName;
            this.textBox_path.Text = Properties.Settings.Default.Path;
            this.textBox_vaultPath.Text = Properties.Settings.Default.VaultPath;
        }

        #endregion

        #region Handle Browse Buttons

        private void button1_Click(object sender, EventArgs e)
        {
            // the browse to vault path button was pressed
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.RootFolder = Environment.SpecialFolder.Desktop;
            String path = this.textBox_vaultPath.Text;
            if (path != null && path.Length > 0)
            {
                if (path != null && Directory.Exists(path))
                {
                    dlg.SelectedPath = path;
                }
            }

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.textBox_vaultPath.Text = dlg.SelectedPath;

                Properties.Settings.Default.VaultPath = this.textBox_vaultPath.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // the browse to vault path button was pressed
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.RootFolder = Environment.SpecialFolder.Desktop;
            String path = this.textBox_path.Text;
            if (path != null && path.Length > 0)
            {
                if (path != null && Directory.Exists(path))
                {
                    dlg.SelectedPath = path;
                }
            }

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.textBox_path.Text = dlg.SelectedPath;

                Properties.Settings.Default.Path = this.textBox_path.Text;
                Properties.Settings.Default.Save();
            }
        }

        #endregion

        private void saveInputLocally()
        {
            Properties.Settings.Default.VaultPath = this.textBox_vaultPath.Text;
            Properties.Settings.Default.Path = this.textBox_path.Text;
            Properties.Settings.Default.VaultName = this.textBox_vaultName.Text;
            Properties.Settings.Default.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.saveInputLocally();

            String vaultName = this.textBox_vaultName.Text;
            String vaultPath = this.textBox_vaultPath.Text;
            String importPath = this.textBox_path.Text;


            this.textBox_result.Text = "Start button clicked. Nothing exciting is happening yet.";
        }
    }
}
