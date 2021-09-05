using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace justforyou_Excel
{
    public partial class FormNeueRechnung : Form
    {
        public DateTime bestellDatum { get; set; }
        public DateTime rechnungsDatum { get; set; }
        public string rechnungsNr { get; set; }
        public int rechnungsNrShort { get; set; }
        public string empfaenger { get; set; }
        public string versandkosten { get; set; }
        public ListView artikel { get; set; }
        public string safePath { get; set; }
        public int result { get; set; }

        public FormNeueRechnung()
        {
            InitializeComponent();
        }

        private void radioManuell_CheckedChanged(object sender, EventArgs e)
        {
            if (radioManuell.Checked)
                txtVersand.Enabled = true;
            txtVersand.Text = "";
            txtVersand.Focus();
            if (!radioManuell.Checked)
                txtVersand.Enabled = false;
        }

        private void FormNeueRechnung_Load(object sender, EventArgs e)
        {
            txtYear.Text = DateTime.Now.Year.ToString().Substring(2, 2);
            txtRechnungsnummer.Text = System.IO.File.ReadAllText(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                @"\Just\justforyou Excel\next.ini");
            btnAuswahlBearbeiten.Enabled = false;
            btnAuswahlLoeschen.Enabled = false;
            datetimeBestelldatum.Value = DateTime.Today;
            dateTimeRechnungsdatum.Value = DateTime.Today;
            datetimeBestelldatum.Focus();
        }

        private void radio599Paket_CheckedChanged(object sender, EventArgs e)
        {
            if (radio599Paket.Checked)
                txtVersand.Text = "5,99";
        }

        private void radio299Warensendung_CheckedChanged(object sender, EventArgs e)
        {
            if (radio299Warensendung.Checked)
                txtVersand.Text = "2,99";
        }

        private void btnNeuerArtikel_Click(object sender, EventArgs e)
        {
            FormNeuerArtikel frmNA = new FormNeuerArtikel();
            frmNA.edit = false;
            frmNA.ShowDialog();

            if (frmNA.DialogResult == DialogResult.OK)
            {
                string[] itemArgs;

                if (!frmNA.groesseEnable)
                {
                    itemArgs = new string[]
                    {
                        frmNA.bezeichnung, frmNA.menge.ToString(), frmNA.mwst.ToString() + "%",
                        frmNA.preis.ToString() + "€", (frmNA.preis * frmNA.menge).ToString() + "€"
                    };
                }
                else
                {
                    itemArgs = new string[]
                    {
                        frmNA.bezeichnung + " - Gr. " + frmNA.groesse, frmNA.menge.ToString(), frmNA.mwst.ToString() + "%",
                        frmNA.preis.ToString() + "€", (frmNA.preis * frmNA.menge).ToString() + "€"
                    };
                }
                ListViewItem artikelItem = new ListViewItem(itemArgs);
                listViewArtikel.Items.Add(artikelItem);
            }
        }

        private void listViewArtikel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewArtikel.SelectedItems.Count == 0)
            {
                btnAuswahlBearbeiten.Enabled = false;
                btnAuswahlLoeschen.Enabled = false;
            }

            if (listViewArtikel.SelectedItems.Count == 1)
            {
                btnAuswahlBearbeiten.Enabled = true;
                btnAuswahlLoeschen.Enabled = true;
            }

            if (listViewArtikel.SelectedItems.Count > 1)
            {
                btnAuswahlBearbeiten.Enabled = false;
                btnAuswahlLoeschen.Enabled = true;
            }

        }

        private void btnAuswahlBearbeiten_Click(object sender, EventArgs e)
        {
            FormNeuerArtikel frmNA = new FormNeuerArtikel();
            if (listViewArtikel.SelectedItems[0].Text.Contains(" - Gr. "))
            {
                string[] bezSplit = listViewArtikel.SelectedItems[0].Text.Split(new[] { " - Gr. " }, StringSplitOptions.None);
                frmNA.bezeichnung = bezSplit[0];
                frmNA.groesse = bezSplit[1];
                frmNA.groesseEnable = true;
            }
            else
            {
                frmNA.bezeichnung = listViewArtikel.SelectedItems[0].Text;
                frmNA.groesseEnable = false;
            }
            frmNA.menge = int.Parse(listViewArtikel.SelectedItems[0].SubItems[1].Text);
            frmNA.mwst = int.Parse(listViewArtikel.SelectedItems[0].SubItems[2].Text
                .Remove(listViewArtikel.SelectedItems[0].SubItems[2].Text.Length - 1));
            frmNA.preis = double.Parse(listViewArtikel.SelectedItems[0].SubItems[3].Text
                .Remove(listViewArtikel.SelectedItems[0].SubItems[3].Text.Length - 1));
            frmNA.edit = true;

            frmNA.ShowDialog();

            if (frmNA.DialogResult == DialogResult.OK)
            {
                if (frmNA.groesseEnable)
                {
                    listViewArtikel.SelectedItems[0].Text = frmNA.bezeichnung + " - Gr. " + frmNA.groesse;
                }
                else
                {
                    listViewArtikel.SelectedItems[0].Text = frmNA.bezeichnung;
                }
                listViewArtikel.SelectedItems[0].SubItems[1].Text = frmNA.menge.ToString();
                listViewArtikel.SelectedItems[0].SubItems[2].Text = frmNA.mwst.ToString() + "%";
                listViewArtikel.SelectedItems[0].SubItems[3].Text = "-" + frmNA.preis.ToString() + "€";
                listViewArtikel.SelectedItems[0].SubItems[4].Text = "-" + (frmNA.preis * frmNA.menge).ToString() + "€";
            }
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wirklich abbrechen?", "justforyou - Excel", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnAuswahlLoeschen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ausgewählte Artikel wirklich löschen?", "justforyou - Excel", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                foreach (ListViewItem lvi in listViewArtikel.SelectedItems)
                {
                    listViewArtikel.Items.Remove(lvi);
                }

        }

        private void txtVersand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar !=
                Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar ==
                Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                if ((sender as System.Windows.Forms.TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void BtnSpeichern_Click(object sender, EventArgs e)
        {
            SaveFileDialog o = new SaveFileDialog();
            string defaultDir = "C:";
            if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                      @"\Just\justforyou Excel\pathRechnungen.ini"))
            {
                defaultDir = System.IO.File.ReadAllText(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                    @"\Just\justforyou Excel\pathRechnungen.ini");
            }

            int month = dateTimeRechnungsdatum.Value.Date.Month;
            string yearTxt = dateTimeRechnungsdatum.Value.Date.Year.ToString().Substring(2, 2);
            string monthStr = month.ToString();
            if (month < 10)
            {
                monthStr = "0" + month;
            }

            if (System.IO.Directory.Exists(defaultDir + "20" + yearTxt + @"\" + monthStr + ".20" + yearTxt +
                                           @"\"))
            {
                defaultDir = defaultDir + "20" + yearTxt + @"\" + monthStr + ".20" + yearTxt +
                             @"\";
            }
            else
            {
                System.IO.Directory.CreateDirectory(defaultDir + "20" + yearTxt + @"\" + monthStr + ".20" + yearTxt +
                             @"\");
                defaultDir = defaultDir + "20" + yearTxt + @"\" + monthStr + ".20" + yearTxt +
                             @"\";
            }

            o.InitialDirectory = defaultDir;
            o.FileName = "R" + txtRechnungsnummer.Text + "_" + txtYear.Text;
            o.Filter = "PDF-Dateien (*.pdf)|*.pdf|Alle Dateien (*.*)|*.*";
            o.FilterIndex = 1;

            try
            {
                double txtRNr = Double.Parse(txtRechnungsnummer.Text);
                if (!System.IO.File.Exists(defaultDir + "R" + (txtRNr - 1).ToString() + "_" + txtYear.Text + ".pdf"))
                {
                    bool isEmpty = !System.IO.Directory.EnumerateFiles(defaultDir).Any();
                    if (!isEmpty)
                    {
                        //nur anzeigen wenn nicht die erste Rechnung im Monat
                        MessageBox.Show("Die vorherige Rechnung R" + (txtRNr - 1).ToString() + ".pdf existiert nicht in dem Monatsordner '" + monthStr + ".20" + yearTxt + "'." + Environment.NewLine + "Besteht ggf. eine Lücke? (Bitte ignorieren Sie die Meldung, falls die vorherige Rechnung eine Stornorechnung war)", "Rechnung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(FormatException)
            {

            }

            if (o.ShowDialog() == DialogResult.OK)
            {
                safePath = o.FileName;
                datenAusgeben();
                this.DialogResult = DialogResult.OK;
                result = 1;
                this.Close();
            }
        }

        private void btnOeffnen_Click(object sender, EventArgs e)
        {
            datenAusgeben();
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void cbEditYear_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEditYear.Checked)
                txtYear.Enabled = true;
            else
            {
                txtYear.Enabled = false;
            }
        }

        private void datenAusgeben()
        {
            bestellDatum = datetimeBestelldatum.Value;
            rechnungsDatum = dateTimeRechnungsdatum.Value;
            rechnungsNr = txtRechnungsnummer.Text + "_" + txtYear.Text;
            rechnungsNrShort = Convert.ToInt32(txtRechnungsnummer.Text);
            empfaenger = richtxtEmpfaenger.Text;
            versandkosten = txtVersand.Text;
            artikel = listViewArtikel;
        }

        private void listViewArtikel_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = sender as ListViewItem;
            if (listViewArtikel.SelectedItems.Count == 1)
            {
                btnAuswahlBearbeiten.PerformClick();
            }
        }

        private void btnSaveAndPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog o = new SaveFileDialog();
            string defaultDir = "C:";
            if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                      @"\Just\justforyou Excel\pathRechnungen.ini"))
            {
                defaultDir = System.IO.File.ReadAllText(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                    @"\Just\justforyou Excel\pathRechnungen.ini");
            }

            int month = dateTimeRechnungsdatum.Value.Date.Month;
            string yearTxt = dateTimeRechnungsdatum.Value.Date.Year.ToString().Substring(2, 2);
            string monthStr = month.ToString();
            if (month < 10)
            {
                monthStr = "0" + month;
            }

            if (System.IO.Directory.Exists(defaultDir + "20" + yearTxt + @"\" + monthStr + ".20" + yearTxt +
                                           @"\"))
            {
                defaultDir = defaultDir + "20" + yearTxt + @"\" + monthStr + ".20" + yearTxt +
                             @"\";
            }
            else
            {
                System.IO.Directory.CreateDirectory(defaultDir + "20" + yearTxt + @"\" + monthStr + ".20" + yearTxt +
                             @"\");
                defaultDir = defaultDir + "20" + yearTxt + @"\" + monthStr + ".20" + yearTxt +
                             @"\";
            }

            o.InitialDirectory = defaultDir;
            o.FileName = "R" + txtRechnungsnummer.Text + "_" + txtYear.Text;
            o.Filter = "PDF-Dateien (*.pdf)|*.pdf|Alle Dateien (*.*)|*.*";
            o.FilterIndex = 1;

            try
            {
                double txtRNr = Double.Parse(txtRechnungsnummer.Text);
                if (!System.IO.File.Exists(defaultDir + "R" + (txtRNr - 1).ToString() + "_" + txtYear.Text + ".pdf"))
                {
                    bool isEmpty = !System.IO.Directory.EnumerateFiles(defaultDir).Any();
                    if (!isEmpty)
                    {
                        //nur anzeigen wenn nicht die erste Rechnung im Monat
                        MessageBox.Show("Die vorherige Rechnung R" + (txtRNr - 1).ToString() + ".pdf existiert nicht in dem Monatsordner '" + monthStr + ".20" + yearTxt + "'." + Environment.NewLine + "Besteht ggf. eine Lücke? (Bitte ignorieren Sie die Meldung, falls die vorherige Rechnung eine Stornorechnung war)", "Rechnung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (FormatException)
            {

            }

            if (o.ShowDialog() == DialogResult.OK)
            {
                safePath = o.FileName;
                datenAusgeben();
                this.DialogResult = DialogResult.OK;
                result = 2;
                this.Close();
            }
        }

        private void radio0Versand_CheckedChanged(object sender, EventArgs e)
        {
            if (radio0Versand.Checked)
                txtVersand.Text = "0,00";
        }
    }
}
