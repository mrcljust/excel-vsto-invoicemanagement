namespace justforyou_Excel
{
    partial class FormEinstellungen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEinstellungen));
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.BtnSpeichern = new System.Windows.Forms.Button();
            this.lblRechnungsnummer = new System.Windows.Forms.Label();
            this.txtRechnungsnummer = new System.Windows.Forms.TextBox();
            this.lblDateipfadVorlage = new System.Windows.Forms.Label();
            this.txtDateipfadVorlage = new System.Windows.Forms.TextBox();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.txtOrdnerRechnungen = new System.Windows.Forms.TextBox();
            this.lblOrdnerRechnungen = new System.Windows.Forms.Label();
            this.btnSelectPathOrdnerRechnungen = new System.Windows.Forms.Button();
            this.lblMwst = new System.Windows.Forms.Label();
            this.numerMwst = new System.Windows.Forms.NumericUpDown();
            this.btnMonatvorlage = new System.Windows.Forms.Button();
            this.txtMonatvorlage = new System.Windows.Forms.TextBox();
            this.lblMonatvorlage = new System.Windows.Forms.Label();
            this.btnMonatOrdner = new System.Windows.Forms.Button();
            this.txtMonatOrdner = new System.Windows.Forms.TextBox();
            this.lblMonatsuebersichtOrdner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numerMwst)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbbrechen.Location = new System.Drawing.Point(361, 179);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.btnAbbrechen.TabIndex = 0;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // BtnSpeichern
            // 
            this.BtnSpeichern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSpeichern.Location = new System.Drawing.Point(280, 179);
            this.BtnSpeichern.Name = "BtnSpeichern";
            this.BtnSpeichern.Size = new System.Drawing.Size(75, 23);
            this.BtnSpeichern.TabIndex = 1;
            this.BtnSpeichern.Text = "Speichern";
            this.BtnSpeichern.UseVisualStyleBackColor = true;
            this.BtnSpeichern.Click += new System.EventHandler(this.BtnSpeichern_Click);
            // 
            // lblRechnungsnummer
            // 
            this.lblRechnungsnummer.AutoSize = true;
            this.lblRechnungsnummer.Location = new System.Drawing.Point(12, 119);
            this.lblRechnungsnummer.Name = "lblRechnungsnummer";
            this.lblRechnungsnummer.Size = new System.Drawing.Size(145, 13);
            this.lblRechnungsnummer.TabIndex = 2;
            this.lblRechnungsnummer.Text = "Nächste Rechnungsnummer:";
            // 
            // txtRechnungsnummer
            // 
            this.txtRechnungsnummer.Location = new System.Drawing.Point(198, 116);
            this.txtRechnungsnummer.Name = "txtRechnungsnummer";
            this.txtRechnungsnummer.Size = new System.Drawing.Size(208, 20);
            this.txtRechnungsnummer.TabIndex = 3;
            // 
            // lblDateipfadVorlage
            // 
            this.lblDateipfadVorlage.AutoSize = true;
            this.lblDateipfadVorlage.Location = new System.Drawing.Point(12, 15);
            this.lblDateipfadVorlage.Name = "lblDateipfadVorlage";
            this.lblDateipfadVorlage.Size = new System.Drawing.Size(100, 13);
            this.lblDateipfadVorlage.TabIndex = 4;
            this.lblDateipfadVorlage.Text = "Rechnungsvorlage:";
            // 
            // txtDateipfadVorlage
            // 
            this.txtDateipfadVorlage.Location = new System.Drawing.Point(198, 12);
            this.txtDateipfadVorlage.Name = "txtDateipfadVorlage";
            this.txtDateipfadVorlage.ReadOnly = true;
            this.txtDateipfadVorlage.Size = new System.Drawing.Size(208, 20);
            this.txtDateipfadVorlage.TabIndex = 5;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(412, 12);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(24, 20);
            this.btnSelectPath.TabIndex = 6;
            this.btnSelectPath.Text = "...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOrdnerRechnungen
            // 
            this.txtOrdnerRechnungen.Location = new System.Drawing.Point(198, 64);
            this.txtOrdnerRechnungen.Name = "txtOrdnerRechnungen";
            this.txtOrdnerRechnungen.ReadOnly = true;
            this.txtOrdnerRechnungen.Size = new System.Drawing.Size(208, 20);
            this.txtOrdnerRechnungen.TabIndex = 8;
            // 
            // lblOrdnerRechnungen
            // 
            this.lblOrdnerRechnungen.AutoSize = true;
            this.lblOrdnerRechnungen.Location = new System.Drawing.Point(12, 67);
            this.lblOrdnerRechnungen.Name = "lblOrdnerRechnungen";
            this.lblOrdnerRechnungen.Size = new System.Drawing.Size(180, 13);
            this.lblOrdnerRechnungen.TabIndex = 7;
            this.lblOrdnerRechnungen.Text = "Standard-Speicherort (\"Ausgestellt\"):";
            // 
            // btnSelectPathOrdnerRechnungen
            // 
            this.btnSelectPathOrdnerRechnungen.Location = new System.Drawing.Point(412, 64);
            this.btnSelectPathOrdnerRechnungen.Name = "btnSelectPathOrdnerRechnungen";
            this.btnSelectPathOrdnerRechnungen.Size = new System.Drawing.Size(24, 20);
            this.btnSelectPathOrdnerRechnungen.TabIndex = 9;
            this.btnSelectPathOrdnerRechnungen.Text = "...";
            this.btnSelectPathOrdnerRechnungen.UseVisualStyleBackColor = true;
            this.btnSelectPathOrdnerRechnungen.Click += new System.EventHandler(this.btnSelectPathOrdnerRechnungen_Click);
            // 
            // lblMwst
            // 
            this.lblMwst.AutoSize = true;
            this.lblMwst.Location = new System.Drawing.Point(12, 144);
            this.lblMwst.Name = "lblMwst";
            this.lblMwst.Size = new System.Drawing.Size(61, 13);
            this.lblMwst.TabIndex = 10;
            this.lblMwst.Text = "MwSt-Satz:";
            // 
            // numerMwst
            // 
            this.numerMwst.Location = new System.Drawing.Point(198, 142);
            this.numerMwst.Name = "numerMwst";
            this.numerMwst.Size = new System.Drawing.Size(208, 20);
            this.numerMwst.TabIndex = 11;
            this.numerMwst.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            // 
            // btnMonatvorlage
            // 
            this.btnMonatvorlage.Location = new System.Drawing.Point(412, 38);
            this.btnMonatvorlage.Name = "btnMonatvorlage";
            this.btnMonatvorlage.Size = new System.Drawing.Size(24, 20);
            this.btnMonatvorlage.TabIndex = 14;
            this.btnMonatvorlage.Text = "...";
            this.btnMonatvorlage.UseVisualStyleBackColor = true;
            this.btnMonatvorlage.Click += new System.EventHandler(this.btnMonatvorlage_Click);
            // 
            // txtMonatvorlage
            // 
            this.txtMonatvorlage.Location = new System.Drawing.Point(198, 38);
            this.txtMonatvorlage.Name = "txtMonatvorlage";
            this.txtMonatvorlage.ReadOnly = true;
            this.txtMonatvorlage.Size = new System.Drawing.Size(208, 20);
            this.txtMonatvorlage.TabIndex = 13;
            // 
            // lblMonatvorlage
            // 
            this.lblMonatvorlage.AutoSize = true;
            this.lblMonatvorlage.Location = new System.Drawing.Point(12, 41);
            this.lblMonatvorlage.Name = "lblMonatvorlage";
            this.lblMonatvorlage.Size = new System.Drawing.Size(123, 13);
            this.lblMonatvorlage.TabIndex = 12;
            this.lblMonatvorlage.Text = "Monatsübersichtvorlage:";
            // 
            // btnMonatOrdner
            // 
            this.btnMonatOrdner.Location = new System.Drawing.Point(412, 90);
            this.btnMonatOrdner.Name = "btnMonatOrdner";
            this.btnMonatOrdner.Size = new System.Drawing.Size(24, 20);
            this.btnMonatOrdner.TabIndex = 17;
            this.btnMonatOrdner.Text = "...";
            this.btnMonatOrdner.UseVisualStyleBackColor = true;
            this.btnMonatOrdner.Click += new System.EventHandler(this.btnMonatOrdner_Click);
            // 
            // txtMonatOrdner
            // 
            this.txtMonatOrdner.Location = new System.Drawing.Point(198, 90);
            this.txtMonatOrdner.Name = "txtMonatOrdner";
            this.txtMonatOrdner.ReadOnly = true;
            this.txtMonatOrdner.Size = new System.Drawing.Size(208, 20);
            this.txtMonatOrdner.TabIndex = 16;
            // 
            // lblMonatsuebersichtOrdner
            // 
            this.lblMonatsuebersichtOrdner.AutoSize = true;
            this.lblMonatsuebersichtOrdner.Location = new System.Drawing.Point(12, 93);
            this.lblMonatsuebersichtOrdner.Name = "lblMonatsuebersichtOrdner";
            this.lblMonatsuebersichtOrdner.Size = new System.Drawing.Size(123, 13);
            this.lblMonatsuebersichtOrdner.TabIndex = 15;
            this.lblMonatsuebersichtOrdner.Text = "Monatsübersicht Ordner:";
            // 
            // FormEinstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 214);
            this.Controls.Add(this.btnMonatOrdner);
            this.Controls.Add(this.txtMonatOrdner);
            this.Controls.Add(this.lblMonatsuebersichtOrdner);
            this.Controls.Add(this.btnMonatvorlage);
            this.Controls.Add(this.txtMonatvorlage);
            this.Controls.Add(this.lblMonatvorlage);
            this.Controls.Add(this.numerMwst);
            this.Controls.Add(this.lblMwst);
            this.Controls.Add(this.btnSelectPathOrdnerRechnungen);
            this.Controls.Add(this.txtOrdnerRechnungen);
            this.Controls.Add(this.lblOrdnerRechnungen);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.txtDateipfadVorlage);
            this.Controls.Add(this.lblDateipfadVorlage);
            this.Controls.Add(this.txtRechnungsnummer);
            this.Controls.Add(this.lblRechnungsnummer);
            this.Controls.Add(this.BtnSpeichern);
            this.Controls.Add(this.btnAbbrechen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEinstellungen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Einstellungen - justforyou - Excel";
            this.Load += new System.EventHandler(this.FormEinstellungen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numerMwst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Button BtnSpeichern;
        private System.Windows.Forms.Label lblRechnungsnummer;
        private System.Windows.Forms.TextBox txtRechnungsnummer;
        private System.Windows.Forms.Label lblDateipfadVorlage;
        private System.Windows.Forms.TextBox txtDateipfadVorlage;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.TextBox txtOrdnerRechnungen;
        private System.Windows.Forms.Label lblOrdnerRechnungen;
        private System.Windows.Forms.Button btnSelectPathOrdnerRechnungen;
        private System.Windows.Forms.Label lblMwst;
        private System.Windows.Forms.NumericUpDown numerMwst;
        private System.Windows.Forms.Button btnMonatvorlage;
        private System.Windows.Forms.TextBox txtMonatvorlage;
        private System.Windows.Forms.Label lblMonatvorlage;
        private System.Windows.Forms.Button btnMonatOrdner;
        private System.Windows.Forms.TextBox txtMonatOrdner;
        private System.Windows.Forms.Label lblMonatsuebersichtOrdner;
    }
}