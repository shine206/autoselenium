namespace AutoSelenium
{
    partial class UCOpenSelenium
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbbBrowser = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Browser:";
            // 
            // cbbBrowser
            // 
            this.cbbBrowser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBrowser.FormattingEnabled = true;
            this.cbbBrowser.Items.AddRange(new object[] {
            "Chrome",
            "FireFox"});
            this.cbbBrowser.Location = new System.Drawing.Point(66, 1);
            this.cbbBrowser.Name = "cbbBrowser";
            this.cbbBrowser.Size = new System.Drawing.Size(138, 24);
            this.cbbBrowser.TabIndex = 3;
            // 
            // UCOpenSelenium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbbBrowser);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCOpenSelenium";
            this.Size = new System.Drawing.Size(215, 27);
            this.Load += new System.EventHandler(this.UCOpenSelenium_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbBrowser;
    }
}
