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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.fileToolStripMenuItem});
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // panel1
            // 
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
            // btnRunScript
            // 
            this.btnRunScript.Location = new System.Drawing.Point(54, 458);
            this.btnRunScript.Name = "btnRunScript";
            this.btnRunScript.Size = new System.Drawing.Size(136, 45);
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
            "Close Selenium"});
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
            this.btnAddToSrcipt.Location = new System.Drawing.Point(54, 399);
            this.btnAddToSrcipt.Name = "btnAddToSrcipt";
            this.btnAddToSrcipt.Size = new System.Drawing.Size(136, 45);
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
    }
}

