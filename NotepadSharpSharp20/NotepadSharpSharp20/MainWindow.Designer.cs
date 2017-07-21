namespace NotepadSharpSharp20
{
    partial class MainWindow
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
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.pnlTblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblDashboardNotes = new System.Windows.Forms.Label();
            this.pnlTxtBox = new System.Windows.Forms.Panel();
            this.rchtxtbxTextBox = new System.Windows.Forms.RichTextBox();
            this.pnlToolbar.SuspendLayout();
            this.pnlTblButtons.SuspendLayout();
            this.pnlTxtBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.Gray;
            this.pnlToolbar.Controls.Add(this.pnlTblButtons);
            this.pnlToolbar.Controls.Add(this.lblDashboardNotes);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(569, 57);
            this.pnlToolbar.TabIndex = 0;
            this.pnlToolbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            // 
            // pnlTblButtons
            // 
            this.pnlTblButtons.ColumnCount = 4;
            this.pnlTblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.pnlTblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.63636F));
            this.pnlTblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.pnlTblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.pnlTblButtons.Controls.Add(this.btnClose, 3, 0);
            this.pnlTblButtons.Controls.Add(this.btnHelp, 2, 0);
            this.pnlTblButtons.Controls.Add(this.btnSettings, 1, 0);
            this.pnlTblButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTblButtons.Location = new System.Drawing.Point(371, 0);
            this.pnlTblButtons.Name = "pnlTblButtons";
            this.pnlTblButtons.RowCount = 1;
            this.pnlTblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlTblButtons.Size = new System.Drawing.Size(198, 57);
            this.pnlTblButtons.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.Purple;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(148, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = " ";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHelp.BackColor = System.Drawing.Color.Purple;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(93, 17);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(43, 23);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = " ";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSettings.BackColor = System.Drawing.Color.Purple;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(38, 17);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(43, 23);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = " ";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblDashboardNotes
            // 
            this.lblDashboardNotes.AutoSize = true;
            this.lblDashboardNotes.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboardNotes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardNotes.ForeColor = System.Drawing.Color.White;
            this.lblDashboardNotes.Location = new System.Drawing.Point(12, 13);
            this.lblDashboardNotes.Name = "lblDashboardNotes";
            this.lblDashboardNotes.Size = new System.Drawing.Size(183, 30);
            this.lblDashboardNotes.TabIndex = 0;
            this.lblDashboardNotes.Text = "Dashboard Notes";
            // 
            // pnlTxtBox
            // 
            this.pnlTxtBox.Controls.Add(this.rchtxtbxTextBox);
            this.pnlTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTxtBox.Location = new System.Drawing.Point(0, 57);
            this.pnlTxtBox.Name = "pnlTxtBox";
            this.pnlTxtBox.Size = new System.Drawing.Size(569, 603);
            this.pnlTxtBox.TabIndex = 1;
            // 
            // rchtxtbxTextBox
            // 
            this.rchtxtbxTextBox.BackColor = System.Drawing.Color.Black;
            this.rchtxtbxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchtxtbxTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxtbxTextBox.ForeColor = System.Drawing.Color.White;
            this.rchtxtbxTextBox.Location = new System.Drawing.Point(0, 0);
            this.rchtxtbxTextBox.Name = "rchtxtbxTextBox";
            this.rchtxtbxTextBox.ReadOnly = true;
            this.rchtxtbxTextBox.Size = new System.Drawing.Size(569, 603);
            this.rchtxtbxTextBox.TabIndex = 0;
            this.rchtxtbxTextBox.Text = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(569, 660);
            this.Controls.Add(this.pnlTxtBox);
            this.Controls.Add(this.pnlToolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.pnlTblButtons.ResumeLayout(false);
            this.pnlTxtBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.TableLayoutPanel pnlTblButtons;
        private System.Windows.Forms.Label lblDashboardNotes;
        private System.Windows.Forms.Panel pnlTxtBox;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.RichTextBox rchtxtbxTextBox;
    }
}