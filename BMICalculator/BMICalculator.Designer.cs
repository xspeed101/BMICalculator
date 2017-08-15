namespace BMICalculator
{
    partial class BMICalculator
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
            this.ButtonTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.MyWeightTextBox = new System.Windows.Forms.TextBox();
            this.MyHeightTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.MultilineTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ButtonTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonTableLayout
            // 
            this.ButtonTableLayout.ColumnCount = 2;
            this.ButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.99274F));
            this.ButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.00726F));
            this.ButtonTableLayout.Controls.Add(this.ImperialRadioButton, 0, 0);
            this.ButtonTableLayout.Controls.Add(this.MetricRadioButton, 1, 0);
            this.ButtonTableLayout.Controls.Add(this.MyWeightLabel, 0, 1);
            this.ButtonTableLayout.Controls.Add(this.MyHeightLabel, 1, 1);
            this.ButtonTableLayout.Controls.Add(this.MyWeightTextBox, 0, 2);
            this.ButtonTableLayout.Controls.Add(this.MyHeightTextBox, 1, 2);
            this.ButtonTableLayout.Controls.Add(this.ResultTextBox, 1, 4);
            this.ButtonTableLayout.Controls.Add(this.CalculateBMIButton, 0, 3);
            this.ButtonTableLayout.Controls.Add(this.ResultLabel, 0, 4);
            this.ButtonTableLayout.Controls.Add(this.ResetButton, 1, 3);
            this.ButtonTableLayout.Location = new System.Drawing.Point(12, 28);
            this.ButtonTableLayout.Name = "ButtonTableLayout";
            this.ButtonTableLayout.RowCount = 5;
            this.ButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.ButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.ButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.ButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.ButtonTableLayout.Size = new System.Drawing.Size(420, 285);
            this.ButtonTableLayout.TabIndex = 0;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioButton.Location = new System.Drawing.Point(3, 3);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(57, 17);
            this.ImperialRadioButton.TabIndex = 0;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "lbs/in";
            this.ImperialRadioButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioButton.Location = new System.Drawing.Point(133, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(54, 17);
            this.MetricRadioButton.TabIndex = 1;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "kg/m";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.AutoSize = true;
            this.MyWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWeightLabel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.MyWeightLabel.Location = new System.Drawing.Point(3, 53);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(119, 13);
            this.MyWeightLabel.TabIndex = 2;
            this.MyWeightLabel.Text = "My Weight (lbs/kg):";
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.AutoSize = true;
            this.MyHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyHeightLabel.Location = new System.Drawing.Point(133, 53);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(105, 13);
            this.MyHeightLabel.TabIndex = 4;
            this.MyHeightLabel.Text = "My Height (in/m):";
            // 
            // MyWeightTextBox
            // 
            this.MyWeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWeightTextBox.Location = new System.Drawing.Point(3, 81);
            this.MyWeightTextBox.Name = "MyWeightTextBox";
            this.MyWeightTextBox.Size = new System.Drawing.Size(89, 20);
            this.MyWeightTextBox.TabIndex = 3;
            this.MyWeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyWeightTextBox_KeyPress);
            // 
            // MyHeightTextBox
            // 
            this.MyHeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyHeightTextBox.Location = new System.Drawing.Point(133, 81);
            this.MyHeightTextBox.Name = "MyHeightTextBox";
            this.MyHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.MyHeightTextBox.TabIndex = 5;
            this.MyHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyHeightTextBox_KeyPress);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.Silver;
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.ForeColor = System.Drawing.Color.Black;
            this.ResultTextBox.Location = new System.Drawing.Point(133, 167);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(100, 26);
            this.ResultTextBox.TabIndex = 6;
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 112);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(109, 23);
            this.CalculateBMIButton.TabIndex = 8;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ResultLabel.Location = new System.Drawing.Point(3, 164);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(71, 20);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.Text = "Result: ";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MultilineTextBox
            // 
            this.MultilineTextBox.BackColor = System.Drawing.Color.White;
            this.MultilineTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultilineTextBox.Location = new System.Drawing.Point(19, 319);
            this.MultilineTextBox.Multiline = true;
            this.MultilineTextBox.Name = "MultilineTextBox";
            this.MultilineTextBox.ReadOnly = true;
            this.MultilineTextBox.Size = new System.Drawing.Size(273, 110);
            this.MultilineTextBox.TabIndex = 1;
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(133, 112);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(109, 23);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.MultilineTextBox);
            this.Controls.Add(this.ButtonTableLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.ButtonTableLayout.ResumeLayout(false);
            this.ButtonTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ButtonTableLayout;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.TextBox MyWeightTextBox;
        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.TextBox MyHeightTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TextBox MultilineTextBox;
        private System.Windows.Forms.Button ResetButton;
    }
}

