namespace Programacion
{
    partial class Menu
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
            this.btnGestionClientes = new System.Windows.Forms.Button();
            this.btnAdult = new System.Windows.Forms.Button();
            this.btnNumber = new System.Windows.Forms.Button();
            this.btnCalcImc = new System.Windows.Forms.Button();
            this.lblAlgorithms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGestionClientes
            // 
            this.btnGestionClientes.Location = new System.Drawing.Point(159, 33);
            this.btnGestionClientes.Name = "btnGestionClientes";
            this.btnGestionClientes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnGestionClientes.Size = new System.Drawing.Size(124, 48);
            this.btnGestionClientes.TabIndex = 0;
            this.btnGestionClientes.Text = "Gestionar Clientes";
            this.btnGestionClientes.UseVisualStyleBackColor = true;
            this.btnGestionClientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdult
            // 
            this.btnAdult.Location = new System.Drawing.Point(159, 97);
            this.btnAdult.Name = "btnAdult";
            this.btnAdult.Size = new System.Drawing.Size(124, 48);
            this.btnAdult.TabIndex = 1;
            this.btnAdult.Text = "Adulto o Menor";
            this.btnAdult.UseVisualStyleBackColor = true;
            this.btnAdult.Click += new System.EventHandler(this.btnAdult_Click);
            // 
            // btnNumber
            // 
            this.btnNumber.Location = new System.Drawing.Point(12, 33);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(124, 48);
            this.btnNumber.TabIndex = 2;
            this.btnNumber.Text = "Lista Numero";
            this.btnNumber.UseVisualStyleBackColor = true;
            this.btnNumber.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnCalcImc
            // 
            this.btnCalcImc.Location = new System.Drawing.Point(12, 97);
            this.btnCalcImc.Name = "btnCalcImc";
            this.btnCalcImc.Size = new System.Drawing.Size(124, 48);
            this.btnCalcImc.TabIndex = 3;
            this.btnCalcImc.Text = "IMC CALCULATOR";
            this.btnCalcImc.UseVisualStyleBackColor = true;
            this.btnCalcImc.Click += new System.EventHandler(this.btnCalcImc_Click);
            // 
            // lblAlgorithms
            // 
            this.lblAlgorithms.AutoSize = true;
            this.lblAlgorithms.Location = new System.Drawing.Point(4, 9);
            this.lblAlgorithms.Name = "lblAlgorithms";
            this.lblAlgorithms.Size = new System.Drawing.Size(293, 15);
            this.lblAlgorithms.TabIndex = 4;
            this.lblAlgorithms.Text = "Menú para navegar por diferentes programas sencillos";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 159);
            this.Controls.Add(this.lblAlgorithms);
            this.Controls.Add(this.btnCalcImc);
            this.Controls.Add(this.btnNumber);
            this.Controls.Add(this.btnAdult);
            this.Controls.Add(this.btnGestionClientes);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGestionClientes;
        private Button btnAdult;
        private Button btnNumber;
        private Button btnCalcImc;
        private Label lblAlgorithms;
    }
}