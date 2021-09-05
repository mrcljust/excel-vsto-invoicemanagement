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
    public partial class FormEinstellungen : Form
    {
        public FormEinstellungen()
        {
            InitializeComponent();
        }

        private void FormEinstellungen_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                      @"\Just\justforyou Excel\path.ini"))
            {
                txtDateipfadVorlage.Text = System.IO.File.ReadAllText(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Just\justforyou Excel\path.ini");

            }

            if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                      @"\Just\justforyou Excel\month.ini"))
            {
                txtMonatvorlage.Text = System.IO.File.ReadAllText(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Just\justforyou Excel\month.ini");

            }

            if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                      @"\Just\justforyou Excel\monthdir.ini"))
            {
                txtMonatOrdner.Text = System.IO.File.ReadAllText(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Just\justforyou Excel\monthdir.ini");

            }

            if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                      @"\Just\justforyou Excel\next.ini"))
            {
                txtRechnungsnummer.Text = System.IO.File.ReadAllText(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Just\justforyou Excel\next.ini");

            }

            if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                      @"\Just\justforyou Excel\pathRechnungen.ini"))
            {
                txtOrdnerRechnungen.Text = System.IO.File.ReadAllText(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                    @"\Just\justforyou Excel\pathRechnungen.ini");
            }

            if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                      @"\Just\justforyou Excel\mwst.ini"))
            {
                numerMwst.Text = System.IO.File.ReadAllText(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                    @"\Just\justforyou Excel\mwst.ini");
            }
        }

        private void BtnSpeichern_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Just\justforyou Excel\next.ini", txtRechnungsnummer.Text);
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Just\justforyou Excel\path.ini", txtDateipfadVorlage.Text);
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Just\justforyou Excel\pathRechnungen.ini", txtOrdnerRechnungen.Text);
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Just\justforyou Excel\mwst.ini", numerMwst.Text);
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Just\justforyou Excel\monthdir.ini", txtMonatOrdner.Text);
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Just\justforyou Excel\month.ini", txtMonatvorlage.Text);
            //Globals.ExcelAddIn.Application.DefaultFilePath = txtOrdnerRechnungen.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.InitialDirectory = "C:";
            if (o.ShowDialog() == DialogResult.OK)
            {
                txtDateipfadVorlage.Text = o.FileName;
            }
        }

        private void btnSelectPathOrdnerRechnungen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog o = new FolderBrowserDialog();
            o.SelectedPath = "C:";
            if (o.ShowDialog() == DialogResult.OK)
            {
                txtOrdnerRechnungen.Text = o.SelectedPath + @"\";
            }
        }

        private void btnMonatvorlage_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.InitialDirectory = "C:";
            if (o.ShowDialog() == DialogResult.OK)
            {
                txtMonatvorlage.Text = o.FileName;
            }
        }

        private void btnMonatOrdner_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog o = new FolderBrowserDialog();
            o.SelectedPath = "C:";
            if (o.ShowDialog() == DialogResult.OK)
            {
                txtMonatOrdner.Text = o.SelectedPath + @"\";
            }
        }
    }
}
