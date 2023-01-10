namespace CarritoDeCompras
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
            this.listShoppingCart = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listShoppingCart
            // 
            this.listShoppingCart.FormattingEnabled = true;
            this.listShoppingCart.ItemHeight = 15;
            this.listShoppingCart.Location = new System.Drawing.Point(12, 12);
            this.listShoppingCart.Name = "listShoppingCart";
            this.listShoppingCart.Size = new System.Drawing.Size(241, 259);
            this.listShoppingCart.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(299, 67);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(404, 67);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(104, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calcular Precio";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código de Descuento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(429, 101);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 23);
            this.txtDiscount.TabIndex = 4;
            // 
            // cboProducts
            // 
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(299, 28);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(230, 23);
            this.cboProducts.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 287);
            this.Controls.Add(this.cboProducts);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listShoppingCart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listShoppingCart;
        private Button btnAdd;
        private Button btnCalc;
        private Label label1;
        private TextBox txtDiscount;
        private ComboBox cboProducts;
    }
}