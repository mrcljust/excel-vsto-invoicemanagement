namespace justforyou_Excel
{
    partial class FormNeuerArtikel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNeuerArtikel));
            this.lblArtikelbezeichnung = new System.Windows.Forms.Label();
            this.lblMenge = new System.Windows.Forms.Label();
            this.numericUpDownMenge = new System.Windows.Forms.NumericUpDown();
            this.radioManuell = new System.Windows.Forms.RadioButton();
            this.radio7MwSt = new System.Windows.Forms.RadioButton();
            this.radio19MwSt = new System.Windows.Forms.RadioButton();
            this.lblMwSt = new System.Windows.Forms.Label();
            this.BtnSpeichern = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.numericUpDownMwSt = new System.Windows.Forms.NumericUpDown();
            this.txtPreis = new System.Windows.Forms.TextBox();
            this.lblPreis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArtikelbezeichnung = new System.Windows.Forms.ComboBox();
            this.comboGroesse = new System.Windows.Forms.ComboBox();
            this.cbGroesse = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMenge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMwSt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArtikelbezeichnung
            // 
            this.lblArtikelbezeichnung.AutoSize = true;
            this.lblArtikelbezeichnung.Location = new System.Drawing.Point(12, 15);
            this.lblArtikelbezeichnung.Name = "lblArtikelbezeichnung";
            this.lblArtikelbezeichnung.Size = new System.Drawing.Size(100, 13);
            this.lblArtikelbezeichnung.TabIndex = 0;
            this.lblArtikelbezeichnung.Text = "Artikelbezeichnung:";
            // 
            // lblMenge
            // 
            this.lblMenge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenge.AutoSize = true;
            this.lblMenge.Location = new System.Drawing.Point(12, 72);
            this.lblMenge.Name = "lblMenge";
            this.lblMenge.Size = new System.Drawing.Size(43, 13);
            this.lblMenge.TabIndex = 5;
            this.lblMenge.Text = "Menge:";
            // 
            // numericUpDownMenge
            // 
            this.numericUpDownMenge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownMenge.Location = new System.Drawing.Point(121, 70);
            this.numericUpDownMenge.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownMenge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMenge.Name = "numericUpDownMenge";
            this.numericUpDownMenge.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownMenge.TabIndex = 7;
            this.numericUpDownMenge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioManuell
            // 
            this.radioManuell.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioManuell.AutoSize = true;
            this.radioManuell.Location = new System.Drawing.Point(217, 148);
            this.radioManuell.Name = "radioManuell";
            this.radioManuell.Size = new System.Drawing.Size(62, 17);
            this.radioManuell.TabIndex = 21;
            this.radioManuell.Text = "Manuell";
            this.radioManuell.UseVisualStyleBackColor = true;
            this.radioManuell.CheckedChanged += new System.EventHandler(this.radioManuell_CheckedChanged);
            // 
            // radio7MwSt
            // 
            this.radio7MwSt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radio7MwSt.AutoSize = true;
            this.radio7MwSt.Location = new System.Drawing.Point(172, 148);
            this.radio7MwSt.Name = "radio7MwSt";
            this.radio7MwSt.Size = new System.Drawing.Size(39, 17);
            this.radio7MwSt.TabIndex = 20;
            this.radio7MwSt.Text = "7%";
            this.radio7MwSt.UseVisualStyleBackColor = true;
            this.radio7MwSt.CheckedChanged += new System.EventHandler(this.radio7MwSt_CheckedChanged);
            // 
            // radio19MwSt
            // 
            this.radio19MwSt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radio19MwSt.AutoSize = true;
            this.radio19MwSt.Checked = true;
            this.radio19MwSt.Location = new System.Drawing.Point(121, 148);
            this.radio19MwSt.Name = "radio19MwSt";
            this.radio19MwSt.Size = new System.Drawing.Size(45, 17);
            this.radio19MwSt.TabIndex = 19;
            this.radio19MwSt.TabStop = true;
            this.radio19MwSt.Text = "19%";
            this.radio19MwSt.UseVisualStyleBackColor = true;
            this.radio19MwSt.CheckedChanged += new System.EventHandler(this.radio19MwSt_CheckedChanged);
            // 
            // lblMwSt
            // 
            this.lblMwSt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMwSt.AutoSize = true;
            this.lblMwSt.Location = new System.Drawing.Point(12, 125);
            this.lblMwSt.Name = "lblMwSt";
            this.lblMwSt.Size = new System.Drawing.Size(37, 13);
            this.lblMwSt.TabIndex = 17;
            this.lblMwSt.Text = "MwSt:";
            // 
            // BtnSpeichern
            // 
            this.BtnSpeichern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSpeichern.Location = new System.Drawing.Point(165, 172);
            this.BtnSpeichern.Name = "BtnSpeichern";
            this.BtnSpeichern.Size = new System.Drawing.Size(75, 23);
            this.BtnSpeichern.TabIndex = 23;
            this.BtnSpeichern.Text = "Speichern";
            this.BtnSpeichern.UseVisualStyleBackColor = true;
            this.BtnSpeichern.Click += new System.EventHandler(this.BtnSpeichern_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbbrechen.Location = new System.Drawing.Point(246, 172);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.btnAbbrechen.TabIndex = 24;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // numericUpDownMwSt
            // 
            this.numericUpDownMwSt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownMwSt.Enabled = false;
            this.numericUpDownMwSt.Location = new System.Drawing.Point(121, 122);
            this.numericUpDownMwSt.Name = "numericUpDownMwSt";
            this.numericUpDownMwSt.Size = new System.Drawing.Size(181, 20);
            this.numericUpDownMwSt.TabIndex = 9;
            this.numericUpDownMwSt.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            // 
            // txtPreis
            // 
            this.txtPreis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreis.Location = new System.Drawing.Point(121, 96);
            this.txtPreis.Name = "txtPreis";
            this.txtPreis.Size = new System.Drawing.Size(181, 20);
            this.txtPreis.TabIndex = 8;
            this.txtPreis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreis_KeyPress);
            // 
            // lblPreis
            // 
            this.lblPreis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreis.AutoSize = true;
            this.lblPreis.Location = new System.Drawing.Point(12, 99);
            this.lblPreis.Name = "lblPreis";
            this.lblPreis.Size = new System.Drawing.Size(96, 13);
            this.lblPreis.TabIndex = 27;
            this.lblPreis.Text = "Stückpreis (brutto):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "%";
            // 
            // txtArtikelbezeichnung
            // 
            this.txtArtikelbezeichnung.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtArtikelbezeichnung.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtArtikelbezeichnung.FormattingEnabled = true;
            this.txtArtikelbezeichnung.Location = new System.Drawing.Point(121, 12);
            this.txtArtikelbezeichnung.Name = "txtArtikelbezeichnung";
            this.txtArtikelbezeichnung.Size = new System.Drawing.Size(200, 21);
            this.txtArtikelbezeichnung.TabIndex = 1;
            this.txtArtikelbezeichnung.SelectedIndexChanged += new System.EventHandler(this.txtArtikelbezeichnung_SelectedIndexChanged);
            this.txtArtikelbezeichnung.TextChanged += new System.EventHandler(this.txtArtikelbezeichnung_TextChanged);
            // 
            // comboGroesse
            // 
            this.comboGroesse.Enabled = false;
            this.comboGroesse.FormattingEnabled = true;
            this.comboGroesse.Items.AddRange(new object[] {
            "2XS",
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "2XL",
            "3XL",
            "4XL",
            "5XL"});
            this.comboGroesse.Location = new System.Drawing.Point(185, 39);
            this.comboGroesse.Name = "comboGroesse";
            this.comboGroesse.Size = new System.Drawing.Size(136, 21);
            this.comboGroesse.TabIndex = 3;
            // 
            // cbGroesse
            // 
            this.cbGroesse.AutoSize = true;
            this.cbGroesse.Location = new System.Drawing.Point(121, 41);
            this.cbGroesse.Name = "cbGroesse";
            this.cbGroesse.Size = new System.Drawing.Size(58, 17);
            this.cbGroesse.TabIndex = 2;
            this.cbGroesse.Text = "Größe:";
            this.cbGroesse.UseVisualStyleBackColor = true;
            this.cbGroesse.CheckedChanged += new System.EventHandler(this.cbGroesse_CheckedChanged);
            // 
            // FormNeuerArtikel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 207);
            this.Controls.Add(this.cbGroesse);
            this.Controls.Add(this.comboGroesse);
            this.Controls.Add(this.txtArtikelbezeichnung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPreis);
            this.Controls.Add(this.txtPreis);
            this.Controls.Add(this.numericUpDownMwSt);
            this.Controls.Add(this.BtnSpeichern);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.radioManuell);
            this.Controls.Add(this.radio7MwSt);
            this.Controls.Add(this.radio19MwSt);
            this.Controls.Add(this.lblMwSt);
            this.Controls.Add(this.numericUpDownMenge);
            this.Controls.Add(this.lblMenge);
            this.Controls.Add(this.lblArtikelbezeichnung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNeuerArtikel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neuer Artikel - Neue Rechnung - justforyou - Excel";
            this.Load += new System.EventHandler(this.FormNeuerArtikel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMenge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMwSt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArtikelbezeichnung;
        private System.Windows.Forms.Label lblMenge;
        private System.Windows.Forms.NumericUpDown numericUpDownMenge;
        private System.Windows.Forms.RadioButton radioManuell;
        private System.Windows.Forms.RadioButton radio7MwSt;
        private System.Windows.Forms.RadioButton radio19MwSt;
        private System.Windows.Forms.Label lblMwSt;
        private System.Windows.Forms.Button BtnSpeichern;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.NumericUpDown numericUpDownMwSt;
        private System.Windows.Forms.TextBox txtPreis;
        private System.Windows.Forms.Label lblPreis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtArtikelbezeichnung;
        private System.Windows.Forms.ComboBox comboGroesse;
        private System.Windows.Forms.CheckBox cbGroesse;
    }
}