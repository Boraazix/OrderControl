namespace OrderControl
{
    partial class frmRegistrationLot
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.bgxLot = new System.Windows.Forms.GroupBox();
            this.lstPurchases = new System.Windows.Forms.ListBox();
            this.gbxProduct = new System.Windows.Forms.GroupBox();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.dtpExpiration = new System.Windows.Forms.DateTimePicker();
            this.dtpPurchase = new System.Windows.Forms.DateTimePicker();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
            this.bgxLot.SuspendLayout();
            this.gbxProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.bgxLot);
            this.pnlMain.Controls.Add(this.gbxProduct);
            this.pnlMain.Location = new System.Drawing.Point(1, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(812, 412);
            this.pnlMain.TabIndex = 0;
            // 
            // bgxLot
            // 
            this.bgxLot.Controls.Add(this.lstPurchases);
            this.bgxLot.Location = new System.Drawing.Point(422, 12);
            this.bgxLot.Name = "bgxLot";
            this.bgxLot.Size = new System.Drawing.Size(378, 386);
            this.bgxLot.TabIndex = 2;
            this.bgxLot.TabStop = false;
            this.bgxLot.Text = "Lot";
            // 
            // lstPurchases
            // 
            this.lstPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPurchases.FormattingEnabled = true;
            this.lstPurchases.ItemHeight = 18;
            this.lstPurchases.Location = new System.Drawing.Point(18, 23);
            this.lstPurchases.Name = "lstPurchases";
            this.lstPurchases.Size = new System.Drawing.Size(341, 346);
            this.lstPurchases.TabIndex = 0;
            // 
            // gbxProduct
            // 
            this.gbxProduct.Controls.Add(this.lblExpirationDate);
            this.gbxProduct.Controls.Add(this.lblPurchaseDate);
            this.gbxProduct.Controls.Add(this.dtpExpiration);
            this.gbxProduct.Controls.Add(this.dtpPurchase);
            this.gbxProduct.Controls.Add(this.lblQuantity);
            this.gbxProduct.Controls.Add(this.btnRegister);
            this.gbxProduct.Controls.Add(this.nudQuantity);
            this.gbxProduct.Controls.Add(this.lstProducts);
            this.gbxProduct.Controls.Add(this.lblName);
            this.gbxProduct.Controls.Add(this.lblCode);
            this.gbxProduct.Controls.Add(this.txtName);
            this.gbxProduct.Controls.Add(this.txtCode);
            this.gbxProduct.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxProduct.Location = new System.Drawing.Point(14, 12);
            this.gbxProduct.Name = "gbxProduct";
            this.gbxProduct.Size = new System.Drawing.Size(402, 386);
            this.gbxProduct.TabIndex = 0;
            this.gbxProduct.TabStop = false;
            this.gbxProduct.Text = "Product";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.Location = new System.Drawing.Point(9, 288);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(116, 21);
            this.lblExpirationDate.TabIndex = 20;
            this.lblExpirationDate.Text = "Expiration date:";
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseDate.Location = new System.Drawing.Point(9, 260);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(110, 21);
            this.lblPurchaseDate.TabIndex = 18;
            this.lblPurchaseDate.Text = "Purchase date:";
            // 
            // dtpExpiration
            // 
            this.dtpExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiration.Location = new System.Drawing.Point(196, 288);
            this.dtpExpiration.Name = "dtpExpiration";
            this.dtpExpiration.Size = new System.Drawing.Size(200, 24);
            this.dtpExpiration.TabIndex = 4;
            // 
            // dtpPurchase
            // 
            this.dtpPurchase.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchase.Location = new System.Drawing.Point(196, 263);
            this.dtpPurchase.Name = "dtpPurchase";
            this.dtpPurchase.Size = new System.Drawing.Size(200, 24);
            this.dtpPurchase.TabIndex = 3;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(9, 315);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(73, 21);
            this.lblQuantity.TabIndex = 19;
            this.lblQuantity.Text = "Quantity:";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(13, 341);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(383, 32);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(275, 315);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(121, 24);
            this.nudQuantity.TabIndex = 5;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lstProducts
            // 
            this.lstProducts.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 21;
            this.lstProducts.Location = new System.Drawing.Point(13, 83);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(383, 172);
            this.lstProducts.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(9, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 21);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(9, 23);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(49, 21);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Code:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(226, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 24);
            this.txtName.TabIndex = 1;
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(226, 23);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(170, 24);
            this.txtCode.TabIndex = 0;
            this.txtCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyUp);
            // 
            // frmRegistrationLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 413);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.Name = "frmRegistrationLot";
            this.Text = "Lot Registration";
            this.pnlMain.ResumeLayout(false);
            this.bgxLot.ResumeLayout(false);
            this.gbxProduct.ResumeLayout(false);
            this.gbxProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox gbxProduct;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.GroupBox bgxLot;
        private System.Windows.Forms.ListBox lstPurchases;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.DateTimePicker dtpExpiration;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.DateTimePicker dtpPurchase;
    }
}