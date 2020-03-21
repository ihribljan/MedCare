namespace MedCare
{
    partial class FrmIspisiNarudzbenicu
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIspisiNarudzbenicu));
            this.zaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDataSet = new MedCare.dsDataSet();
            this.proizvodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poslovniPartneriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudžbeniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudžbenicaStavkeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.narudžbenicaStavkeTableAdapter = new MedCare.dsDataSetTableAdapters.NarudžbenicaStavkeTableAdapter();
            this.narudžbeniceTableAdapter = new MedCare.dsDataSetTableAdapters.NarudžbeniceTableAdapter();
            this.poslovniPartneriTableAdapter = new MedCare.dsDataSetTableAdapters.PoslovniPartneriTableAdapter();
            this.proizvodiTableAdapter = new MedCare.dsDataSetTableAdapters.ProizvodiTableAdapter();
            this.zaposleniciTableAdapter = new MedCare.dsDataSetTableAdapters.ZaposleniciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartneriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudžbeniceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudžbenicaStavkeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // zaposleniciBindingSource
            // 
            this.zaposleniciBindingSource.DataMember = "Zaposlenici";
            this.zaposleniciBindingSource.DataSource = this.dsDataSet;
            // 
            // dsDataSet
            // 
            this.dsDataSet.DataSetName = "dsDataSet";
            this.dsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proizvodiBindingSource
            // 
            this.proizvodiBindingSource.DataMember = "Proizvodi";
            this.proizvodiBindingSource.DataSource = this.dsDataSet;
            // 
            // poslovniPartneriBindingSource
            // 
            this.poslovniPartneriBindingSource.DataMember = "PoslovniPartneri";
            this.poslovniPartneriBindingSource.DataSource = this.dsDataSet;
            // 
            // narudžbeniceBindingSource
            // 
            this.narudžbeniceBindingSource.DataMember = "Narudžbenice";
            this.narudžbeniceBindingSource.DataSource = this.dsDataSet;
            // 
            // narudžbenicaStavkeBindingSource
            // 
            this.narudžbenicaStavkeBindingSource.DataMember = "NarudžbenicaStavke";
            this.narudžbenicaStavkeBindingSource.DataSource = this.dsDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsZaposlenici";
            reportDataSource1.Value = this.zaposleniciBindingSource;
            reportDataSource2.Name = "dsProizvodi";
            reportDataSource2.Value = this.proizvodiBindingSource;
            reportDataSource3.Name = "dsPoslovniPartneri";
            reportDataSource3.Value = this.poslovniPartneriBindingSource;
            reportDataSource4.Name = "dsNarudzbenice";
            reportDataSource4.Value = this.narudžbeniceBindingSource;
            reportDataSource5.Name = "dsNarudzbeniceStavke";
            reportDataSource5.Value = this.narudžbenicaStavkeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MedCare.NarudzbenicaReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(814, 749);
            this.reportViewer1.TabIndex = 0;
            // 
            // narudžbenicaStavkeTableAdapter
            // 
            this.narudžbenicaStavkeTableAdapter.ClearBeforeFill = true;
            // 
            // narudžbeniceTableAdapter
            // 
            this.narudžbeniceTableAdapter.ClearBeforeFill = true;
            // 
            // poslovniPartneriTableAdapter
            // 
            this.poslovniPartneriTableAdapter.ClearBeforeFill = true;
            // 
            // proizvodiTableAdapter
            // 
            this.proizvodiTableAdapter.ClearBeforeFill = true;
            // 
            // zaposleniciTableAdapter
            // 
            this.zaposleniciTableAdapter.ClearBeforeFill = true;
            // 
            // FrmIspisiNarudzbenicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 749);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIspisiNarudzbenicu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Narudzbenica";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovniPartneriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudžbeniceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudžbenicaStavkeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsDataSet dsDataSet;
        private System.Windows.Forms.BindingSource narudžbenicaStavkeBindingSource;
        private dsDataSetTableAdapters.NarudžbenicaStavkeTableAdapter narudžbenicaStavkeTableAdapter;
        private System.Windows.Forms.BindingSource narudžbeniceBindingSource;
        private dsDataSetTableAdapters.NarudžbeniceTableAdapter narudžbeniceTableAdapter;
        private System.Windows.Forms.BindingSource poslovniPartneriBindingSource;
        private dsDataSetTableAdapters.PoslovniPartneriTableAdapter poslovniPartneriTableAdapter;
        private System.Windows.Forms.BindingSource proizvodiBindingSource;
        private dsDataSetTableAdapters.ProizvodiTableAdapter proizvodiTableAdapter;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource;
        private dsDataSetTableAdapters.ZaposleniciTableAdapter zaposleniciTableAdapter;
    }
}