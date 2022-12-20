namespace WinFormsApp
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
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.cbxLockAxis1 = new System.Windows.Forms.CheckBox();
            this.cbxLockAxis2 = new System.Windows.Forms.CheckBox();
            this.cbxAxis1Right = new System.Windows.Forms.CheckBox();
            this.cbxAxis2Right = new System.Windows.Forms.CheckBox();
            this.cbxLockAxis3 = new System.Windows.Forms.CheckBox();
            this.cbxAxis3Right = new System.Windows.Forms.CheckBox();
            this.cbxLockAxis4 = new System.Windows.Forms.CheckBox();
            this.cbxAxis4Right = new System.Windows.Forms.CheckBox();
            this.cbxAxis1Lbl = new System.Windows.Forms.CheckBox();
            this.cbxAxis2Lbl = new System.Windows.Forms.CheckBox();
            this.cbxAxis3Lbl = new System.Windows.Forms.CheckBox();
            this.cbxAxis4Lbl = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formsPlot1.BackColor = System.Drawing.Color.Transparent;
            this.formsPlot1.Location = new System.Drawing.Point(13, 12);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(807, 355);
            this.formsPlot1.TabIndex = 0;
            // 
            // cbxLockAxis1
            // 
            this.cbxLockAxis1.AutoSize = true;
            this.cbxLockAxis1.Location = new System.Drawing.Point(62, 373);
            this.cbxLockAxis1.Name = "cbxLockAxis1";
            this.cbxLockAxis1.Size = new System.Drawing.Size(85, 19);
            this.cbxLockAxis1.TabIndex = 1;
            this.cbxLockAxis1.Text = "Lock Axis 1";
            this.cbxLockAxis1.UseVisualStyleBackColor = true;
            this.cbxLockAxis1.CheckedChanged += new System.EventHandler(this.cbxLockAxis1_CheckedChanged);
            // 
            // cbxLockAxis2
            // 
            this.cbxLockAxis2.AutoSize = true;
            this.cbxLockAxis2.Location = new System.Drawing.Point(167, 373);
            this.cbxLockAxis2.Name = "cbxLockAxis2";
            this.cbxLockAxis2.Size = new System.Drawing.Size(85, 19);
            this.cbxLockAxis2.TabIndex = 2;
            this.cbxLockAxis2.Text = "Lock Axis 2";
            this.cbxLockAxis2.UseVisualStyleBackColor = true;
            this.cbxLockAxis2.CheckedChanged += new System.EventHandler(this.cbxLockAxis2_CheckedChanged);
            // 
            // cbxAxis1Right
            // 
            this.cbxAxis1Right.AutoSize = true;
            this.cbxAxis1Right.Location = new System.Drawing.Point(62, 403);
            this.cbxAxis1Right.Name = "cbxAxis1Right";
            this.cbxAxis1Right.Size = new System.Drawing.Size(54, 19);
            this.cbxAxis1Right.TabIndex = 3;
            this.cbxAxis1Right.Text = "Right";
            this.cbxAxis1Right.UseVisualStyleBackColor = true;
            this.cbxAxis1Right.CheckedChanged += new System.EventHandler(this.cbxAxis1Right_CheckedChanged);
            // 
            // cbxAxis2Right
            // 
            this.cbxAxis2Right.AutoSize = true;
            this.cbxAxis2Right.Location = new System.Drawing.Point(167, 403);
            this.cbxAxis2Right.Name = "cbxAxis2Right";
            this.cbxAxis2Right.Size = new System.Drawing.Size(54, 19);
            this.cbxAxis2Right.TabIndex = 4;
            this.cbxAxis2Right.Text = "Right";
            this.cbxAxis2Right.UseVisualStyleBackColor = true;
            this.cbxAxis2Right.CheckedChanged += new System.EventHandler(this.cbxAxis2Right_CheckedChanged);
            // 
            // cbxLockAxis3
            // 
            this.cbxLockAxis3.AutoSize = true;
            this.cbxLockAxis3.Location = new System.Drawing.Point(276, 373);
            this.cbxLockAxis3.Name = "cbxLockAxis3";
            this.cbxLockAxis3.Size = new System.Drawing.Size(85, 19);
            this.cbxLockAxis3.TabIndex = 5;
            this.cbxLockAxis3.Text = "Lock Axis 3";
            this.cbxLockAxis3.UseVisualStyleBackColor = true;
            this.cbxLockAxis3.CheckedChanged += new System.EventHandler(this.cbxLockAxis3_CheckedChanged);
            // 
            // cbxAxis3Right
            // 
            this.cbxAxis3Right.AutoSize = true;
            this.cbxAxis3Right.Location = new System.Drawing.Point(276, 403);
            this.cbxAxis3Right.Name = "cbxAxis3Right";
            this.cbxAxis3Right.Size = new System.Drawing.Size(54, 19);
            this.cbxAxis3Right.TabIndex = 6;
            this.cbxAxis3Right.Text = "Right";
            this.cbxAxis3Right.UseVisualStyleBackColor = true;
            this.cbxAxis3Right.CheckedChanged += new System.EventHandler(this.cbxAxis3Right_CheckedChanged);
            // 
            // cbxLockAxis4
            // 
            this.cbxLockAxis4.AutoSize = true;
            this.cbxLockAxis4.Location = new System.Drawing.Point(386, 373);
            this.cbxLockAxis4.Name = "cbxLockAxis4";
            this.cbxLockAxis4.Size = new System.Drawing.Size(85, 19);
            this.cbxLockAxis4.TabIndex = 7;
            this.cbxLockAxis4.Text = "Lock Axis 4";
            this.cbxLockAxis4.UseVisualStyleBackColor = true;
            this.cbxLockAxis4.CheckedChanged += new System.EventHandler(this.cbxLockAxis4_CheckedChanged);
            // 
            // cbxAxis4Right
            // 
            this.cbxAxis4Right.AutoSize = true;
            this.cbxAxis4Right.Location = new System.Drawing.Point(386, 403);
            this.cbxAxis4Right.Name = "cbxAxis4Right";
            this.cbxAxis4Right.Size = new System.Drawing.Size(54, 19);
            this.cbxAxis4Right.TabIndex = 8;
            this.cbxAxis4Right.Text = "Right";
            this.cbxAxis4Right.UseVisualStyleBackColor = true;
            this.cbxAxis4Right.CheckedChanged += new System.EventHandler(this.cbxAxis4Right_CheckedChanged);
            // 
            // cbxAxis1Lbl
            // 
            this.cbxAxis1Lbl.AutoSize = true;
            this.cbxAxis1Lbl.Location = new System.Drawing.Point(62, 428);
            this.cbxAxis1Lbl.Name = "cbxAxis1Lbl";
            this.cbxAxis1Lbl.Size = new System.Drawing.Size(54, 19);
            this.cbxAxis1Lbl.TabIndex = 9;
            this.cbxAxis1Lbl.Text = "Label";
            this.cbxAxis1Lbl.UseVisualStyleBackColor = true;
            this.cbxAxis1Lbl.CheckedChanged += new System.EventHandler(this.cbxAxis1Lbl_CheckedChanged);
            // 
            // cbxAxis2Lbl
            // 
            this.cbxAxis2Lbl.AutoSize = true;
            this.cbxAxis2Lbl.Location = new System.Drawing.Point(167, 428);
            this.cbxAxis2Lbl.Name = "cbxAxis2Lbl";
            this.cbxAxis2Lbl.Size = new System.Drawing.Size(54, 19);
            this.cbxAxis2Lbl.TabIndex = 9;
            this.cbxAxis2Lbl.Text = "Label";
            this.cbxAxis2Lbl.UseVisualStyleBackColor = true;
            this.cbxAxis2Lbl.CheckedChanged += new System.EventHandler(this.cbxAxis2Lbl_CheckedChanged);
            // 
            // cbxAxis3Lbl
            // 
            this.cbxAxis3Lbl.AutoSize = true;
            this.cbxAxis3Lbl.Location = new System.Drawing.Point(276, 428);
            this.cbxAxis3Lbl.Name = "cbxAxis3Lbl";
            this.cbxAxis3Lbl.Size = new System.Drawing.Size(54, 19);
            this.cbxAxis3Lbl.TabIndex = 9;
            this.cbxAxis3Lbl.Text = "Label";
            this.cbxAxis3Lbl.UseVisualStyleBackColor = true;
            this.cbxAxis3Lbl.CheckedChanged += new System.EventHandler(this.cbxAxis3Lbl_CheckedChanged);
            // 
            // cbxAxis4Lbl
            // 
            this.cbxAxis4Lbl.AutoSize = true;
            this.cbxAxis4Lbl.Location = new System.Drawing.Point(386, 428);
            this.cbxAxis4Lbl.Name = "cbxAxis4Lbl";
            this.cbxAxis4Lbl.Size = new System.Drawing.Size(54, 19);
            this.cbxAxis4Lbl.TabIndex = 9;
            this.cbxAxis4Lbl.Text = "Label";
            this.cbxAxis4Lbl.UseVisualStyleBackColor = true;
            this.cbxAxis4Lbl.CheckedChanged += new System.EventHandler(this.cbxAxis4Lbl_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 511);
            this.Controls.Add(this.cbxAxis4Lbl);
            this.Controls.Add(this.cbxAxis3Lbl);
            this.Controls.Add(this.cbxAxis2Lbl);
            this.Controls.Add(this.cbxAxis1Lbl);
            this.Controls.Add(this.cbxAxis4Right);
            this.Controls.Add(this.cbxLockAxis4);
            this.Controls.Add(this.cbxAxis3Right);
            this.Controls.Add(this.cbxLockAxis3);
            this.Controls.Add(this.cbxAxis2Right);
            this.Controls.Add(this.cbxAxis1Right);
            this.Controls.Add(this.cbxLockAxis2);
            this.Controls.Add(this.cbxLockAxis1);
            this.Controls.Add(this.formsPlot1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormsPlot Sandbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.CheckBox cbxLockAxis1;
        private System.Windows.Forms.CheckBox cbxLockAxis2;
        private System.Windows.Forms.CheckBox cbxAxis1Right;
        private System.Windows.Forms.CheckBox cbxAxis2Right;
        private System.Windows.Forms.CheckBox cbxLockAxis3;
        private System.Windows.Forms.CheckBox cbxAxis3Right;
        private System.Windows.Forms.CheckBox cbxLockAxis4;
        private System.Windows.Forms.CheckBox cbxAxis4Right;
        private System.Windows.Forms.CheckBox cbxAxis1Lbl;
        private System.Windows.Forms.CheckBox cbxAxis2Lbl;
        private System.Windows.Forms.CheckBox cbxAxis3Lbl;
        private System.Windows.Forms.CheckBox cbxAxis4Lbl;
    }
}