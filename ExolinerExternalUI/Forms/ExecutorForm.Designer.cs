using System.Windows.Forms;

namespace ExolinerExternalUI {
    partial class ExecutorForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExecutorForm));
            this.scriptsList = new System.Windows.Forms.ListBox();
            this.bottomButtons = new System.Windows.Forms.Panel();
            this.r6Button = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.executionStatus = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rankLabel = new System.Windows.Forms.Label();
            this.convertCheck = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.executeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scriptPages = new System.Windows.Forms.TabControl();
            this.tabPlus = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executionWorker = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.scriptsListTimer = new System.Windows.Forms.Timer(this.components);
            this.processScanTimer = new System.Windows.Forms.Timer(this.components);
            this.bottomButtons.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.scriptPages.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // scriptsList
            // 
            this.scriptsList.BackColor = System.Drawing.SystemColors.Window;
            this.scriptsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scriptsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scriptsList.FormattingEnabled = true;
            this.scriptsList.Location = new System.Drawing.Point(0, 0);
            this.scriptsList.Name = "scriptsList";
            this.scriptsList.Size = new System.Drawing.Size(200, 401);
            this.scriptsList.TabIndex = 1;
            this.scriptsList.SelectedIndexChanged += new System.EventHandler(this.scriptsList_SelectedIndexChanged);
            // 
            // bottomButtons
            // 
            this.bottomButtons.Controls.Add(this.r6Button);
            this.bottomButtons.Controls.Add(this.refreshButton);
            this.bottomButtons.Controls.Add(this.executionStatus);
            this.bottomButtons.Controls.Add(this.panel3);
            this.bottomButtons.Controls.Add(this.clearButton);
            this.bottomButtons.Controls.Add(this.executeButton);
            this.bottomButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomButtons.Location = new System.Drawing.Point(5, 430);
            this.bottomButtons.Name = "bottomButtons";
            this.bottomButtons.Padding = new System.Windows.Forms.Padding(5);
            this.bottomButtons.Size = new System.Drawing.Size(809, 40);
            this.bottomButtons.TabIndex = 2;
            // 
            // r6Button
            // 
            this.r6Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.r6Button.Location = new System.Drawing.Point(554, 5);
            this.r6Button.Name = "r6Button";
            this.r6Button.Size = new System.Drawing.Size(45, 30);
            this.r6Button.TabIndex = 0;
            this.r6Button.Text = "R6";
            this.r6Button.UseVisualStyleBackColor = true;
            this.r6Button.Click += new System.EventHandler(this.r6Button_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.refreshButton.Location = new System.Drawing.Point(599, 5);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(45, 30);
            this.refreshButton.TabIndex = 6;
            this.refreshButton.Text = "RE";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // executionStatus
            // 
            this.executionStatus.BackColor = System.Drawing.Color.Transparent;
            this.executionStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.executionStatus.Location = new System.Drawing.Point(293, 5);
            this.executionStatus.Name = "executionStatus";
            this.executionStatus.Size = new System.Drawing.Size(150, 30);
            this.executionStatus.TabIndex = 5;
            this.executionStatus.Text = "execution status: idle";
            this.executionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rankLabel);
            this.panel3.Controls.Add(this.convertCheck);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(644, 5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(160, 30);
            this.panel3.TabIndex = 2;
            // 
            // rankLabel
            // 
            this.rankLabel.BackColor = System.Drawing.Color.Transparent;
            this.rankLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rankLabel.Location = new System.Drawing.Point(10, 0);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(150, 13);
            this.rankLabel.TabIndex = 4;
            // 
            // convertCheck
            // 
            this.convertCheck.AutoSize = true;
            this.convertCheck.BackColor = System.Drawing.Color.Transparent;
            this.convertCheck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.convertCheck.Location = new System.Drawing.Point(10, 13);
            this.convertCheck.Name = "convertCheck";
            this.convertCheck.Size = new System.Drawing.Size(150, 17);
            this.convertCheck.TabIndex = 3;
            this.convertCheck.Text = "Convert";
            this.convertCheck.UseVisualStyleBackColor = false;
            // 
            // clearButton
            // 
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.clearButton.Location = new System.Drawing.Point(149, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(144, 30);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // executeButton
            // 
            this.executeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.executeButton.Location = new System.Drawing.Point(5, 5);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(144, 30);
            this.executeButton.TabIndex = 0;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.scriptPages);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bottomButtons);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 29, 5, 5);
            this.panel1.Size = new System.Drawing.Size(819, 475);
            this.panel1.TabIndex = 3;
            // 
            // scriptPages
            // 
            this.scriptPages.AllowDrop = true;
            this.scriptPages.Controls.Add(this.tabPlus);
            this.scriptPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scriptPages.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.scriptPages.ItemSize = new System.Drawing.Size(53, 20);
            this.scriptPages.Location = new System.Drawing.Point(5, 29);
            this.scriptPages.Name = "scriptPages";
            this.scriptPages.Padding = new System.Drawing.Point(12, 4);
            this.scriptPages.SelectedIndex = 0;
            this.scriptPages.Size = new System.Drawing.Size(609, 401);
            this.scriptPages.TabIndex = 4;
            this.scriptPages.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.scriptPages_DrawItem);
            this.scriptPages.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.scriptPages_Selecting);
            this.scriptPages.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scriptPages_MouseDown);
            // 
            // tabPlus
            // 
            this.tabPlus.Location = new System.Drawing.Point(4, 24);
            this.tabPlus.Name = "tabPlus";
            this.tabPlus.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlus.Size = new System.Drawing.Size(601, 373);
            this.tabPlus.TabIndex = 1;
            this.tabPlus.Text = "+";
            this.tabPlus.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.scriptsList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(614, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 401);
            this.panel2.TabIndex = 3;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(819, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // executionWorker
            // 
            this.executionWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.executionWorker_DoWork);
            this.executionWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.executionWorker_RunWorkerCompleted);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Lua files|*.lua|Luau files|*.luau|Text files|*.txt|All files|*.*";
            this.openFileDialog.InitialDirectory = ".";
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "luau";
            this.saveFileDialog.Filter = "Lua files|*.lua|Luau files|*.luau|Text files|*.txt|All files|*.*";
            this.saveFileDialog.InitialDirectory = ".";
            this.saveFileDialog.RestoreDirectory = true;
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // scriptsListTimer
            // 
            this.scriptsListTimer.Enabled = true;
            this.scriptsListTimer.Interval = 3000;
            this.scriptsListTimer.Tick += new System.EventHandler(this.scriptsListTimer_Tick);
            // 
            // processScanTimer
            // 
            this.processScanTimer.Enabled = true;
            this.processScanTimer.Interval = 1000;
            this.processScanTimer.Tick += new System.EventHandler(this.processScanTimer_Tick);
            // 
            // ExecutorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 475);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ExecutorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exoliner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExecutorForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bottomButtons.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.scriptPages.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox scriptsList;
        private System.Windows.Forms.Panel bottomButtons;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox convertCheck;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label executionStatus;
        private System.ComponentModel.BackgroundWorker executionWorker;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TabControl scriptPages;
        private System.Windows.Forms.TabPage tabPlus;
        private Button r6Button;
        private Button refreshButton;
        private Timer scriptsListTimer;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private Timer processScanTimer;
    }
}

