namespace AutoSelenium
{
    partial class UCClick
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
            this.txtElement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbBy = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "By:";
            // 
            // txtElement
            // 
            this.txtElement.Location = new System.Drawing.Point(60, 40);
            this.txtElement.Name = "txtElement";
            this.txtElement.Size = new System.Drawing.Size(146, 23);
            this.txtElement.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Element:";
            // 
            // cbbBy
            // 
            this.cbbBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBy.FormattingEnabled = true;
            this.cbbBy.Items.AddRange(new object[] {
            "Xpath",
            "ID",
            "Class"});
            this.cbbBy.Location = new System.Drawing.Point(60, 2);
            this.cbbBy.Name = "cbbBy";
            this.cbbBy.Size = new System.Drawing.Size(146, 24);
            this.cbbBy.TabIndex = 6;
            // 
            // UCClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbbBy);
            this.Controls.Add(this.txtElement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCClick";
            this.Size = new System.Drawing.Size(215, 65);
            this.Load += new System.EventHandler(this.UCClick_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtElement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbBy;
    }
}
