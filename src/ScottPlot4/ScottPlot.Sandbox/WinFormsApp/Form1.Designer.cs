﻿namespace WinFormsApp
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
            this.formsPlot1.Size = new System.Drawing.Size(782, 352);
            this.formsPlot1.TabIndex = 0;
            // 
            // cbxLockAxis1
            // 
            this.cbxLockAxis1.AutoSize = true;
            this.cbxLockAxis1.Location = new System.Drawing.Point(61, 370);
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
            this.cbxLockAxis2.Location = new System.Drawing.Point(166, 370);
            this.cbxLockAxis2.Name = "cbxLockAxis2";
            this.cbxLockAxis2.Size = new System.Drawing.Size(85, 19);
            this.cbxLockAxis2.TabIndex = 2;
            this.cbxLockAxis2.Text = "Lock Axis 2";
            this.cbxLockAxis2.UseVisualStyleBackColor = true;
            this.cbxLockAxis2.CheckedChanged += new System.EventHandler(this.cbxLockAxis2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 417);
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
    }
}