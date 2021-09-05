using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace justforyou_Excel
{
    public partial class FormNeuerArtikel : Form
    {
        private InvoiceItem[] prevEntries = new InvoiceItem[0];

        public String bezeichnung { get; set; }

        public bool groesseEnable { get; set; }
        public string groesse { get; set; }
        public int menge { get; set; }
        
        public double preis { get; set; }
        public int mwst { get; set; }
        public Boolean edit { get; set; }
        public FormNeuerArtikel()
        {
            InitializeComponent();
        }

        private void FormNeuerArtikel_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                      @"\Just\justforyou Excel\prev.ini"))
            {
                prevEntries = InvoiceItem.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Just\justforyou Excel\prev.ini");
            }

            if (prevEntries != null)
            {
                foreach (InvoiceItem s in prevEntries)
                {
                    txtArtikelbezeichnung.Items.Add(s.name);
                }
            }

            if (edit)
            {
                txtArtikelbezeichnung.Text = bezeichnung;
                if (groesseEnable)
                {
                    cbGroesse.Checked = true;
                    comboGroesse.Text = groesse;
                }
                numericUpDownMenge.Value = menge;
                if (mwst == 7)  //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                {
                    radio7MwSt.Checked = true;
                }
                else if (mwst == 19)  //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                {
                    radio19MwSt.Checked = true;
                }
                else
                {
                    radioManuell.Checked = true;
                }
                numericUpDownMwSt.Value = mwst;
                txtPreis.Text = preis.ToString();
            }
        }

        private void radio19MwSt_CheckedChanged(object sender, EventArgs e)
        {
            if (radio19MwSt.Checked)
                numericUpDownMwSt.Value = 19;
        }

        private void radio7MwSt_CheckedChanged(object sender, EventArgs e)
        {
            if (radio7MwSt.Checked)
                numericUpDownMwSt.Value = 7;
        }

        private void radioManuell_CheckedChanged(object sender, EventArgs e)
        {
            if (radioManuell.Checked)
                numericUpDownMwSt.Enabled = true; numericUpDownMwSt.Value = 19; numericUpDownMwSt.Focus(); //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            if (!radioManuell.Checked)
                numericUpDownMwSt.Enabled = false;
        }

        private void BtnSpeichern_Click(object sender, EventArgs e)
        {
            if(txtPreis.Text != "" && txtArtikelbezeichnung.Text != "")
            {
                if (cbGroesse.Checked && comboGroesse.Text == "")
                {
                    MessageBox.Show("Bitte Größe eintragen oder Haken entfernen", "justforyou - Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (InvoiceItem.alreadyInArray(prevEntries, txtArtikelbezeichnung.Text))
                {
                    InvoiceItem.changeValues(prevEntries, txtArtikelbezeichnung.Text, double.Parse(txtPreis.Text),
                        (int) numericUpDownMwSt.Value);
                }
                else
                {
                    Array.Resize(ref prevEntries, prevEntries.Length + 1);
                    prevEntries[(txtArtikelbezeichnung.Items.Count)] = new InvoiceItem(txtArtikelbezeichnung.Text, double.Parse(txtPreis.Text), (int)numericUpDownMwSt.Value);
                }
                InvoiceItem.ToFile(prevEntries, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Just\justforyou Excel\prev.ini");

                this.DialogResult = DialogResult.OK;
                bezeichnung = txtArtikelbezeichnung.Text;
                groesseEnable = cbGroesse.Checked;
                groesse = comboGroesse.Text;
                preis = double.Parse(txtPreis.Text);
                menge = (int)numericUpDownMenge.Value;
                mwst = (int)numericUpDownMwSt.Value;
                if(mwst!=19)
                {
                    MessageBox.Show("Die automatische Berechnung der MwSt funktioniert nur bei 19%, bitte prüfen Sie daher die MwSt und den Nettobetrag in der Rechnung (Öffnen Sie die Rechnung vor dem Speichern).", "MwSt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            else
            {
                if (txtArtikelbezeichnung.Text != "")
                    MessageBox.Show("Bitte Stückpreis eintragen", "justforyou - Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (txtPreis.Text != "")
                    MessageBox.Show("Bitte Artikelbezeichnung eintragen", "justforyou - Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Bitte Artikelbezeichnung und Stückpreis eintragen", "justforyou - Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtPreis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void txtArtikelbezeichnung_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshValues();
        }

        private void RefreshValues()
        {
            double pPreis = InvoiceItem.getPreisFromArray(prevEntries, txtArtikelbezeichnung.Text);
            int pMwst = InvoiceItem.getMwstFromArray(prevEntries, txtArtikelbezeichnung.Text);
            if (pPreis != 0)
            {
                txtPreis.Text = Convert.ToString(InvoiceItem.getPreisFromArray(prevEntries, txtArtikelbezeichnung.Text));
            }

            if (pMwst != 0)
            {
                //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                if (pMwst == 19 || pMwst == 16)
                {
                    radio19MwSt.Checked = true;
                    numericUpDownMwSt.Value = 19; //!! & zwei RadioButtons + Textbox Text in Form ändern
                }
                else if (pMwst == 7 || pMwst == 5)
                {
                    radio7MwSt.Checked = true;
                    numericUpDownMwSt.Value = 7; //!!
                }
                else
                {
                    radioManuell.Checked = true;
                    numericUpDownMwSt.Value = InvoiceItem.getMwstFromArray(prevEntries, txtArtikelbezeichnung.Text);
                }
            }
        }

        private void txtArtikelbezeichnung_TextChanged(object sender, EventArgs e)
        {
            RefreshValues();
        }

        private void cbGroesse_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGroesse.Checked)
            {
                comboGroesse.Enabled = true;
                comboGroesse.Focus();
            }
            else
            {
                comboGroesse.Enabled = false;
            }
        }
    }
}
