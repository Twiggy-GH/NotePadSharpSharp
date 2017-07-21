namespace NotepadSharpSharp20
{
    partial class Options
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
            this.pnlMainOptions = new System.Windows.Forms.Panel();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.txtbxFileBrowser = new System.Windows.Forms.TextBox();
            this.lblExample = new System.Windows.Forms.Label();
            this.lblChooseFile = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pnlMainOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainOptions
            // 
            this.pnlMainOptions.Controls.Add(this.btnLaunch);
            this.pnlMainOptions.Controls.Add(this.txtbxFileBrowser);
            this.pnlMainOptions.Controls.Add(this.lblExample);
            this.pnlMainOptions.Controls.Add(this.lblChooseFile);
            this.pnlMainOptions.Controls.Add(this.btnBrowse);
            this.pnlMainOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainOptions.Location = new System.Drawing.Point(0, 0);
            this.pnlMainOptions.Name = "pnlMainOptions";
            this.pnlMainOptions.Size = new System.Drawing.Size(442, 131);
            this.pnlMainOptions.TabIndex = 0;
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(170, 86);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(102, 32);
            this.btnLaunch.TabIndex = 4;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // txtbxFileBrowser
            // 
            this.txtbxFileBrowser.Location = new System.Drawing.Point(95, 60);
            this.txtbxFileBrowser.Name = "txtbxFileBrowser";
            this.txtbxFileBrowser.ReadOnly = true;
            this.txtbxFileBrowser.Size = new System.Drawing.Size(338, 20);
            this.txtbxFileBrowser.TabIndex = 3;
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExample.ForeColor = System.Drawing.Color.Red;
            this.lblExample.Location = new System.Drawing.Point(110, 30);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(223, 17);
            this.lblExample.TabIndex = 2;
            this.lblExample.Text = "ex: \\\\10.200.0.55\\Dashboard\\dash.txt";
            // 
            // lblChooseFile
            // 
            this.lblChooseFile.AutoSize = true;
            this.lblChooseFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseFile.Location = new System.Drawing.Point(9, 9);
            this.lblChooseFile.Name = "lblChooseFile";
            this.lblChooseFile.Size = new System.Drawing.Size(424, 21);
            this.lblChooseFile.TabIndex = 1;
            this.lblChooseFile.Text = "Choose the file containing the text you would like to display:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(13, 58);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 131);
            this.Controls.Add(this.pnlMainOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Options";
            this.Text = "NotepadSharpSharp";
            this.pnlMainOptions.ResumeLayout(false);
            this.pnlMainOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainOptions;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.TextBox txtbxFileBrowser;
        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.Label lblChooseFile;
        private System.Windows.Forms.Button btnBrowse;
    }
}

