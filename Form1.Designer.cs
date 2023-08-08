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
            RBImperial = new RadioButton();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            RollHeight = new NumericUpDown();
            RollWeight = new NumericUpDown();
            lblBMIvalue = new Label();
            BtnCalculate = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RollHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RollWeight).BeginInit();
            SuspendLayout();
            // 
            // RBMetric
            // 
            RBMetric.AutoSize = true;
            RBMetric.Location = new Point(3, 9);
            RBMetric.Name = "RBMetric";
            RBMetric.Size = new Size(59, 19);
            RBMetric.TabIndex = 0;
            RBMetric.Text = "Metric";
            RBMetric.UseVisualStyleBackColor = true;
            RBMetric.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // RBImperial
            // 
            RBImperial.AutoSize = true;
            RBImperial.Location = new Point(129, 9);
            RBImperial.Name = "RBImperial";
            RBImperial.Size = new Size(68, 19);
            RBImperial.TabIndex = 1;
            RBImperial.Text = "Imperial";
            RBImperial.UseVisualStyleBackColor = true;
            RBImperial.CheckedChanged += RBImperial_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(RBMetric);
            panel1.Controls.Add(RBImperial);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 41);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 136);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 7;
            label1.Text = "Height";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 95);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 8;
            label2.Text = "Weight";
            // 
            // RollHeight
            // 
            RollHeight.DecimalPlaces = 1;
            RollHeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            RollHeight.Location = new Point(12, 93);
            RollHeight.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            RollHeight.Name = "RollHeight";
            RollHeight.Size = new Size(120, 23);
            RollHeight.TabIndex = 9;
            // 
            // RollWeight
            // 
            RollWeight.DecimalPlaces = 1;
            RollWeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            RollWeight.Location = new Point(12, 134);
            RollWeight.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            RollWeight.Name = "RollWeight";
            RollWeight.Size = new Size(120, 23);
            RollWeight.TabIndex = 10;
            // 
            // lblBMIvalue
            // 
            lblBMIvalue.AutoSize = true;
            lblBMIvalue.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblBMIvalue.Location = new Point(42, 291);
            lblBMIvalue.Name = "lblBMIvalue";
            lblBMIvalue.Size = new Size(90, 37);
            lblBMIvalue.TabIndex = 11;
            lblBMIvalue.Text = "label3";
            lblBMIvalue.Click += lblBMIvalue_Click;
            // 
            // BtnCalculate
            // 
            BtnCalculate.Location = new Point(15, 202);
            BtnCalculate.Name = "BtnCalculate";
            BtnCalculate.Size = new Size(75, 23);
            BtnCalculate.TabIndex = 12;
            BtnCalculate.Text = "Calculate";
            BtnCalculate.UseVisualStyleBackColor = true;
            BtnCalculate.Click += BtnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(639, 356);
            Controls.Add(BtnCalculate);
            Controls.Add(lblBMIvalue);
            Controls.Add(RollWeight);
            Controls.Add(RollHeight);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "BMI calculator";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RollHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)RollWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton RBMetric;
        private RadioButton RBImperial;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private NumericUpDown RollHeight;
        private NumericUpDown RollWeight;
        private Label lblBMIvalue;
        private Button BtnCalculate;
    }
}