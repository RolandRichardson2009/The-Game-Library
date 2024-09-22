
namespace TheGameLibrary_RDR_2353FA21
{
    partial class frmShopNow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShopNow));
            this.btnHome = new System.Windows.Forms.Button();
            this.btnShoppingCart = new System.Windows.Forms.Button();
            this.dgvGamesList = new System.Windows.Forms.DataGridView();
            this.pbxShopNow = new System.Windows.Forms.PictureBox();
            this.cbxQuantity = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGamesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShopNow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(735, 708);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(139, 37);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnShoppingCart
            // 
            this.btnShoppingCart.Location = new System.Drawing.Point(735, 665);
            this.btnShoppingCart.Name = "btnShoppingCart";
            this.btnShoppingCart.Size = new System.Drawing.Size(139, 37);
            this.btnShoppingCart.TabIndex = 1;
            this.btnShoppingCart.Text = "Shopping Cart";
            this.btnShoppingCart.UseVisualStyleBackColor = true;
            this.btnShoppingCart.Click += new System.EventHandler(this.btnShoppingCart_Click);
            // 
            // dgvGamesList
            // 
            this.dgvGamesList.AllowUserToAddRows = false;
            this.dgvGamesList.AllowUserToDeleteRows = false;
            this.dgvGamesList.AllowUserToOrderColumns = true;
            this.dgvGamesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGamesList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGamesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGamesList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGamesList.Location = new System.Drawing.Point(12, 12);
            this.dgvGamesList.Name = "dgvGamesList";
            this.dgvGamesList.ReadOnly = true;
            this.dgvGamesList.Size = new System.Drawing.Size(717, 463);
            this.dgvGamesList.TabIndex = 2;
            this.dgvGamesList.TabStop = false;
            this.dgvGamesList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGamesList_CellClick);
            // 
            // pbxShopNow
            // 
            this.pbxShopNow.Location = new System.Drawing.Point(735, 12);
            this.pbxShopNow.Name = "pbxShopNow";
            this.pbxShopNow.Size = new System.Drawing.Size(413, 609);
            this.pbxShopNow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxShopNow.TabIndex = 3;
            this.pbxShopNow.TabStop = false;
            // 
            // cbxQuantity
            // 
            this.cbxQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuantity.FormatString = "N0";
            this.cbxQuantity.FormattingEnabled = true;
            this.cbxQuantity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxQuantity.Location = new System.Drawing.Point(903, 627);
            this.cbxQuantity.MaxDropDownItems = 3;
            this.cbxQuantity.Name = "cbxQuantity";
            this.cbxQuantity.Size = new System.Drawing.Size(121, 32);
            this.cbxQuantity.TabIndex = 4;
            this.cbxQuantity.Click += new System.EventHandler(this.cbxQuantity_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(814, 630);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(83, 24);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity:";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(12, 481);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(717, 326);
            this.rtbDescription.TabIndex = 6;
            this.rtbDescription.Text = "";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(880, 665);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(139, 37);
            this.btnAddToCart.TabIndex = 7;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // frmShopNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1161, 819);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.cbxQuantity);
            this.Controls.Add(this.pbxShopNow);
            this.Controls.Add(this.dgvGamesList);
            this.Controls.Add(this.btnShoppingCart);
            this.Controls.Add(this.btnHome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmShopNow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Game Library";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmShopNow_FormClosing);
            this.Load += new System.EventHandler(this.frmShopNow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGamesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShopNow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnShoppingCart;
        private System.Windows.Forms.DataGridView dgvGamesList;
        private System.Windows.Forms.PictureBox pbxShopNow;
        private System.Windows.Forms.ComboBox cbxQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAddToCart;
    }
}