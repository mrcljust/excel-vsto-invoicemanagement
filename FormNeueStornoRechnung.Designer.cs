namespace justforyou_Excel
{
    partial class FormNeueStornoRechnung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNeueStornoRechnung));
            this.richtxtEmpfaenger = new System.Windows.Forms.RichTextBox();
            this.txtRechnungsnummer = new System.Windows.Forms.TextBox();
            this.lblRechnungsnummer = new System.Windows.Forms.Label();
            this.lblEmpfaenger = new System.Windows.Forms.Label();
            this.dateTimeRechnungsdatum = new System.Windows.Forms.DateTimePicker();
            this.lblRechnungsdatum = new System.Windows.Forms.Label();
            this.listViewArtikel = new System.Windows.Forms.ListView();
            this.columnArtikel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMenge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMwSt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEinzelpreis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGesamtpreis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblVersand = new System.Windows.Forms.Label();
            this.txtVersand = new System.Windows.Forms.TextBox();
            this.radio599Paket = new System.Windows.Forms.RadioButton();
            this.radio299Warensendung = new System.Windows.Forms.RadioButton();
            this.radioManuell = new System.Windows.Forms.RadioButton();
            this.BtnSpeichern = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.btnAuswahlBearbeiten = new System.Windows.Forms.Button();
            this.btnNeuerArtikel = new System.Windows.Forms.Button();
            this.btnAuswahlLoeschen = new System.Windows.Forms.Button();
            this.lblEuro = new System.Windows.Forms.Label();
            this.btnOeffnen = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.cbEditYear = new System.Windows.Forms.CheckBox();
            this.lblStrich = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.btnSaveAndPrint = new System.Windows.Forms.Button();
            this.radio0Versand = new System.Windows.Forms.RadioButton();
            this.lblStorno = new System.Windows.Forms.Label();
            this.dateTimeRechnungUrsprung = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBestelldatum = new System.Windows.Forms.Label();
            this.datetimeBestelldatum = new System.Windows.Forms.DateTimePicker();
            this.lblRUrsprung = new System.Windows.Forms.Label();
            this.lblRechnungsNrUrsprung = new System.Windows.Forms.Label();
            this.txtRechnungsNrUrsprung = new System.Windows.Forms.TextBox();
            this.lblRechnungUrsprungUnterstrich = new System.Windows.Forms.Label();
            this.cbRechnungUrsprungYear = new System.Windows.Forms.CheckBox();
            this.txtRechnungUrsprungYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richtxtEmpfaenger
            // 
            this.richtxtEmpfaenger.Location = new System.Drawing.Point(120, 168);
            this.richtxtEmpfaenger.Name = "richtxtEmpfaenger";
            this.richtxtEmpfaenger.Size = new System.Drawing.Size(200, 96);
            this.richtxtEmpfaenger.TabIndex = 12;
            this.richtxtEmpfaenger.Text = "";
            // 
            // txtRechnungsnummer
            // 
            this.txtRechnungsnummer.Location = new System.Drawing.Point(132, 12);
            this.txtRechnungsnummer.Name = "txtRechnungsnummer";
            this.txtRechnungsnummer.Size = new System.Drawing.Size(50, 20);
            this.txtRechnungsnummer.TabIndex = 3;
            // 
            // lblRechnungsnummer
            // 
            this.lblRechnungsnummer.AutoSize = true;
            this.lblRechnungsnummer.Location = new System.Drawing.Point(12, 15);
            this.lblRechnungsnummer.Name = "lblRechnungsnummer";
            this.lblRechnungsnummer.Size = new System.Drawing.Size(102, 13);
            this.lblRechnungsnummer.TabIndex = 4;
            this.lblRechnungsnummer.Text = "Rechnungsnummer:";
            // 
            // lblEmpfaenger
            // 
            this.lblEmpfaenger.AutoSize = true;
            this.lblEmpfaenger.Location = new System.Drawing.Point(12, 171);
            this.lblEmpfaenger.Name = "lblEmpfaenger";
            this.lblEmpfaenger.Size = new System.Drawing.Size(61, 13);
            this.lblEmpfaenger.TabIndex = 5;
            this.lblEmpfaenger.Text = "Empfänger:";
            // 
            // dateTimeRechnungsdatum
            // 
            this.dateTimeRechnungsdatum.Location = new System.Drawing.Point(120, 38);
            this.dateTimeRechnungsdatum.Name = "dateTimeRechnungsdatum";
            this.dateTimeRechnungsdatum.Size = new System.Drawing.Size(200, 20);
            this.dateTimeRechnungsdatum.TabIndex = 6;
            // 
            // lblRechnungsdatum
            // 
            this.lblRechnungsdatum.AutoSize = true;
            this.lblRechnungsdatum.Location = new System.Drawing.Point(12, 41);
            this.lblRechnungsdatum.Name = "lblRechnungsdatum";
            this.lblRechnungsdatum.Size = new System.Drawing.Size(94, 13);
            this.lblRechnungsdatum.TabIndex = 9;
            this.lblRechnungsdatum.Text = "Rechnungsdatum:";
            // 
            // listViewArtikel
            // 
            this.listViewArtikel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewArtikel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnArtikel,
            this.columnMenge,
            this.columnMwSt,
            this.columnEinzelpreis,
            this.columnGesamtpreis});
            this.listViewArtikel.FullRowSelect = true;
            this.listViewArtikel.GridLines = true;
            this.listViewArtikel.HideSelection = false;
            this.listViewArtikel.Location = new System.Drawing.Point(326, 12);
            this.listViewArtikel.Name = "listViewArtikel";
            this.listViewArtikel.Size = new System.Drawing.Size(462, 238);
            this.listViewArtikel.TabIndex = 18;
            this.listViewArtikel.UseCompatibleStateImageBehavior = false;
            this.listViewArtikel.View = System.Windows.Forms.View.Details;
            this.listViewArtikel.SelectedIndexChanged += new System.EventHandler(this.listViewArtikel_SelectedIndexChanged);
            this.listViewArtikel.DoubleClick += new System.EventHandler(this.listViewArtikel_DoubleClick);
            // 
            // columnArtikel
            // 
            this.columnArtikel.Text = "Artikel";
            this.columnArtikel.Width = 238;
            // 
            // columnMenge
            // 
            this.columnMenge.Text = "Menge";
            this.columnMenge.Width = 45;
            // 
            // columnMwSt
            // 
            this.columnMwSt.Text = "MwSt.";
            this.columnMwSt.Width = 42;
            // 
            // columnEinzelpreis
            // 
            this.columnEinzelpreis.Text = "Einzelpreis";
            this.columnEinzelpreis.Width = 62;
            // 
            // columnGesamtpreis
            // 
            this.columnGesamtpreis.Text = "Gesamtpreis";
            this.columnGesamtpreis.Width = 70;
            // 
            // lblVersand
            // 
            this.lblVersand.AutoSize = true;
            this.lblVersand.Location = new System.Drawing.Point(12, 273);
            this.lblVersand.Name = "lblVersand";
            this.lblVersand.Size = new System.Drawing.Size(81, 13);
            this.lblVersand.TabIndex = 12;
            this.lblVersand.Text = "Versandkosten:";
            // 
            // txtVersand
            // 
            this.txtVersand.Enabled = false;
            this.txtVersand.Location = new System.Drawing.Point(132, 270);
            this.txtVersand.Name = "txtVersand";
            this.txtVersand.Size = new System.Drawing.Size(169, 20);
            this.txtVersand.TabIndex = 13;
            this.txtVersand.Text = "5,99";
            this.txtVersand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVersand_KeyPress);
            // 
            // radio599Paket
            // 
            this.radio599Paket.AutoSize = true;
            this.radio599Paket.Checked = true;
            this.radio599Paket.Location = new System.Drawing.Point(120, 296);
            this.radio599Paket.Name = "radio599Paket";
            this.radio599Paket.Size = new System.Drawing.Size(52, 17);
            this.radio599Paket.TabIndex = 14;
            this.radio599Paket.TabStop = true;
            this.radio599Paket.Text = "5,99€";
            this.radio599Paket.UseVisualStyleBackColor = true;
            this.radio599Paket.CheckedChanged += new System.EventHandler(this.radio599Paket_CheckedChanged);
            // 
            // radio299Warensendung
            // 
            this.radio299Warensendung.AutoSize = true;
            this.radio299Warensendung.Location = new System.Drawing.Point(178, 296);
            this.radio299Warensendung.Name = "radio299Warensendung";
            this.radio299Warensendung.Size = new System.Drawing.Size(52, 17);
            this.radio299Warensendung.TabIndex = 15;
            this.radio299Warensendung.Text = "2,99€";
            this.radio299Warensendung.UseVisualStyleBackColor = true;
            this.radio299Warensendung.CheckedChanged += new System.EventHandler(this.radio299Warensendung_CheckedChanged);
            // 
            // radioManuell
            // 
            this.radioManuell.AutoSize = true;
            this.radioManuell.Location = new System.Drawing.Point(120, 319);
            this.radioManuell.Name = "radioManuell";
            this.radioManuell.Size = new System.Drawing.Size(62, 17);
            this.radioManuell.TabIndex = 17;
            this.radioManuell.Text = "Manuell";
            this.radioManuell.UseVisualStyleBackColor = true;
            this.radioManuell.CheckedChanged += new System.EventHandler(this.radioManuell_CheckedChanged);
            // 
            // BtnSpeichern
            // 
            this.BtnSpeichern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSpeichern.Location = new System.Drawing.Point(453, 294);
            this.BtnSpeichern.Name = "BtnSpeichern";
            this.BtnSpeichern.Size = new System.Drawing.Size(124, 42);
            this.BtnSpeichern.TabIndex = 45;
            this.BtnSpeichern.Text = "Rechnung speichern";
            this.BtnSpeichern.UseVisualStyleBackColor = true;
            this.BtnSpeichern.Click += new System.EventHandler(this.BtnSpeichern_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbbrechen.Location = new System.Drawing.Point(713, 294);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(75, 42);
            this.btnAbbrechen.TabIndex = 47;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // btnAuswahlBearbeiten
            // 
            this.btnAuswahlBearbeiten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAuswahlBearbeiten.Location = new System.Drawing.Point(447, 256);
            this.btnAuswahlBearbeiten.Name = "btnAuswahlBearbeiten";
            this.btnAuswahlBearbeiten.Size = new System.Drawing.Size(115, 23);
            this.btnAuswahlBearbeiten.TabIndex = 20;
            this.btnAuswahlBearbeiten.Text = "Auswahl bearbeiten";
            this.btnAuswahlBearbeiten.UseVisualStyleBackColor = true;
            this.btnAuswahlBearbeiten.Click += new System.EventHandler(this.btnAuswahlBearbeiten_Click);
            // 
            // btnNeuerArtikel
            // 
            this.btnNeuerArtikel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNeuerArtikel.Location = new System.Drawing.Point(326, 256);
            this.btnNeuerArtikel.Name = "btnNeuerArtikel";
            this.btnNeuerArtikel.Size = new System.Drawing.Size(115, 23);
            this.btnNeuerArtikel.TabIndex = 19;
            this.btnNeuerArtikel.Text = "Neuer Artikel";
            this.btnNeuerArtikel.UseVisualStyleBackColor = true;
            this.btnNeuerArtikel.Click += new System.EventHandler(this.btnNeuerArtikel_Click);
            // 
            // btnAuswahlLoeschen
            // 
            this.btnAuswahlLoeschen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAuswahlLoeschen.Location = new System.Drawing.Point(568, 256);
            this.btnAuswahlLoeschen.Name = "btnAuswahlLoeschen";
            this.btnAuswahlLoeschen.Size = new System.Drawing.Size(115, 23);
            this.btnAuswahlLoeschen.TabIndex = 21;
            this.btnAuswahlLoeschen.Text = "Auswahl löschen";
            this.btnAuswahlLoeschen.UseVisualStyleBackColor = true;
            this.btnAuswahlLoeschen.Click += new System.EventHandler(this.btnAuswahlLoeschen_Click);
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(307, 273);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(13, 13);
            this.lblEuro.TabIndex = 29;
            this.lblEuro.Text = "€";
            // 
            // btnOeffnen
            // 
            this.btnOeffnen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOeffnen.Location = new System.Drawing.Point(323, 294);
            this.btnOeffnen.Name = "btnOeffnen";
            this.btnOeffnen.Size = new System.Drawing.Size(124, 42);
            this.btnOeffnen.TabIndex = 44;
            this.btnOeffnen.Text = "Rechnung in Excel öffnen";
            this.btnOeffnen.UseVisualStyleBackColor = true;
            this.btnOeffnen.Click += new System.EventHandler(this.btnOeffnen_Click);
            // 
            // txtYear
            // 
            this.txtYear.Enabled = false;
            this.txtYear.Location = new System.Drawing.Point(197, 12);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(23, 20);
            this.txtYear.TabIndex = 4;
            // 
            // cbEditYear
            // 
            this.cbEditYear.AutoSize = true;
            this.cbEditYear.Location = new System.Drawing.Point(226, 15);
            this.cbEditYear.Name = "cbEditYear";
            this.cbEditYear.Size = new System.Drawing.Size(15, 14);
            this.cbEditYear.TabIndex = 5;
            this.cbEditYear.UseVisualStyleBackColor = true;
            this.cbEditYear.CheckedChanged += new System.EventHandler(this.cbEditYear_CheckedChanged);
            // 
            // lblStrich
            // 
            this.lblStrich.AutoSize = true;
            this.lblStrich.Location = new System.Drawing.Point(184, 15);
            this.lblStrich.Name = "lblStrich";
            this.lblStrich.Size = new System.Drawing.Size(13, 13);
            this.lblStrich.TabIndex = 33;
            this.lblStrich.Text = "_";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(117, 15);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(15, 13);
            this.lblR.TabIndex = 46;
            this.lblR.Text = "R";
            // 
            // btnSaveAndPrint
            // 
            this.btnSaveAndPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAndPrint.Location = new System.Drawing.Point(583, 294);
            this.btnSaveAndPrint.Name = "btnSaveAndPrint";
            this.btnSaveAndPrint.Size = new System.Drawing.Size(124, 42);
            this.btnSaveAndPrint.TabIndex = 46;
            this.btnSaveAndPrint.Text = "Rechnung speichern und drucken";
            this.btnSaveAndPrint.UseVisualStyleBackColor = true;
            this.btnSaveAndPrint.Click += new System.EventHandler(this.btnSaveAndPrint_Click);
            // 
            // radio0Versand
            // 
            this.radio0Versand.AutoSize = true;
            this.radio0Versand.Location = new System.Drawing.Point(236, 296);
            this.radio0Versand.Name = "radio0Versand";
            this.radio0Versand.Size = new System.Drawing.Size(52, 17);
            this.radio0Versand.TabIndex = 16;
            this.radio0Versand.Text = "0,00€";
            this.radio0Versand.UseVisualStyleBackColor = true;
            this.radio0Versand.CheckedChanged += new System.EventHandler(this.radio0Versand_CheckedChanged);
            // 
            // lblStorno
            // 
            this.lblStorno.AutoSize = true;
            this.lblStorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorno.ForeColor = System.Drawing.Color.Red;
            this.lblStorno.Location = new System.Drawing.Point(258, 15);
            this.lblStorno.Name = "lblStorno";
            this.lblStorno.Size = new System.Drawing.Size(59, 13);
            this.lblStorno.TabIndex = 50;
            this.lblStorno.Text = "STORNO";
            // 
            // dateTimeRechnungUrsprung
            // 
            this.dateTimeRechnungUrsprung.Location = new System.Drawing.Point(110, 44);
            this.dateTimeRechnungUrsprung.Name = "dateTimeRechnungUrsprung";
            this.dateTimeRechnungUrsprung.Size = new System.Drawing.Size(200, 20);
            this.dateTimeRechnungUrsprung.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRechnungUrsprungUnterstrich);
            this.groupBox1.Controls.Add(this.lblRUrsprung);
            this.groupBox1.Controls.Add(this.cbRechnungUrsprungYear);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRechnungUrsprungYear);
            this.groupBox1.Controls.Add(this.lblRechnungsNrUrsprung);
            this.groupBox1.Controls.Add(this.txtRechnungsNrUrsprung);
            this.groupBox1.Controls.Add(this.dateTimeRechnungUrsprung);
            this.groupBox1.Controls.Add(this.lblBestelldatum);
            this.groupBox1.Controls.Add(this.datetimeBestelldatum);
            this.groupBox1.Location = new System.Drawing.Point(8, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 99);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ursprüngliche Rechnung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Rechnungsdatum:";
            // 
            // lblBestelldatum
            // 
            this.lblBestelldatum.AutoSize = true;
            this.lblBestelldatum.Location = new System.Drawing.Point(4, 24);
            this.lblBestelldatum.Name = "lblBestelldatum";
            this.lblBestelldatum.Size = new System.Drawing.Size(70, 13);
            this.lblBestelldatum.TabIndex = 0;
            this.lblBestelldatum.Text = "Bestelldatum:";
            // 
            // datetimeBestelldatum
            // 
            this.datetimeBestelldatum.Location = new System.Drawing.Point(110, 18);
            this.datetimeBestelldatum.Name = "datetimeBestelldatum";
            this.datetimeBestelldatum.Size = new System.Drawing.Size(200, 20);
            this.datetimeBestelldatum.TabIndex = 7;
            // 
            // lblRUrsprung
            // 
            this.lblRUrsprung.AutoSize = true;
            this.lblRUrsprung.Location = new System.Drawing.Point(109, 73);
            this.lblRUrsprung.Name = "lblRUrsprung";
            this.lblRUrsprung.Size = new System.Drawing.Size(15, 13);
            this.lblRUrsprung.TabIndex = 56;
            this.lblRUrsprung.Text = "R";
            // 
            // lblRechnungsNrUrsprung
            // 
            this.lblRechnungsNrUrsprung.AutoSize = true;
            this.lblRechnungsNrUrsprung.Location = new System.Drawing.Point(4, 73);
            this.lblRechnungsNrUrsprung.Name = "lblRechnungsNrUrsprung";
            this.lblRechnungsNrUrsprung.Size = new System.Drawing.Size(102, 13);
            this.lblRechnungsNrUrsprung.TabIndex = 55;
            this.lblRechnungsNrUrsprung.Text = "Rechnungsnummer:";
            // 
            // txtRechnungsNrUrsprung
            // 
            this.txtRechnungsNrUrsprung.Location = new System.Drawing.Point(124, 70);
            this.txtRechnungsNrUrsprung.Name = "txtRechnungsNrUrsprung";
            this.txtRechnungsNrUrsprung.Size = new System.Drawing.Size(50, 20);
            this.txtRechnungsNrUrsprung.TabIndex = 9;
            // 
            // lblRechnungUrsprungUnterstrich
            // 
            this.lblRechnungUrsprungUnterstrich.AutoSize = true;
            this.lblRechnungUrsprungUnterstrich.Location = new System.Drawing.Point(174, 73);
            this.lblRechnungUrsprungUnterstrich.Name = "lblRechnungUrsprungUnterstrich";
            this.lblRechnungUrsprungUnterstrich.Size = new System.Drawing.Size(13, 13);
            this.lblRechnungUrsprungUnterstrich.TabIndex = 56;
            this.lblRechnungUrsprungUnterstrich.Text = "_";
            // 
            // cbRechnungUrsprungYear
            // 
            this.cbRechnungUrsprungYear.AutoSize = true;
            this.cbRechnungUrsprungYear.Location = new System.Drawing.Point(216, 73);
            this.cbRechnungUrsprungYear.Name = "cbRechnungUrsprungYear";
            this.cbRechnungUrsprungYear.Size = new System.Drawing.Size(15, 14);
            this.cbRechnungUrsprungYear.TabIndex = 11;
            this.cbRechnungUrsprungYear.UseVisualStyleBackColor = true;
            this.cbRechnungUrsprungYear.CheckedChanged += new System.EventHandler(this.cbRechnungUrsprungYear_CheckedChanged);
            // 
            // txtRechnungUrsprungYear
            // 
            this.txtRechnungUrsprungYear.Enabled = false;
            this.txtRechnungUrsprungYear.Location = new System.Drawing.Point(187, 70);
            this.txtRechnungUrsprungYear.Name = "txtRechnungUrsprungYear";
            this.txtRechnungUrsprungYear.Size = new System.Drawing.Size(23, 20);
            this.txtRechnungUrsprungYear.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "-";
            // 
            // FormNeueStornoRechnung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 348);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStorno);
            this.Controls.Add(this.radio0Versand);
            this.Controls.Add(this.btnSaveAndPrint);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblStrich);
            this.Controls.Add(this.cbEditYear);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.btnOeffnen);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.btnAuswahlLoeschen);
            this.Controls.Add(this.btnNeuerArtikel);
            this.Controls.Add(this.btnAuswahlBearbeiten);
            this.Controls.Add(this.BtnSpeichern);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.radioManuell);
            this.Controls.Add(this.radio299Warensendung);
            this.Controls.Add(this.radio599Paket);
            this.Controls.Add(this.txtVersand);
            this.Controls.Add(this.lblVersand);
            this.Controls.Add(this.listViewArtikel);
            this.Controls.Add(this.lblRechnungsdatum);
            this.Controls.Add(this.dateTimeRechnungsdatum);
            this.Controls.Add(this.lblEmpfaenger);
            this.Controls.Add(this.lblRechnungsnummer);
            this.Controls.Add(this.txtRechnungsnummer);
            this.Controls.Add(this.richtxtEmpfaenger);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNeueStornoRechnung";
            this.Text = "Neue Stornorechnung - justforyou - Excel";
            this.Load += new System.EventHandler(this.FormNeueRechnung_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richtxtEmpfaenger;
        private System.Windows.Forms.TextBox txtRechnungsnummer;
        private System.Windows.Forms.Label lblRechnungsnummer;
        private System.Windows.Forms.Label lblEmpfaenger;
        private System.Windows.Forms.DateTimePicker dateTimeRechnungsdatum;
        private System.Windows.Forms.Label lblRechnungsdatum;
        private System.Windows.Forms.ListView listViewArtikel;
        private System.Windows.Forms.ColumnHeader columnArtikel;
        private System.Windows.Forms.ColumnHeader columnMenge;
        private System.Windows.Forms.ColumnHeader columnMwSt;
        private System.Windows.Forms.ColumnHeader columnEinzelpreis;
        private System.Windows.Forms.ColumnHeader columnGesamtpreis;
        private System.Windows.Forms.Label lblVersand;
        private System.Windows.Forms.TextBox txtVersand;
        private System.Windows.Forms.RadioButton radio599Paket;
        private System.Windows.Forms.RadioButton radio299Warensendung;
        private System.Windows.Forms.RadioButton radioManuell;
        private System.Windows.Forms.Button BtnSpeichern;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Button btnAuswahlBearbeiten;
        private System.Windows.Forms.Button btnNeuerArtikel;
        private System.Windows.Forms.Button btnAuswahlLoeschen;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Button btnOeffnen;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.CheckBox cbEditYear;
        private System.Windows.Forms.Label lblStrich;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Button btnSaveAndPrint;
        private System.Windows.Forms.RadioButton radio0Versand;
        private System.Windows.Forms.Label lblStorno;
        private System.Windows.Forms.DateTimePicker dateTimeRechnungUrsprung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRUrsprung;
        private System.Windows.Forms.Label lblRechnungsNrUrsprung;
        private System.Windows.Forms.TextBox txtRechnungsNrUrsprung;
        private System.Windows.Forms.Label lblBestelldatum;
        private System.Windows.Forms.DateTimePicker datetimeBestelldatum;
        private System.Windows.Forms.Label lblRechnungUrsprungUnterstrich;
        private System.Windows.Forms.CheckBox cbRechnungUrsprungYear;
        private System.Windows.Forms.TextBox txtRechnungUrsprungYear;
        private System.Windows.Forms.Label label2;
    }
}