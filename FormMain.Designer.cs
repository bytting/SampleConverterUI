namespace SampleConverterUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSetPluginFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClearFiles = new System.Windows.Forms.Button();
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPluginFolder = new System.Windows.Forms.Label();
            this.cboxPlugins = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxFormat = new System.Windows.Forms.ComboBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbUseScientific = new System.Windows.Forms.CheckBox();
            this.cbUseLabels = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConvert = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menu.SuspendLayout();
            this.tableMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(696, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSetPluginFolder,
            this.toolStripSeparator1,
            this.menuItemExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "&File";
            // 
            // menuItemSetPluginFolder
            // 
            this.menuItemSetPluginFolder.Name = "menuItemSetPluginFolder";
            this.menuItemSetPluginFolder.Size = new System.Drawing.Size(161, 22);
            this.menuItemSetPluginFolder.Text = "&Set plugin folder";
            this.menuItemSetPluginFolder.Click += new System.EventHandler(this.menuItemSetPluginFolder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(161, 22);
            this.menuItemExit.Text = "E&xit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 2;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableMain.Controls.Add(this.label1, 0, 0);
            this.tableMain.Controls.Add(this.label2, 0, 1);
            this.tableMain.Controls.Add(this.label3, 0, 2);
            this.tableMain.Controls.Add(this.label4, 0, 6);
            this.tableMain.Controls.Add(this.panel1, 1, 2);
            this.tableMain.Controls.Add(this.panel4, 1, 0);
            this.tableMain.Controls.Add(this.cboxPlugins, 1, 1);
            this.tableMain.Controls.Add(this.label5, 0, 4);
            this.tableMain.Controls.Add(this.cboxFormat, 1, 4);
            this.tableMain.Controls.Add(this.lbLog, 1, 6);
            this.tableMain.Controls.Add(this.panel5, 0, 3);
            this.tableMain.Controls.Add(this.panel6, 1, 5);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 24);
            this.tableMain.Name = "tableMain";
            this.tableMain.Padding = new System.Windows.Forms.Padding(3);
            this.tableMain.RowCount = 7;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.Size = new System.Drawing.Size(696, 405);
            this.tableMain.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plugin folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Use plugin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Files to convert";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Log";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbFiles);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(116, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 123);
            this.panel1.TabIndex = 5;
            // 
            // lbFiles
            // 
            this.lbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.ItemHeight = 15;
            this.lbFiles.Location = new System.Drawing.Point(0, 0);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbFiles.Size = new System.Drawing.Size(574, 98);
            this.lbFiles.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClearFiles);
            this.panel2.Controls.Add(this.btnAddFiles);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 25);
            this.panel2.TabIndex = 0;
            // 
            // btnClearFiles
            // 
            this.btnClearFiles.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFiles.Location = new System.Drawing.Point(330, 0);
            this.btnClearFiles.Name = "btnClearFiles";
            this.btnClearFiles.Size = new System.Drawing.Size(122, 25);
            this.btnClearFiles.TabIndex = 1;
            this.btnClearFiles.Text = "Clear";
            this.btnClearFiles.UseVisualStyleBackColor = true;
            this.btnClearFiles.Click += new System.EventHandler(this.btnClearFiles_Click);
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFiles.Location = new System.Drawing.Point(452, 0);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(122, 25);
            this.btnAddFiles.TabIndex = 0;
            this.btnAddFiles.Text = "Add files";
            this.btnAddFiles.UseVisualStyleBackColor = true;
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblPluginFolder);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(116, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(574, 24);
            this.panel4.TabIndex = 6;
            // 
            // lblPluginFolder
            // 
            this.lblPluginFolder.AutoSize = true;
            this.lblPluginFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPluginFolder.Location = new System.Drawing.Point(4, 4);
            this.lblPluginFolder.Name = "lblPluginFolder";
            this.lblPluginFolder.Size = new System.Drawing.Size(0, 15);
            this.lblPluginFolder.TabIndex = 1;
            // 
            // cboxPlugins
            // 
            this.cboxPlugins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxPlugins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPlugins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPlugins.FormattingEnabled = true;
            this.cboxPlugins.ItemHeight = 15;
            this.cboxPlugins.Location = new System.Drawing.Point(116, 36);
            this.cboxPlugins.MaxDropDownItems = 20;
            this.cboxPlugins.Name = "cboxPlugins";
            this.cboxPlugins.Size = new System.Drawing.Size(574, 23);
            this.cboxPlugins.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Output format";
            // 
            // cboxFormat
            // 
            this.cboxFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxFormat.FormattingEnabled = true;
            this.cboxFormat.Items.AddRange(new object[] {
            "csv",
            "xml",
            "json",
            "kmz"});
            this.cboxFormat.Location = new System.Drawing.Point(116, 215);
            this.cboxFormat.Name = "cboxFormat";
            this.cboxFormat.Size = new System.Drawing.Size(574, 23);
            this.cboxFormat.TabIndex = 9;
            // 
            // lbLog
            // 
            this.lbLog.BackColor = System.Drawing.SystemColors.Info;
            this.lbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 15;
            this.lbLog.Location = new System.Drawing.Point(116, 275);
            this.lbLog.Name = "lbLog";
            this.lbLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbLog.Size = new System.Drawing.Size(574, 124);
            this.lbLog.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GrayText;
            this.tableMain.SetColumnSpan(this.panel5, 2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(12, 201);
            this.panel5.Margin = new System.Windows.Forms.Padding(9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(672, 2);
            this.panel5.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbUseScientific);
            this.panel6.Controls.Add(this.cbUseLabels);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(116, 245);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(574, 24);
            this.panel6.TabIndex = 12;
            // 
            // cbUseScientific
            // 
            this.cbUseScientific.AutoSize = true;
            this.cbUseScientific.Checked = true;
            this.cbUseScientific.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseScientific.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbUseScientific.Location = new System.Drawing.Point(127, 0);
            this.cbUseScientific.Name = "cbUseScientific";
            this.cbUseScientific.Size = new System.Drawing.Size(130, 24);
            this.cbUseScientific.TabIndex = 1;
            this.cbUseScientific.Text = "Use scientific notation";
            this.cbUseScientific.UseVisualStyleBackColor = true;
            // 
            // cbUseLabels
            // 
            this.cbUseLabels.AutoSize = true;
            this.cbUseLabels.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbUseLabels.Location = new System.Drawing.Point(0, 0);
            this.cbUseLabels.Name = "cbUseLabels";
            this.cbUseLabels.Size = new System.Drawing.Size(127, 24);
            this.cbUseLabels.TabIndex = 0;
            this.cbUseLabels.Text = "Use placemark labels";
            this.cbUseLabels.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnConvert);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 429);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panel3.Size = new System.Drawing.Size(696, 25);
            this.panel3.TabIndex = 4;
            // 
            // btnConvert
            // 
            this.btnConvert.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(568, 0);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(123, 25);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.Multiselect = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 464);
            this.Controls.Add(this.tableMain);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(710, 500);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Text = "SampleConverter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tableMain.ResumeLayout(false);
            this.tableMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddFiles;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClearFiles;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cboxPlugins;
        private System.Windows.Forms.Label lblPluginFolder;
        private System.Windows.Forms.ToolStripMenuItem menuItemSetPluginFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxFormat;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox cbUseScientific;
        private System.Windows.Forms.CheckBox cbUseLabels;
    }
}

