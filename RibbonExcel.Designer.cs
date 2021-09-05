namespace justforyou_Excel
{
    partial class RibbonJustforyou : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonJustforyou()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">"true", wenn verwaltete Ressourcen gelöscht werden sollen, andernfalls "false".</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabJustforyou = this.Factory.CreateRibbonTab();
            this.GrpJustforyou = this.Factory.CreateRibbonGroup();
            this.btnNeueRechnung = this.Factory.CreateRibbonButton();
            this.btnRechnungBlank = this.Factory.CreateRibbonButton();
            this.btnStornoRechnung = this.Factory.CreateRibbonButton();
            this.btnSpeichern = this.Factory.CreateRibbonButton();
            this.btnDrucken = this.Factory.CreateRibbonButton();
            this.btnEinstellungen = this.Factory.CreateRibbonButton();
            this.TabJustforyou.SuspendLayout();
            this.GrpJustforyou.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabJustforyou
            // 
            this.TabJustforyou.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.TabJustforyou.Groups.Add(this.GrpJustforyou);
            this.TabJustforyou.Label = "justforyou";
            this.TabJustforyou.Name = "TabJustforyou";
            // 
            // GrpJustforyou
            // 
            this.GrpJustforyou.Items.Add(this.btnNeueRechnung);
            this.GrpJustforyou.Items.Add(this.btnRechnungBlank);
            this.GrpJustforyou.Items.Add(this.btnStornoRechnung);
            this.GrpJustforyou.Items.Add(this.btnSpeichern);
            this.GrpJustforyou.Items.Add(this.btnDrucken);
            this.GrpJustforyou.Items.Add(this.btnEinstellungen);
            this.GrpJustforyou.Label = "justforyou";
            this.GrpJustforyou.Name = "GrpJustforyou";
            // 
            // btnNeueRechnung
            // 
            this.btnNeueRechnung.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnNeueRechnung.Label = "Neue Rechnung...";
            this.btnNeueRechnung.Name = "btnNeueRechnung";
            this.btnNeueRechnung.OfficeImageId = "NewOfficeDocument";
            this.btnNeueRechnung.ShowImage = true;
            this.btnNeueRechnung.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnNeueRechnung_Click);
            // 
            // btnRechnungBlank
            // 
            this.btnRechnungBlank.Label = "Blanko-Rechnung";
            this.btnRechnungBlank.Name = "btnRechnungBlank";
            this.btnRechnungBlank.OfficeImageId = "NewOfficeDocument";
            this.btnRechnungBlank.ShowImage = true;
            this.btnRechnungBlank.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnRechnungBlank_Click);
            // 
            // btnStornoRechnung
            // 
            this.btnStornoRechnung.Label = "Neue Stornorechnung";
            this.btnStornoRechnung.Name = "btnStornoRechnung";
            this.btnStornoRechnung.OfficeImageId = "MasterDocumentUnlinkSubdocument";
            this.btnStornoRechnung.ShowImage = true;
            this.btnStornoRechnung.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnStornoRechnung_Click);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Label = "Aktuelles Dokument speichern...";
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.OfficeImageId = "FileSaveAs";
            this.btnSpeichern.ShowImage = true;
            this.btnSpeichern.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSpeichern_Click);
            // 
            // btnDrucken
            // 
            this.btnDrucken.Label = "Aktuelles Dokument drucken";
            this.btnDrucken.Name = "btnDrucken";
            this.btnDrucken.OfficeImageId = "FilePrintQuick";
            this.btnDrucken.ShowImage = true;
            this.btnDrucken.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnDrucken_Click);
            // 
            // btnEinstellungen
            // 
            this.btnEinstellungen.Label = "Einstellungen";
            this.btnEinstellungen.Name = "btnEinstellungen";
            this.btnEinstellungen.OfficeImageId = "MailMergeUpdateLabels";
            this.btnEinstellungen.ShowImage = true;
            this.btnEinstellungen.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnEinstellungen_Click);
            // 
            // RibbonJustforyou
            // 
            this.Name = "RibbonJustforyou";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.TabJustforyou);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibbonJustforyou_Load);
            this.TabJustforyou.ResumeLayout(false);
            this.TabJustforyou.PerformLayout();
            this.GrpJustforyou.ResumeLayout(false);
            this.GrpJustforyou.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab TabJustforyou;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GrpJustforyou;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnNeueRechnung;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnEinstellungen;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnRechnungBlank;
        private Microsoft.Office.Tools.Ribbon.RibbonButton btnSpeichern;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnDrucken;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnStornoRechnung;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonJustforyou Ribbon1
        {
            get { return this.GetRibbon<RibbonJustforyou>(); }
        }
    }
}
