namespace AutoSelenium
{
    partial class UCWait
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
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbBy = new System.Windows.Forms.ComboBox();
            this.txtElement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(60, 82);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(142, 23);
            this.txtTime.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Time: ";
            // 
            // cbbBy
            // 
            this.cbbBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBy.FormattingEnabled = true;
            this.cbbBy.Items.AddRange(new object[] {
            "Xpath",
            "ID",
            "Class"});
            this.cbbBy.Location = new System.Drawing.Point(60, 0);
            this.cbbBy.Margin = new System.Windows.Forms.Padding(4);
            this.cbbBy.Name = "cbbBy";
            this.cbbBy.Size = new System.Drawing.Size(142, 24);
            this.cbbBy.TabIndex = 16;
            // 
            // txtElement
            // 
            this.txtElement.Location = new System.Drawing.Point(60, 42);
            this.txtElement.Margin = new System.Windows.Forms.Padding(4);
            this.txtElement.Name = "txtElement";
            this.txtElement.Size = new System.Drawing.Size(142, 23);
            this.txtElement.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Element:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "By:";
            // 
            // UCWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbBy);
            this.Controls.Add(this.txtElement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCWait";
            this.Size = new System.Drawing.Size(215, 110);
            this.Load += new System.EventHandler(this.UCWait_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbBy;
        private System.Windows.Forms.TextBox txtElement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}
