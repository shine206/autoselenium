namespace AutoSelenium
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnTestScript = new System.Windows.Forms.Button();
            this.btnRunScript = new System.Windows.Forms.Button();
            this.grbAction = new System.Windows.Forms.GroupBox();
            this.cbbAction = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddToSrcipt = new System.Windows.Forms.Button();
            this.lvScript = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.scriptToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // scriptToolStripMenuItem
            // 
            this.scriptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem});
            this.scriptToolStripMenuItem.Name = "scriptToolStripMenuItem";
            this.scriptToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.scriptToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.scriptToolStripMenuItem.Text = "Script";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.runToolStripMenuItem.Text = "&Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnTestScript);
            this.panel1.Controls.Add(this.btnRunScript);
            this.panel1.Controls.Add(this.grbAction);
            this.panel1.Controls.Add(this.cbbAction);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddToSrcipt);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 513);
            this.panel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(68, 379);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 45);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete script";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(123, 311);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 45);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update script";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnTestScript
            // 
            this.btnTestScript.Location = new System.Drawing.Point(26, 458);
            this.btnTestScript.Name = "btnTestScript";
            this.btnTestScript.Size = new System.Drawing.Size(86, 45);
            this.btnTestScript.TabIndex = 6;
            this.btnTestScript.Text = "Test script";
            this.btnTestScript.UseVisualStyleBackColor = true;
            this.btnTestScript.Click += new System.EventHandler(this.btnTestScript_Click);
            // 
            // btnRunScript
            // 
            this.btnRunScript.Location = new System.Drawing.Point(130, 458);
            this.btnRunScript.Name = "btnRunScript";
            this.btnRunScript.Size = new System.Drawing.Size(86, 45);
            this.btnRunScript.TabIndex = 5;
            this.btnRunScript.Text = "Run Script";
            this.btnRunScript.UseVisualStyleBackColor = true;
            this.btnRunScript.Click += new System.EventHandler(this.btnRunScript_Click);
            // 
            // grbAction
            // 
            this.grbAction.Location = new System.Drawing.Point(9, 40);
            this.grbAction.Name = "grbAction";
            this.grbAction.Size = new System.Drawing.Size(222, 100);
            this.grbAction.TabIndex = 4;
            this.grbAction.TabStop = false;
            this.grbAction.Text = "Options";
            // 
            // cbbAction
            // 
            this.cbbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAction.FormattingEnabled = true;
            this.cbbAction.Items.AddRange(new object[] {
            "Open Selenium",
            "Go to URL",
            "Click",
            "Send",
            "Sleep",
            "Wait Element",
            "Close Selenium",
            "Run Javascript"});
            this.cbbAction.Location = new System.Drawing.Point(63, 10);
            this.cbbAction.Name = "cbbAction";
            this.cbbAction.Size = new System.Drawing.Size(168, 24);
            this.cbbAction.TabIndex = 3;
            this.cbbAction.SelectedIndexChanged += new System.EventHandler(this.cbbAction_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Action:";
            // 
            // btnAddToSrcipt
            // 
            this.btnAddToSrcipt.Location = new System.Drawing.Point(19, 311);
            this.btnAddToSrcipt.Name = "btnAddToSrcipt";
            this.btnAddToSrcipt.Size = new System.Drawing.Size(98, 45);
            this.btnAddToSrcipt.TabIndex = 0;
            this.btnAddToSrcipt.Text = "Add to script";
            this.btnAddToSrcipt.UseVisualStyleBackColor = true;
            this.btnAddToSrcipt.Click += new System.EventHandler(this.btnAddToSrcipt_Click);
            // 
            // lvScript
            // 
            this.lvScript.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvScript.FullRowSelect = true;
            this.lvScript.Location = new System.Drawing.Point(246, 27);
            this.lvScript.Name = "lvScript";
            this.lvScript.Size = new System.Drawing.Size(678, 513);
            this.lvScript.TabIndex = 2;
            this.lvScript.UseCompatibleStateImageBehavior = false;
            this.lvScript.View = System.Windows.Forms.View.Details;
            this.lvScript.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvScript_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Action";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Script";
            this.columnHeader3.Width = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 542);
            this.Controls.Add(this.lvScript);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddToSrcipt;
        private System.Windows.Forms.GroupBox grbAction;
        private System.Windows.Forms.ListView lvScript;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnRunScript;
        private System.Windows.Forms.Button btnTestScript;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripMenuItem scriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
    }
}

