namespace PDMImporterApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_vaultPath = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox_vaultName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 117);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 44);
            this.button1.TabIndex = 25;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_vaultPath
            // 
            this.textBox_vaultPath.Location = new System.Drawing.Point(214, 119);
            this.textBox_vaultPath.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_vaultPath.Name = "textBox_vaultPath";
            this.textBox_vaultPath.Size = new System.Drawing.Size(350, 31);
            this.textBox_vaultPath.TabIndex = 23;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(30, 125);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(126, 35);
            this.textBox4.TabIndex = 24;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "Vault Path:";
            // 
            // textBox_vaultName
            // 
            this.textBox_vaultName.Location = new System.Drawing.Point(214, 48);
            this.textBox_vaultName.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_vaultName.Name = "textBox_vaultName";
            this.textBox_vaultName.Size = new System.Drawing.Size(350, 31);
            this.textBox_vaultName.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(30, 54);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 35);
            this.textBox2.TabIndex = 22;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Vault Name:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(580, 192);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 44);
            this.button2.TabIndex = 28;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(214, 194);
            this.textBox_path.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(350, 31);
            this.textBox_path.TabIndex = 26;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(30, 200);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(172, 35);
            this.textBox3.TabIndex = 27;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Folder To Import:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(214, 267);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 44);
            this.button3.TabIndex = 29;
            this.button3.Text = "Run";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(30, 339);
            this.textBox5.Margin = new System.Windows.Forms.Padding(6);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(98, 35);
            this.textBox5.TabIndex = 31;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Result:";
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_result.Location = new System.Drawing.Point(140, 339);
            this.textBox_result.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(562, 87);
            this.textBox_result.TabIndex = 32;
            this.textBox_result.TabStop = false;
            this.textBox_result.Text = "Click Run to Start";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 454);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_vaultPath);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox_vaultName);
            this.Controls.Add(this.textBox2);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "PDM Importer App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_vaultPath;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox_vaultName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox_result;
    }
}

