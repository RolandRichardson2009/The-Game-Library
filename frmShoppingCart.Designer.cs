
namespace TheGameLibrary_RDR_2353FA21
{
    partial class frmShoppingCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShoppingCart));
            this.btnContinueShopping = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.dgvShoppingCart = new System.Windows.Forms.DataGridView();
            this.lblSubtotalDescription = new System.Windows.Forms.Label();
            this.lblTaxAmountDescription = new System.Windows.Forms.Label();
            this.lblNetTotalDescription = new System.Windows.Forms.Label();
            this.lblSubtotalValue = new System.Windows.Forms.Label();
            this.lblTaxAmountValue = new System.Windows.Forms.Label();
            this.lblNetTotalValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoppingCart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContinueShopping
            // 
            this.btnContinueShopping.Location = new System.Drawing.Point(12, 769);
            this.btnContinueShopping.Name = "btnContinueShopping";
            this.btnContinueShopping.Size = new System.Drawing.Size(188, 41);
            this.btnContinueShopping.TabIndex = 0;
            this.btnContinueShopping.Text = "Continue Shopping";
            this.btnContinueShopping.UseVisualStyleBackColor = true;
            this.btnContinueShopping.Click += new System.EventHandler(this.btnContinueShopping_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.Location = new System.Drawing.Point(206, 769);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(188, 41);
            this.btnClearCart.TabIndex = 1;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(400, 769);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(188, 41);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(594, 769);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(188, 41);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // dgvShoppingCart
            // 
            this.dgvShoppingCart.AllowUserToAddRows = false;
            this.dgvShoppingCart.AllowUserToDeleteRows = false;
            this.dgvShoppingCart.AllowUserToOrderColumns = true;
            this.dgvShoppingCart.AllowUserToResizeColumns = false;
            this.dgvShoppingCart.AllowUserToResizeRows = false;
            this.dgvShoppingCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvShoppingCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShoppingCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShoppingCart.Location = new System.Drawing.Point(12, 12);
            this.dgvShoppingCart.Name = "dgvShoppingCart";
            this.dgvShoppingCart.ReadOnly = true;
            this.dgvShoppingCart.Size = new System.Drawing.Size(770, 618);
            this.dgvShoppingCart.TabIndex = 4;
            // 
            // lblSubtotalDescription
            // 
            this.lblSubtotalDescription.AutoSize = true;
            this.lblSubtotalDescription.Location = new System.Drawing.Point(113, 640);
            this.lblSubtotalDescription.Name = "lblSubtotalDescription";
            this.lblSubtotalDescription.Size = new System.Drawing.Size(82, 24);
            this.lblSubtotalDescription.TabIndex = 5;
            this.lblSubtotalDescription.Text = "Subtotal:";
            // 
            // lblTaxAmountDescription
            // 
            this.lblTaxAmountDescription.AutoSize = true;
            this.lblTaxAmountDescription.Location = new System.Drawing.Point(15, 682);
            this.lblTaxAmountDescription.Name = "lblTaxAmountDescription";
            this.lblTaxAmountDescription.Size = new System.Drawing.Size(180, 24);
            this.lblTaxAmountDescription.TabIndex = 6;
            this.lblTaxAmountDescription.Text = "Tax Amount(8.25%):";
            // 
            // lblNetTotalDescription
            // 
            this.lblNetTotalDescription.AutoSize = true;
            this.lblNetTotalDescription.Location = new System.Drawing.Point(105, 725);
            this.lblNetTotalDescription.Name = "lblNetTotalDescription";
            this.lblNetTotalDescription.Size = new System.Drawing.Size(90, 24);
            this.lblNetTotalDescription.TabIndex = 7;
            this.lblNetTotalDescription.Text = "Net Total:";
            // 
            // lblSubtotalValue
            // 
            this.lblSubtotalValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubtotalValue.Location = new System.Drawing.Point(201, 639);
            this.lblSubtotalValue.Name = "lblSubtotalValue";
            this.lblSubtotalValue.Size = new System.Drawing.Size(145, 32);
            this.lblSubtotalValue.TabIndex = 8;
            // 
            // lblTaxAmountValue
            // 
            this.lblTaxAmountValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaxAmountValue.Location = new System.Drawing.Point(201, 681);
            this.lblTaxAmountValue.Name = "lblTaxAmountValue";
            this.lblTaxAmountValue.Size = new System.Drawing.Size(145, 32);
            this.lblTaxAmountValue.TabIndex = 9;
            // 
            // lblNetTotalValue
            // 
            this.lblNetTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetTotalValue.Location = new System.Drawing.Point(201, 724);
            this.lblNetTotalValue.Name = "lblNetTotalValue";
            this.lblNetTotalValue.Size = new System.Drawing.Size(145, 32);
            this.lblNetTotalValue.TabIndex = 10;
            // 
            // frmShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(796, 822);
            this.Controls.Add(this.lblNetTotalValue);
            this.Controls.Add(this.lblTaxAmountValue);
            this.Controls.Add(this.lblSubtotalValue);
            this.Controls.Add(this.lblNetTotalDescription);
            this.Controls.Add(this.lblTaxAmountDescription);
            this.Controls.Add(this.lblSubtotalDescription);
            this.Controls.Add(this.dgvShoppingCart);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.btnContinueShopping);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmShoppingCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Game Library";
            this.Load += new System.EventHandler(this.frmShoppingCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoppingCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinueShopping;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.DataGridView dgvShoppingCart;
        private System.Windows.Forms.Label lblSubtotalDescription;
        private System.Windows.Forms.Label lblTaxAmountDescription;
        private System.Windows.Forms.Label lblNetTotalDescription;
        private System.Windows.Forms.Label lblSubtotalValue;
        private System.Windows.Forms.Label lblTaxAmountValue;
        private System.Windows.Forms.Label lblNetTotalValue;
    }
}