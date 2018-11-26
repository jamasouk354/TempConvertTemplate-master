namespace TempConvertTemplate
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
            this.tempLabel = new System.Windows.Forms.Label();
            this.tempInput = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.celToFahButton = new System.Windows.Forms.RadioButton();
            this.fahToCelButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.Location = new System.Drawing.Point(19, 149);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(151, 21);
            this.tempLabel.TabIndex = 6;
            this.tempLabel.Text = "Enter a Temperature";
            // 
            // tempInput
            // 
            this.tempInput.Location = new System.Drawing.Point(176, 150);
            this.tempInput.Name = "tempInput";
            this.tempInput.Size = new System.Drawing.Size(38, 20);
            this.tempInput.TabIndex = 7;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(150, 176);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(63, 23);
            this.convertButton.TabIndex = 8;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Red;
            this.outputLabel.Location = new System.Drawing.Point(13, 215);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(201, 58);
            this.outputLabel.TabIndex = 9;
            this.outputLabel.Text = "Enter a Temperature";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.celToFahButton);
            this.groupBox1.Controls.Add(this.fahToCelButton);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 105);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion Method";
            // 
            // celToFahButton
            // 
            this.celToFahButton.AutoSize = true;
            this.celToFahButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celToFahButton.Location = new System.Drawing.Point(24, 69);
            this.celToFahButton.Name = "celToFahButton";
            this.celToFahButton.Size = new System.Drawing.Size(146, 21);
            this.celToFahButton.TabIndex = 1;
            this.celToFahButton.TabStop = true;
            this.celToFahButton.Text = "Celsius to Fahrenheit";
            this.celToFahButton.UseVisualStyleBackColor = true;
            // 
            // fahToCelButton
            // 
            this.fahToCelButton.AutoSize = true;
            this.fahToCelButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahToCelButton.Location = new System.Drawing.Point(24, 42);
            this.fahToCelButton.Name = "fahToCelButton";
            this.fahToCelButton.Size = new System.Drawing.Size(146, 21);
            this.fahToCelButton.TabIndex = 0;
            this.fahToCelButton.TabStop = true;
            this.fahToCelButton.Text = "Fahrenheit to Celsius";
            this.fahToCelButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(237, 345);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.tempInput);
            this.Controls.Add(this.tempLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Conversion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.TextBox tempInput;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton celToFahButton;
        private System.Windows.Forms.RadioButton fahToCelButton;
    }
}