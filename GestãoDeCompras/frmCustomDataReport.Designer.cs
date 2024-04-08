namespace OrderControl
{
    partial class frmCustomDataReport
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
            this.chkDatePurchase = new System.Windows.Forms.CheckBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblTo2 = new System.Windows.Forms.Label();
            this.chkExpiration = new System.Windows.Forms.CheckBox();
            this.dtpExpirationF = new System.Windows.Forms.DateTimePicker();
            this.dtpExpirationI = new System.Windows.Forms.DateTimePicker();
            this.lblTo1 = new System.Windows.Forms.Label();
            this.chkPurchase = new System.Windows.Forms.CheckBox();
            this.dtpPurchaseF = new System.Windows.Forms.DateTimePicker();
            this.dtpPurchaseI = new System.Windows.Forms.DateTimePicker();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.chkDatePurchase);
            this.pnlMain.Controls.Add(this.btnFilter);
            this.pnlMain.Controls.Add(this.lblTo2);
            this.pnlMain.Controls.Add(this.chkExpiration);
            this.pnlMain.Controls.Add(this.dtpExpirationF);
            this.pnlMain.Controls.Add(this.dtpExpirationI);
            this.pnlMain.Controls.Add(this.lblTo1);
            this.pnlMain.Controls.Add(this.chkPurchase);
            this.pnlMain.Controls.Add(this.dtpPurchaseF);
            this.pnlMain.Controls.Add(this.dtpPurchaseI);
            this.pnlMain.Controls.Add(this.lblExpirationDate);
            this.pnlMain.Controls.Add(this.lblPurchaseDate);
            this.pnlMain.Location = new System.Drawing.Point(1, -2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(497, 100);
            this.pnlMain.TabIndex = 0;
            // 
            // chkDatePurchase
            // 
            this.chkDatePurchase.AutoSize = true;
            this.chkDatePurchase.Location = new System.Drawing.Point(15, 70);
            this.chkDatePurchase.Name = "chkDatePurchase";
            this.chkDatePurchase.Size = new System.Drawing.Size(174, 17);
            this.chkDatePurchase.TabIndex = 6;
            this.chkDatePurchase.Text = "Show column \"Purchase Date\"";
            this.chkDatePurchase.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(207, 66);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(278, 23);
            this.btnFilter.TabIndex = 7;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblTo2
            // 
            this.lblTo2.AutoSize = true;
            this.lblTo2.Location = new System.Drawing.Point(285, 42);
            this.lblTo2.Name = "lblTo2";
            this.lblTo2.Size = new System.Drawing.Size(16, 13);
            this.lblTo2.TabIndex = 12;
            this.lblTo2.Text = "to";
            // 
            // chkExpiration
            // 
            this.chkExpiration.AutoSize = true;
            this.chkExpiration.Location = new System.Drawing.Point(422, 43);
            this.chkExpiration.Name = "chkExpiration";
            this.chkExpiration.Size = new System.Drawing.Size(68, 17);
            this.chkExpiration.TabIndex = 5;
            this.chkExpiration.Text = "All Dates";
            this.chkExpiration.UseVisualStyleBackColor = true;
            this.chkExpiration.CheckedChanged += new System.EventHandler(this.chkVencimento_CheckedChanged);
            // 
            // dtpExpirationF
            // 
            this.dtpExpirationF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpirationF.Location = new System.Drawing.Point(304, 40);
            this.dtpExpirationF.Name = "dtpExpirationF";
            this.dtpExpirationF.Size = new System.Drawing.Size(112, 20);
            this.dtpExpirationF.TabIndex = 4;
            // 
            // dtpExpirationI
            // 
            this.dtpExpirationI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpirationI.Location = new System.Drawing.Point(167, 40);
            this.dtpExpirationI.Name = "dtpExpirationI";
            this.dtpExpirationI.Size = new System.Drawing.Size(112, 20);
            this.dtpExpirationI.TabIndex = 3;
            // 
            // lblTo1
            // 
            this.lblTo1.AutoSize = true;
            this.lblTo1.Location = new System.Drawing.Point(285, 16);
            this.lblTo1.Name = "lblTo1";
            this.lblTo1.Size = new System.Drawing.Size(16, 13);
            this.lblTo1.TabIndex = 8;
            this.lblTo1.Text = "to";
            // 
            // chkPurchase
            // 
            this.chkPurchase.AutoSize = true;
            this.chkPurchase.Location = new System.Drawing.Point(422, 17);
            this.chkPurchase.Name = "chkPurchase";
            this.chkPurchase.Size = new System.Drawing.Size(68, 17);
            this.chkPurchase.TabIndex = 2;
            this.chkPurchase.Text = "All Dates";
            this.chkPurchase.UseVisualStyleBackColor = true;
            this.chkPurchase.CheckedChanged += new System.EventHandler(this.chkCompra_CheckedChanged);
            // 
            // dtpPurchaseF
            // 
            this.dtpPurchaseF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchaseF.Location = new System.Drawing.Point(304, 14);
            this.dtpPurchaseF.Name = "dtpPurchaseF";
            this.dtpPurchaseF.Size = new System.Drawing.Size(112, 20);
            this.dtpPurchaseF.TabIndex = 1;
            // 
            // dtpPurchaseI
            // 
            this.dtpPurchaseI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchaseI.Location = new System.Drawing.Point(167, 14);
            this.dtpPurchaseI.Name = "dtpPurchaseI";
            this.dtpPurchaseI.Size = new System.Drawing.Size(112, 20);
            this.dtpPurchaseI.TabIndex = 0;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.Location = new System.Drawing.Point(11, 39);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(118, 21);
            this.lblExpirationDate.TabIndex = 4;
            this.lblExpirationDate.Text = "Expiration Date:";
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseDate.Location = new System.Drawing.Point(11, 13);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(112, 21);
            this.lblPurchaseDate.TabIndex = 3;
            this.lblPurchaseDate.Text = "Purchase Date:";
            // 
            // frmCustomDataReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 99);
            this.Controls.Add(this.pnlMain);
            this.Location = new System.Drawing.Point(514, 138);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(514, 138);
            this.Name = "frmCustomDataReport";
            this.Text = "Custom Date Report";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTo2;
        private System.Windows.Forms.CheckBox chkExpiration;
        private System.Windows.Forms.DateTimePicker dtpExpirationF;
        private System.Windows.Forms.DateTimePicker dtpExpirationI;
        private System.Windows.Forms.Label lblTo1;
        private System.Windows.Forms.CheckBox chkPurchase;
        private System.Windows.Forms.DateTimePicker dtpPurchaseF;
        private System.Windows.Forms.DateTimePicker dtpPurchaseI;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.CheckBox chkDatePurchase;
    }
}