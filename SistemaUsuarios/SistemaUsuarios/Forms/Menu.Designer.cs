namespace SistemaUsuarios
{
    partial class Menu
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
            this.btnGestionarClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionarClientes
            // 
            this.btnGestionarClientes.Location = new System.Drawing.Point(131, 24);
            this.btnGestionarClientes.Name = "btnGestionarClientes";
            this.btnGestionarClientes.Size = new System.Drawing.Size(123, 57);
            this.btnGestionarClientes.TabIndex = 0;
            this.btnGestionarClientes.Text = " Gestionar Clientes";
            this.btnGestionarClientes.UseVisualStyleBackColor = true;
            this.btnGestionarClientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 116);
            this.Controls.Add(this.btnGestionarClientes);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnGestionarClientes;
    }
}