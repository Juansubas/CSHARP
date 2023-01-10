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
            this.SuspendLayout();
            // 
            // btnGestionClientes
            // 
            this.btnGestionClientes.Location = new System.Drawing.Point(422, 33);
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
            this.btnAdult.Location = new System.Drawing.Point(422, 96);
            this.btnAdult.Name = "btnAdult";
            this.btnAdult.Size = new System.Drawing.Size(124, 55);
            this.btnAdult.TabIndex = 1;
            this.btnAdult.Text = "Adulto o Menor";
            this.btnAdult.UseVisualStyleBackColor = true;
            this.btnAdult.Click += new System.EventHandler(this.btnAdult_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 245);
            this.Controls.Add(this.btnAdult);
            this.Controls.Add(this.btnGestionClientes);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnGestionClientes;
        private Button btnAdult;
    }
}