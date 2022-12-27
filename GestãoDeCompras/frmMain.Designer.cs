namespace OrderControl
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewLot = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAllLots = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExpiresOneDayReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExpiresFiveDaysReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuRegistration,
            this.mnuReports});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(907, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip2";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout,
            this.mnuBack});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(180, 22);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(180, 22);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // mnuRegistration
            // 
            this.mnuRegistration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewLot});
            this.mnuRegistration.Name = "mnuRegistration";
            this.mnuRegistration.Size = new System.Drawing.Size(82, 20);
            this.mnuRegistration.Text = "Registration";
            // 
            // mnuNewLot
            // 
            this.mnuNewLot.Name = "mnuNewLot";
            this.mnuNewLot.Size = new System.Drawing.Size(180, 22);
            this.mnuNewLot.Text = "New Lot";
            this.mnuNewLot.Click += new System.EventHandler(this.novoLoteToolStripMenuItem_Click);
            // 
            // mnuReports
            // 
            this.mnuReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAllLots,
            this.mnuExpiresOneDayReport,
            this.mnuExpiresFiveDaysReport,
            this.mnuCustomReport});
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(59, 20);
            this.mnuReports.Text = "Reports";
            // 
            // mnuAllLots
            // 
            this.mnuAllLots.Name = "mnuAllLots";
            this.mnuAllLots.Size = new System.Drawing.Size(196, 22);
            this.mnuAllLots.Text = "All lots";
            this.mnuAllLots.Click += new System.EventHandler(this.todosOsLotesToolStripMenuItem_Click);
            // 
            // mnuExpiresOneDayReport
            // 
            this.mnuExpiresOneDayReport.Name = "mnuExpiresOneDayReport";
            this.mnuExpiresOneDayReport.Size = new System.Drawing.Size(196, 22);
            this.mnuExpiresOneDayReport.Text = "To expire in up to 1 day";
            this.mnuExpiresOneDayReport.Click += new System.EventHandler(this.aVencerEmAtéToolStripMenuItem_Click);
            // 
            // mnuExpiresFiveDaysReport
            // 
            this.mnuExpiresFiveDaysReport.Name = "mnuExpiresFiveDaysReport";
            this.mnuExpiresFiveDaysReport.Size = new System.Drawing.Size(201, 22);
            this.mnuExpiresFiveDaysReport.Text = "To expire in up to 5 days";
            this.mnuExpiresFiveDaysReport.Click += new System.EventHandler(this.aVencerEmAté5DiaToolStripMenuItem_Click);
            // 
            // mnuCustomReport
            // 
            this.mnuCustomReport.Name = "mnuCustomReport";
            this.mnuCustomReport.Size = new System.Drawing.Size(196, 22);
            this.mnuCustomReport.Text = "Custom date";
            this.mnuCustomReport.Click += new System.EventHandler(this.vencimentoPersonalizadoToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 512);
            this.Controls.Add(this.mnuMain);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Order Control";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuRegistration;
        private System.Windows.Forms.ToolStripMenuItem mnuNewLot;
        private System.Windows.Forms.ToolStripMenuItem mnuReports;
        private System.Windows.Forms.ToolStripMenuItem mnuAllLots;
        private System.Windows.Forms.ToolStripMenuItem mnuExpiresOneDayReport;
        private System.Windows.Forms.ToolStripMenuItem mnuExpiresFiveDaysReport;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomReport;
    }
}

