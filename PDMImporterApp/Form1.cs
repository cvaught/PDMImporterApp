using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using EdmLib;


namespace PDMImporterApp
{
    public partial class Form1 : Form
    {
        EdmVault5 vault;

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

            String result = "";
            int parentWnd = this.Handle.ToInt32();
            // get file from the source folder
            string[] filesToImport = Directory.GetFiles(importPath);
            if (filesToImport.Length > 0)
            {
                // connect to the pdm vault
                if (connectToVault(vaultName))
                {
                    // get the folder in epdm that the files will be imported into
                    IEdmFolder6 folderObj = (IEdmFolder6)vault.GetFolderFromPath(vaultPath);
                    if (folderObj != null)
                    {
                        // import the files into the vault using AddFile and AddFiles
                        foreach (String file in filesToImport)
                        {
                            folderObj.AddFile(parentWnd, file, "", (int)EdmAddFlag.EdmAdd_Simple);
                        }
                        
                        folderObj.Refresh();

                        // check the files in
                        foreach (String file in filesToImport)
                        {
                            IEdmFile5 aFile = folderObj.GetFile(Path.GetFileName(file));
                            if (aFile != null)
                            {
                                aFile.UnlockFile(parentWnd, "Auto imported.");
                                aFile.ChangeState("Approved", folderObj.ID, "Auto approved.", this.Handle.ToInt32());
                            }
                        }

                        result = "Files have been added to the vault.";
                    }
                    else
                    {
                        result = "Folder in vault could not be found.";
                    }
                }
                else
                {
                    result = "Could not connect to the vault.";
                }
            }
            else
            {
                result = "There are no files to import.";
            }

            this.textBox_result.Text = result;
        }

        private Boolean connectToVault(String vaultName)
        {
            try
            {
                if (vault == null)
                {
                    vault = new EdmVault5();
                }
                if (!vault.IsLoggedIn)
                {
                    vault.LoginAuto(vaultName, this.Handle.ToInt32());
                }
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
