namespace AverageNumber
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.txtThirdNumber = new System.Windows.Forms.TextBox();
            this.labelTwo = new System.Windows.Forms.Label();
            this.labelThree = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 113);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(216, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calcular Promedio";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 34);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(89, 15);
            this.label.TabIndex = 1;
            this.label.Text = "Primer Numero";
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Location = new System.Drawing.Point(128, 26);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(100, 23);
            this.txtFirstNumber.TabIndex = 2;
            this.txtFirstNumber.TextChanged += new System.EventHandler(this.lblFirstNumber_TextChanged);
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Location = new System.Drawing.Point(128, 55);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(100, 23);
            this.txtSecondNumber.TabIndex = 3;
            this.txtSecondNumber.TextChanged += new System.EventHandler(this.txtSecondNumber_TextChanged);
            // 
            // txtThirdNumber
            // 
            this.txtThirdNumber.Location = new System.Drawing.Point(128, 84);
            this.txtThirdNumber.Name = "txtThirdNumber";
            this.txtThirdNumber.Size = new System.Drawing.Size(100, 23);
            this.txtThirdNumber.TabIndex = 4;
            // 
            // labelTwo
            // 
            this.labelTwo.AutoSize = true;
            this.labelTwo.Location = new System.Drawing.Point(12, 63);
            this.labelTwo.Name = "labelTwo";
            this.labelTwo.Size = new System.Drawing.Size(101, 15);
            this.labelTwo.TabIndex = 5;
            this.labelTwo.Text = "Segundo Numero";
            // 
            // labelThree
            // 
            this.labelThree.AutoSize = true;
            this.labelThree.Location = new System.Drawing.Point(12, 92);
            this.labelThree.Name = "labelThree";
            this.labelThree.Size = new System.Drawing.Size(85, 15);
            this.labelThree.TabIndex = 6;
            this.labelThree.Text = "Tercer Numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Calculadora de Promedio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 150);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelThree);
            this.Controls.Add(this.labelTwo);
            this.Controls.Add(this.txtThirdNumber);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.txtFirstNumber);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalc;
        private Label label;
        private TextBox txtFirstNumber;
        private TextBox txtSecondNumber;
        private TextBox txtThirdNumber;
        private Label labelTwo;
        private Label labelThree;
        private Label label1;
    }
}