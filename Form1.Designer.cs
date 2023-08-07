namespace BMIcalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RBMetric = new RadioButton();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // RBMetric
            // 
            RBMetric.AutoSize = true;
            RBMetric.Location = new Point(12, 12);
            RBMetric.Name = "RBMetric";
            RBMetric.Size = new Size(94, 19);
            RBMetric.TabIndex = 0;
            RBMetric.TabStop = true;
            RBMetric.Text = "radioButton1";
            RBMetric.UseVisualStyleBackColor = true;
            RBMetric.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 37);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 511);
            Controls.Add(radioButton2);
            Controls.Add(RBMetric);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton RBMetric;
        private RadioButton radioButton2;
    }
}