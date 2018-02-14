namespace ObserverPatternV2
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
            this.cmbBox_color = new System.Windows.Forms.ComboBox();
            this.lbl_color = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbBox_color
            // 
            this.cmbBox_color.FormattingEnabled = true;
            this.cmbBox_color.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Blue",
            "Green"});
            this.cmbBox_color.Location = new System.Drawing.Point(74, 9);
            this.cmbBox_color.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBox_color.Name = "cmbBox_color";
            this.cmbBox_color.Size = new System.Drawing.Size(180, 28);
            this.cmbBox_color.TabIndex = 3;
            this.cmbBox_color.SelectedIndexChanged += new System.EventHandler(this.cmbBox_color_SelectedIndexChanged);
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(18, 14);
            this.lbl_color.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(46, 20);
            this.lbl_color.TabIndex = 5;
            this.lbl_color.Text = "Color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 229);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.cmbBox_color);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbBox_color;
        private System.Windows.Forms.Label lbl_color;
    }
}

