using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Ribbon;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace justforyou_Excel
{
    public partial class RibbonJustforyou
    {
        private string _pathVorlage;

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnEinstellungen_Click(object sender, RibbonControlEventArgs e)
        {
            FormEinstellungen frmE = new FormEinstellungen();
            frmE.ShowDialog();
        }

        private void btnNeueRechnung_Click(object sender, RibbonControlEventArgs e)
        {
            string warenwert;
            string versand;
            string summebrutto;
            string mwstsatz = "19%";
            string mwst;
            string summenetto;

            FormNeueRechnung frmNR = new FormNeueRechnung();
            frmNR.ShowDialog();
            if (frmNR.DialogResult == DialogResult.OK || frmNR.DialogResult == DialogResult.Yes)
            {
                string nextRechnungsNr = System.IO.File.ReadAllText(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                    @"\Just\justforyou Excel\next.ini");
                if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                          @"\Just\justforyou Excel\path.ini"))
                {
                    _pathVorlage = System.IO.File.ReadAllText(
                        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                        @"\Just\justforyou Excel\path.ini");
                }

                if (_pathVorlage != null)
                {
                    Workbook wb = Globals.ExcelAddIn.Application.Workbooks.Open(_pathVorlage);
                    Worksheet excelWorksheet = wb.Worksheets[1];
                    excelWorksheet.Range["E7"].Value = frmNR.bestellDatum.Date.ToString("dd.MM.yyyy");
                    excelWorksheet.Range["E7"].Cells.HorizontalAlignment =
                        Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    excelWorksheet.Range["E8"].Value = "R" + frmNR.rechnungsNr;
                    excelWorksheet.Range["E8"].Cells.HorizontalAlignment =
                        Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    excelWorksheet.Range["E9"].Value = frmNR.rechnungsDatum.Date.ToString("dd.MM.yyyy");
                    excelWorksheet.Range["E10"].Value = frmNR.rechnungsDatum.Date.ToString("dd.MM.yyyy");
                    excelWorksheet.Range["E13"].Value = frmNR.rechnungsDatum.Date.ToString("dd.MM.yyyy");
                    excelWorksheet.Range["E9"].Cells.HorizontalAlignment =
                        Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    excelWorksheet.Range["E10"].Cells.HorizontalAlignment =
                        Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    excelWorksheet.Range["E13"].Cells.HorizontalAlignment =
                        Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    excelWorksheet.Range["A9"].Value = frmNR.empfaenger;

                    if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                              @"\Just\justforyou Excel\mwst.ini"))
                    {
                        string mwsts = System.IO.File.ReadAllText(
                            Environment.GetFolderPath(Environment.SpecialFolder
                                .ApplicationData) +
                            @"\Just\justforyou Excel\mwst.ini");
                        excelWorksheet.Range["B31"].Value = "inkl. " + mwsts + "% MwSt.";
                        excelWorksheet.Range["E31"].Value = "=E30/1" + mwsts + "*" + mwsts;
                    }
                    excelWorksheet.Range["E29"].Value = Convert.ToDecimal(frmNR.versandkosten);
                    excelWorksheet.Range["E29"].Cells.NumberFormat = "0.00 €";

                    int rowToCopy = 28;
                    for (int i = 0; i < frmNR.artikel.Items.Count; i++)
                    {
                        if (i > 6)
                        {
                            int row1 = 28 + (i - 7);
                            rowToCopy = 28 + (i - 7);
                            int row2 = 26 + (i - 6);
                            Range a1 = excelWorksheet.get_Range("A" + row1, "E" + row1);
                            a1.EntireRow.Insert(XlInsertShiftDirection.xlShiftDown);
                            excelWorksheet.Range["E" + (row1 + 1)].FormulaLocal = "=SUMME(E20:E" + row2 + ")";
                        }

                        int row = 20 + i;
                        excelWorksheet.Range["A" + row].Value = frmNR.artikel.Items[i].Text;
                        excelWorksheet.Range["B" + row].Value = frmNR.artikel.Items[i].SubItems[1].Text;
                        excelWorksheet.Range["C" + row].Value = frmNR.artikel.Items[i].SubItems[2].Text;
                        excelWorksheet.Range["D" + row].Value = Convert.ToDecimal(frmNR.artikel.Items[i].SubItems[3]
                            .Text.Substring(0, frmNR.artikel.Items[i].SubItems[3].Text.Length - 1));
                        excelWorksheet.Range["E" + row].Formula = "=B" + row + "*D" + row;
                        excelWorksheet.Range["E" + row].FormulaLocal = "=B" + row + "*D" + row;
                    }

                    warenwert = excelWorksheet.Range["E" + rowToCopy].Text;
                    versand = excelWorksheet.Range["E" + (rowToCopy + 1)].Text;
                    summebrutto = excelWorksheet.Range["E" + (rowToCopy + 2)].Text;
                    mwst = excelWorksheet.Range["E" + (rowToCopy + 3)].Text;
                    summenetto = excelWorksheet.Range["E" + (rowToCopy + 4)].Text;

                    if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                              @"\Just\justforyou Excel\mwst.ini"))
                    {
                        string mwsts = System.IO.File.ReadAllText(
                            Environment.GetFolderPath(Environment.SpecialFolder
                                .ApplicationData) +
                            @"\Just\justforyou Excel\mwst.ini");
                        mwstsatz = mwsts + "%";
                    }
                    Boolean save = false;

                    if (frmNR.DialogResult == DialogResult.OK && frmNR.result == 1)
                    {
                        //speichern
                        excelWorksheet.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, frmNR.safePath);
                        wb.Close(false);
                        save = true;
                    }

                    if (frmNR.DialogResult == DialogResult.OK && frmNR.result == 2)
                    {
                        //speichern
                        excelWorksheet.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, frmNR.safePath);
                        //drucken
                        excelWorksheet.PrintOut();
                        wb.Close(false);
                        save = true;
                    }

                    if (frmNR.DialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show("Die Rechnung wird, da sie in Excel geöffnet wird, nicht automatisch in die Monatsübersicht übertragen." + Environment.NewLine + "Zum Speichern bitte in .pdf exportieren und anschließend manuell in die Monatsübersicht einfügen", "Neue Rechnung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //Rechnungsnr hochzaehlen, falls angegebene Rechnungsnr = nächste ist
                    if (frmNR.rechnungsNrShort == Convert.ToInt32(nextRechnungsNr))
                    {
                        //nur wenn gespeichert oder gespeichert und gedruckt
                        if(save)
                        {
                            System.IO.File.WriteAllText(
                            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                            @"\Just\justforyou Excel\next.ini", (frmNR.rechnungsNrShort + 1).ToString());

                            //Zu Datei Monatsübersicht hinzufügen & speichern
                            int month = frmNR.rechnungsDatum.Date.Month;
                            string yearTxt = frmNR.rechnungsDatum.Date.Year.ToString().Substring(2, 2);
                            string monthStr = month.ToString();
                            bool doSave = false;
                            if (month < 10)
                            {
                                monthStr = "0" + month;
                            }

                            string defaultDir2 = "C:";
                            if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Just\justforyou Excel\monthdir.ini"))
                            {
                                defaultDir2 = System.IO.File.ReadAllText(
                                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                    @"\Just\justforyou Excel\monthdir.ini");

                                doSave = true;
                            }

                            if (doSave)
                            {
                                bool error = false;
                                if (!System.IO.File.Exists(defaultDir2 + "Monatsübersicht_" + monthStr + "_" +
                                                           frmNR.rechnungsDatum.Date.Year.ToString() + ".xlsx"))
                                {
                                    if (System.IO.File.Exists(
                                        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                        @"\Just\justforyou Excel\month.ini"))
                                    {
                                        string monthdefaultFile = System.IO.File.ReadAllText(
                                            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                            @"\Just\justforyou Excel\month.ini");
                                        System.IO.File.Copy(monthdefaultFile, defaultDir2 + "Monatsübersicht_" + monthStr + "_" +
                                                                              frmNR.rechnungsDatum.Date.Year.ToString() + ".xlsx");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Konnte Monatsübersicht nicht editieren - Fehler 001", "Fehler 001",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        error = true;
                                    }
                                }

                                if (!error)
                                {
                                    Workbook wb2 = Globals.ExcelAddIn.Application.Workbooks.Open(defaultDir2 + "Monatsübersicht_" + monthStr + "_" +
                                                                                                 frmNR.rechnungsDatum.Date.Year.ToString() + ".xlsx");
                                    Worksheet excelWorksheet2 = wb2.Worksheets[1];
                                    excelWorksheet2.Range["A1"].Value =
                                        "justforyou Zusammenfassung - " + monthStr + "_" +
                                        frmNR.rechnungsDatum.Date.Year.ToString();
                                    string naechsteZeile = excelWorksheet2.Range["K4"].Text.ToString();
                                    double naechsteZeileInt = excelWorksheet2.Range["K4"].Value;
                                    excelWorksheet2.Range["A" + naechsteZeile].Value = "R" + frmNR.rechnungsNr;
                                    excelWorksheet2.Range["B" + naechsteZeile].Value = frmNR.rechnungsDatum.Date.ToString(("dd.MM.yyyy"));
                                    excelWorksheet2.Range["C" + naechsteZeile].Value = Convert.ToDecimal(warenwert.Substring(0, warenwert.Length - 2));
                                    excelWorksheet2.Range["D" + naechsteZeile].Value = Convert.ToDecimal(versand.Substring(0, versand.Length - 2));
                                    excelWorksheet2.Range["E" + naechsteZeile].Value = mwstsatz;
                                    excelWorksheet2.Range["F" + naechsteZeile].Value = Convert.ToDecimal(mwst.Substring(0, mwst.Length - 2));
                                    excelWorksheet2.Range["G" + naechsteZeile].Value = Convert.ToDecimal(summebrutto.Substring(0, summebrutto.Length - 2));
                                    excelWorksheet2.Range["H" + naechsteZeile].Value = Convert.ToDecimal(summenetto.Substring(0, summenetto.Length - 2));


                                    /*excelWorksheet.Range["C" + naechsteZeile].Cells.NumberFormat = "0.00 €";
                                    excelWorksheet.Range["D" + naechsteZeile].Cells.NumberFormat = "0.00 €";
                                    excelWorksheet.Range["F" + naechsteZeile].Cells.NumberFormat = "0.00 €";
                                    excelWorksheet.Range["G" + naechsteZeile].Cells.NumberFormat = "0.00 €";
                                    excelWorksheet.Range["H" + naechsteZeile].Cells.NumberFormat = "0.00 €";*/

                                    //nächste zeile hochzählen
                                    excelWorksheet2.Range["K4"].Value = naechsteZeileInt + 1;
                                    //dokument speichern

                                    wb2.Save();
                                    wb2.Close(false);
                                }
                            }
                            save = false;
                        }
                    }
                    else
                    {
                        //Rechnungsnr ist nicht naechste = Rechnung editiert
                        //Zu Datei Monatsübersicht hinzufügen & speichern
                        //nur wenn gespeichert oder gespeichert und gedruckt
                        if (save)
                        {
                            int month = frmNR.rechnungsDatum.Date.Month;
                            string yearTxt = frmNR.rechnungsDatum.Date.Year.ToString().Substring(2, 2);
                            string monthStr = month.ToString();
                            bool doSave = false;
                            if (month < 10)
                            {
                                monthStr = "0" + month;
                            }

                            string defaultDir2 = "C:";
                            if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Just\justforyou Excel\monthdir.ini"))
                            {
                                defaultDir2 = System.IO.File.ReadAllText(
                                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                    @"\Just\justforyou Excel\monthdir.ini");

                                doSave = true;
                            }

                            if (doSave)
                            {
                                bool error = false;
                                if (!System.IO.File.Exists(defaultDir2 + "Monatsübersicht_" + monthStr + "_" +
                                                           frmNR.rechnungsDatum.Date.Year.ToString() + ".xlsx"))
                                {
                                    if (System.IO.File.Exists(
                                        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                        @"\Just\justforyou Excel\month.ini"))
                                    {
                                        string monthdefaultFile = System.IO.File.ReadAllText(
                                            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                            @"\Just\justforyou Excel\month.ini");
                                        System.IO.File.Copy(monthdefaultFile, defaultDir2 + "Monatsübersicht_" + monthStr + "_" +
                                                                              frmNR.rechnungsDatum.Date.Year.ToString() + ".xlsx");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Konnte Monatsübersicht nicht editieren - Fehler 001", "Fehler 001",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        error = true;
                                    }
                                }

                                if (!error)
                                {
                                    Workbook wb2 = Globals.ExcelAddIn.Application.Workbooks.Open(defaultDir2 + "Monatsübersicht_" + monthStr + "_" +
                                                                                                 frmNR.rechnungsDatum.Date.Year.ToString() + ".xlsx");
                                    Worksheet excelWorksheet2 = wb2.Worksheets[1];
                                    excelWorksheet2.Range["A1"].Value =
                                        "justforyou Zusammenfassung - " + monthStr + "_" +
                                        frmNR.rechnungsDatum.Date.Year.ToString();
                                    //string naechsteZeile = excelWorksheet2.Range["K4"].Text.ToString();
                                    Range currentFind = excelWorksheet2.Columns["A:A"].Find("R" + frmNR.rechnungsNr);
                                    Range currentFindStorno = excelWorksheet2.Columns["A:A"].Find("R" + frmNR.rechnungsNr + "_STORNO");


                                    if(currentFindStorno==null)
                                    {
                                        if (currentFind != null)
                                        {
                                            string naechsteZeile = currentFind.Row.ToString();
                                            excelWorksheet2.Range["A" + naechsteZeile].Value = "R" + frmNR.rechnungsNr;
                                            excelWorksheet2.Range["B" + naechsteZeile].Value = frmNR.rechnungsDatum.Date.ToString(("dd.MM.yyyy"));
                                            excelWorksheet2.Range["C" + naechsteZeile].Value = Convert.ToDecimal(warenwert.Substring(0, warenwert.Length - 2));
                                            excelWorksheet2.Range["D" + naechsteZeile].Value = Convert.ToDecimal(versand.Substring(0, versand.Length - 2));
                                            excelWorksheet2.Range["E" + naechsteZeile].Value = mwstsatz;
                                            excelWorksheet2.Range["F" + naechsteZeile].Value = Convert.ToDecimal(mwst.Substring(0, mwst.Length - 2));
                                            excelWorksheet2.Range["G" + naechsteZeile].Value = Convert.ToDecimal(summebrutto.Substring(0, summebrutto.Length - 2));
                                            excelWorksheet2.Range["H" + naechsteZeile].Value = Convert.ToDecimal(summenetto.Substring(0, summenetto.Length - 2));
                                        }
                                        else
                                        {
                                            MessageBox.Show("Sie haben eine alternative Rechnungsnummer angegeben, der Eintrag wurde in der Monatsübersicht allerdings nicht gefunden, daher wurde die Rechnung R" + frmNR.rechnungsNr + " nicht in der Monatsübersicht aktualisiert. Besteht ggf. eine Lücke?", "Monatsübersicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Die Rechnung R" + frmNR.rechnungsNr + " ist in der Monatsübersicht bereits als Stornorechnung vorhanden und wird nicht automatisch in der Monatsübersicht aktualisiert.", "Monatsübersicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }



                                    /*excelWorksheet.Range["C" + naechsteZeile].Cells.NumberFormat = "0.00 €";
                                    excelWorksheet.Range["D" + naechsteZeile].Cells.NumberFormat = "0.00 €";
                                    excelWorksheet.Range["F" + naechsteZeile].Cells.NumberFormat = "0.00 €";
                                    excelWorksheet.Range["G" + naechsteZeile].Cells.NumberFormat = "0.00 €";
                                    excelWorksheet.Range["H" + naechsteZeile].Cells.NumberFormat = "0.00 €";*/

                                    //nächste zeile nicht hochzählen
                                    //excelWorksheet2.Range["K4"].Value = naechsteZeileInt + 1;
                                    //dokument speichern

                                    wb2.Save();
                                    wb2.Close(false);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bitte den Vorlagenpfad in den Einstellungen festlegen", "justforyou - Excel");
                }
            }
        }

        private void RibbonJustforyou_Load(object sender, RibbonUIEventArgs e)
        {
            if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                      @"\Just\justforyou Excel\path.ini"))
            {
                _pathVorlage = System.IO.File.ReadAllText(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                    @"\Just\justforyou Excel\path.ini");
            }
            else
            {
                FormEinstellungen frmE = new FormEinstellungen();
                MessageBox.Show("Bitte den Vorlagenpfad in den Einstellungen festlegen", "justforyou - Excel");
                frmE.ShowDialog();
            }
        }

        private void btnRechnungBlank_Click(object sender, RibbonControlEventArgs e)
        {
            if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                      @"\Just\justforyou Excel\path.ini"))
            {
                _pathVorlage = System.IO.File.ReadAllText(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                    @"\Just\justforyou Excel\path.ini");
            }

            if (_pathVorlage != null)
            {
                Workbook wb = Globals.ExcelAddIn.Application.Workbooks.Open(_pathVorlage);
                Worksheet excelWorksheet = wb.Worksheets[1];
                if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                          @"\Just\justforyou Excel\mwst.ini"))
                {
                    string mwsts = System.IO.File.ReadAllText(
                        Environment.GetFolderPath(Environment.SpecialFolder
                            .ApplicationData) +
                        @"\Just\justforyou Excel\mwst.ini");
                    excelWorksheet.Range["B31"].Value = "inkl. " + mwsts + "% MwSt.";
                    excelWorksheet.Range["E31"].Value = "=E30/1" + mwsts + "*" + mwsts;
                }
                MessageBox.Show("Blanko-Rechnungen werden nach dem Speichern nicht automatisch in die Monatsübersicht übertragen.", "Blanko-Rechnung", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bitte den Vorlagenpfad in den Einstellungen festlegen", "justforyou - Excel");
            }
        }

        private void btnDrucken_Click(object sender, RibbonControlEventArgs e)
        {
            Workbook wb = Globals.ExcelAddIn.Application.ActiveWorkbook;
            Worksheet excelWorksheet = wb.ActiveSheet;
            excelWorksheet.PrintOut();
        }

        private void btnSpeichern_Click(object sender, RibbonControlEventArgs e)
        {
            Workbook wb = Globals.ExcelAddIn.Application.ActiveWorkbook;
            Worksheet excelWorksheet = wb.ActiveSheet;
            SaveFileDialog o = new SaveFileDialog();
            string defaultDir = "C:";
            if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                      @"\Just\justforyou Excel\pathRechnungen.ini"))
            {
                defaultDir = System.IO.File.ReadAllText(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                    @"\Just\justforyou Excel\pathRechnungen.ini");
            }

            o.InitialDirectory = defaultDir;
            string e8Value = excelWorksheet.Range["E8"].get_Value();
            if (e8Value != null && e8Value.StartsWith("R") && e8Value.Contains("_"))
            {
                o.FileName = excelWorksheet.Range["E8"].get_Value();
            }
            o.Filter = "PDF-Dateien (*.pdf)|*.pdf|Alle Dateien (*.*)|*.*";
            o.FilterIndex = 1;
            if (o.ShowDialog() == DialogResult.OK)
            {
                excelWorksheet.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, o.FileName);
            }
        }

        private void btnStornoRechnung_Click(object sender, RibbonControlEventArgs e)
        {
            string warenwert;
            string versand;
            string summebrutto;
            string mwstsatz = "19%";
            string mwst;
            string summenetto;
            FormNeueStornoRechnung frmNR = new FormNeueStornoRechnung();
            frmNR.ShowDialog();
            if (frmNR.DialogResult == DialogResult.OK || frmNR.DialogResult == DialogResult.Yes)
            {
                string nextRechnungsNr = System.IO.File.ReadAllText(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                    @"\Just\justforyou Excel\next.ini");
                if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                          @"\Just\justforyou Excel\path.ini"))
                {
                    _pathVorlage = System.IO.File.ReadAllText(
                        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                        @"\Just\justforyou Excel\path.ini");
                }

                if (_pathVorlage != null)
                {
                    Workbook wb = Globals.ExcelAddIn.Application.Workbooks.Open(_pathVorlage);
                    Worksheet excelWorksheet = wb.Worksheets[1];
                    excelWorksheet.Range["E7"].Value = frmNR.bestellDatum.Date.ToString("dd.MM.yyyy");
                    excelWorksheet.Range["E7"].Cells.HorizontalAlignment =
                        Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    excelWorksheet.Range["E8"].Value = "R" + frmNR.rechnungsNr + "_STORNO";
                    excelWorksheet.Range["E8"].Cells.HorizontalAlignment =
                        Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    excelWorksheet.Range["E9"].Value = frmNR.rechnungsDatum.Date.ToString("dd.MM.yyyy");
                    excelWorksheet.Range["E10"].Value = frmNR.rechnungsDatumUrsprung.Date.ToString("dd.MM.yyyy");
                    excelWorksheet.Range["E13"].Value = frmNR.rechnungsDatum.Date.ToString("dd.MM.yyyy");
                    excelWorksheet.Range["E9"].Cells.HorizontalAlignment =
                        Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    excelWorksheet.Range["E10"].Cells.HorizontalAlignment =
                        Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    excelWorksheet.Range["E13"].Cells.HorizontalAlignment =
                        Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    excelWorksheet.Range["A9"].Value = frmNR.empfaenger;
                    excelWorksheet.Range["A16"].Value = "Ihre Stornorechnung zur Rechnungsnummer R" + frmNR.rechnungsNrUrsprung + " vom " + frmNR.rechnungsDatumUrsprung.Date.ToString("dd.MM.yyyy");
                    excelWorksheet.Range["A34"].Value = "";
                    excelWorksheet.Range["A36"].Value = "";

                    if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                              @"\Just\justforyou Excel\mwst.ini"))
                    {
                        string mwsts = System.IO.File.ReadAllText(
                            Environment.GetFolderPath(Environment.SpecialFolder
                                .ApplicationData) +
                            @"\Just\justforyou Excel\mwst.ini");
                        excelWorksheet.Range["B31"].Value = "inkl. " + mwsts + "% MwSt.";
                        excelWorksheet.Range["E31"].Value = "=E30/1" + mwsts + "*" + mwsts;
                    }

                    excelWorksheet.Range["E29"].Value = Convert.ToDecimal(frmNR.versandkosten);
                    excelWorksheet.Range["E29"].Cells.NumberFormat = "0.00 €";

                    int rowToCopy = 28;
                    for (int i = 0; i < frmNR.artikel.Items.Count; i++)
                    {
                        if (i > 6)
                        {
                            int row1 = 28 + (i - 7);
                            rowToCopy = 28 + (i - 7);
                            int row2 = 26 + (i - 6);
                            Range a1 = excelWorksheet.get_Range("A" + row1, "E" + row1);
                            a1.EntireRow.Insert(XlInsertShiftDirection.xlShiftDown);
                            excelWorksheet.Range["E" + (row1 + 1)].FormulaLocal = "=SUMME(E20:E" + row2 + ")";
                        }

                        int row = 20 + i;
                        excelWorksheet.Range["A" + row].Value = frmNR.artikel.Items[i].Text;
                        excelWorksheet.Range["B" + row].Value = frmNR.artikel.Items[i].SubItems[1].Text;
                        excelWorksheet.Range["C" + row].Value = frmNR.artikel.Items[i].SubItems[2].Text;
                        excelWorksheet.Range["D" + row].Value = Convert.ToDecimal(frmNR.artikel.Items[i].SubItems[3]
                            .Text.Substring(0, frmNR.artikel.Items[i].SubItems[3].Text.Length - 1));
                        excelWorksheet.Range["E" + row].Formula = "=B" + row + "*D" + row;
                        excelWorksheet.Range["E" + row].FormulaLocal = "=B" + row + "*D" + row;
                    }

                    warenwert = excelWorksheet.Range["E" + rowToCopy].Text;
                    versand = excelWorksheet.Range["E" + (rowToCopy+1)].Text;
                    summebrutto = excelWorksheet.Range["E" + (rowToCopy + 2)].Text;
                    mwst = excelWorksheet.Range["E" + (rowToCopy + 3)].Text;
                    summenetto = excelWorksheet.Range["E" + (rowToCopy + 4)].Text;

                    if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                              @"\Just\justforyou Excel\mwst.ini"))
                    {
                        string mwsts = System.IO.File.ReadAllText(
                            Environment.GetFolderPath(Environment.SpecialFolder
                                .ApplicationData) +
                            @"\Just\justforyou Excel\mwst.ini");
                        mwstsatz = mwsts + "%";
                    }

                    Boolean save = false;

                    if (frmNR.DialogResult == DialogResult.OK && frmNR.result == 1)
                    {
                        //speichern
                        excelWorksheet.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, frmNR.safePath);
                        wb.Close(false);
                        save = true;
                    }

                    if (frmNR.DialogResult == DialogResult.OK && frmNR.result == 2)
                    {
                        //speichern
                        excelWorksheet.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, frmNR.safePath);
                        //drucken
                        excelWorksheet.PrintOut();
                        wb.Close(false);
                        save = true;
                    }

                    if (frmNR.DialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show("Die Rechnung wird, da sie in Excel geöffnet wird, nicht automatisch in die Monatsübersicht übertragen." + Environment.NewLine + "Zum Speichern bitte in .pdf exportieren und anschließend manuell in die Monatsübersicht einfügen", "Neue Rechnung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //Rechnungsnr hochzaehlen, falls angegebene Rechnungsnr = nächste ist
                    if (frmNR.rechnungsNrShort == Convert.ToInt32(nextRechnungsNr))
                    {
                        //nur wenn speichern oder speichern und drucken
                        if(save)
                        {
                            System.IO.File.WriteAllText(
                            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                            @"\Just\justforyou Excel\next.ini", (frmNR.rechnungsNrShort + 1).ToString());

                            //Zu Datei Monatsübersicht hinzufügen & speichern
                            int month = frmNR.rechnungsDatum.Date.Month;
                            string yearTxt = frmNR.rechnungsDatum.Date.Year.ToString().Substring(2, 2);
                            string monthStr = month.ToString();
                            bool doSave = false;
                            if (month < 10)
                            {
                                monthStr = "0" + month;
                            }

                            string defaultDir2 = "C:";
                            if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Just\justforyou Excel\monthdir.ini"))
                            {
                                defaultDir2 = System.IO.File.ReadAllText(
                                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                    @"\Just\justforyou Excel\monthdir.ini");

                                doSave = true;
                            }

                            if (doSave)
                            {
                                bool error = false;
                                if (!System.IO.File.Exists(defaultDir2 + "Monatsübersicht_" + monthStr + "_" +
                                                           frmNR.rechnungsDatum.Date.Year.ToString() + ".xlsx"))
                                {
                                    if (System.IO.File.Exists(
                                        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                        @"\Just\justforyou Excel\month.ini"))
                                    {
                                        string monthdefaultFile = System.IO.File.ReadAllText(
                                            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                            @"\Just\justforyou Excel\month.ini");
                                        System.IO.File.Copy(monthdefaultFile, defaultDir2 + "Monatsübersicht_" + monthStr + "_" +
                                                                              frmNR.rechnungsDatum.Date.Year.ToString() + ".xlsx");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Konnte Monatsübersicht nicht editieren - Fehler 001", "Fehler 001",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        error = true;
                                    }
                                }

                                if (!error)
                                {
                                    Workbook wb2 = Globals.ExcelAddIn.Application.Workbooks.Open(defaultDir2 + "Monatsübersicht_" + monthStr + "_" +
                                                                                                 frmNR.rechnungsDatum.Date.Year.ToString() + ".xlsx");
                                    Worksheet excelWorksheet2 = wb2.Worksheets[1];
                                    excelWorksheet2.Range["A1"].Value =
                                        "justforyou Zusammenfassung - " + monthStr + "_" +
                                        frmNR.rechnungsDatum.Date.Year.ToString();
                                    string naechsteZeile = excelWorksheet2.Range["K4"].Text.ToString();
                                    double naechsteZeileInt = excelWorksheet2.Range["K4"].Value;
                                    excelWorksheet2.Range["A" + naechsteZeile].Value = "R" + frmNR.rechnungsNr + "_STORNO";
                                    excelWorksheet2.Range["B" + naechsteZeile].Value = frmNR.rechnungsDatum.Date.ToString(("dd.MM.yyyy"));
                                    excelWorksheet2.Range["C" + naechsteZeile].Value = Convert.ToDecimal(warenwert.Substring(0, warenwert.Length - 2));
                                    excelWorksheet2.Range["D" + naechsteZeile].Value = Convert.ToDecimal(versand.Substring(0, versand.Length - 2));
                                    excelWorksheet2.Range["E" + naechsteZeile].Value = mwstsatz;
                                    excelWorksheet2.Range["F" + naechsteZeile].Value = Convert.ToDecimal(mwst.Substring(0, mwst.Length - 2));
                                    excelWorksheet2.Range["G" + naechsteZeile].Value = Convert.ToDecimal(summebrutto.Substring(0, summebrutto.Length - 2));
                                    excelWorksheet2.Range["H" + naechsteZeile].Value = Convert.ToDecimal(summenetto.Substring(0, summenetto.Length - 2));



                                    /*excelWorksheet.Range["C" + naechsteZeile].Cells.NumberFormat = "0.00 €";
                                    excelWorksheet.Range["D" + naechsteZeile].Cells.NumberFormat = "0.00 €";
                                    excelWorksheet.Range["F" + naechsteZeile].Cells.NumberFormat = "0.00 €";
                                    excelWorksheet.Range["G" + naechsteZeile].Cells.NumberFormat = "0.00 €";
                                    excelWorksheet.Range["H" + naechsteZeile].Cells.NumberFormat = "0.00 €";*/

                                    //nächste zeile hochzählen
                                    excelWorksheet2.Range["K4"].Value = naechsteZeileInt + 1;
                                    //dokument speichern
                                    wb2.Save();
                                    wb2.Close(false);
                                }
                            }

                            save = false;
                        }
                    }
                    else
                    {
                        //Rechnungsnr ist nicht naechste = Rechnung editiert
                        //Zu Datei Monatsübersicht hinzufügen & speichern
                        //nur wenn speichern oder speichern & drucken

                        if(save)
                        {
                            int month = frmNR.rechnungsDatum.Date.Month;
                            string yearTxt = frmNR.rechnungsDatum.Date.Year.ToString().Substring(2, 2);
                            string monthStr = month.ToString();
                            bool doSave = false;
                            if (month < 10)
                            {
                                monthStr = "0" + month;
                            }

                            string defaultDir2 = "C:";
                            if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Just\justforyou Excel\monthdir.ini"))
                            {
                                defaultDir2 = System.IO.File.ReadAllText(
                                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                    @"\Just\justforyou Excel\monthdir.ini");

                                doSave = true;
                            }

                            if (doSave)
                            {
                                bool error = false;
                                if (!System.IO.File.Exists(defaultDir2 + "Monatsübersicht_" + monthStr + "_" +
                                                           frmNR.rechnungsDatum.Date.Year.ToString() + ".xlsx"))
                                {
                                    if (System.IO.File.Exists(
                                        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                        @"\Just\justforyou Excel\month.ini"))
                                    {
                                        string monthdefaultFile = System.IO.File.ReadAllText(
                                            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                            @"\Just\justforyou Excel\month.ini");
                                        System.IO.File.Copy(monthdefaultFile, defaultDir2 + "Monatsübersicht_" + monthStr + "_" +
                                                                              frmNR.rechnungsDatum.Date.Year.ToString() + ".xlsx");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Konnte Monatsübersicht nicht editieren - Fehler 001", "Fehler 001",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        error = true;
                                    }
                                }

                                if (!error)
                                {
                                    Workbook wb2 = Globals.ExcelAddIn.Application.Workbooks.Open(defaultDir2 + "Monatsübersicht_" + monthStr + "_" +
                                                                                                 frmNR.rechnungsDatum.Date.Year.ToString() + ".xlsx");
                                    Worksheet excelWorksheet2 = wb2.Worksheets[1];
                                    excelWorksheet2.Range["A1"].Value =
                                        "justforyou Zusammenfassung - " + monthStr + "_" +
                                        frmNR.rechnungsDatum.Date.Year.ToString();
                                    //string naechsteZeile = excelWorksheet2.Range["K4"].Text.ToString();
                                    Range currentFind = excelWorksheet2.Columns["A:A"].Find("R" + frmNR.rechnungsNr + "_STORNO");
                                    Range currentFindNonStorno = excelWorksheet2.Columns["A:A"].Find("R" + frmNR.rechnungsNr);

                                    if(currentFindNonStorno!=null)
                                    {
                                        if (currentFind != null)
                                        {
                                            string naechsteZeile = currentFind.Row.ToString();
                                            excelWorksheet2.Range["A" + naechsteZeile].Value = "R" + frmNR.rechnungsNr + "_STORNO";
                                            excelWorksheet2.Range["B" + naechsteZeile].Value = frmNR.rechnungsDatum.Date.ToString(("dd.MM.yyyy"));
                                            excelWorksheet2.Range["C" + naechsteZeile].Value = Convert.ToDecimal(warenwert.Substring(0, warenwert.Length - 2));
                                            excelWorksheet2.Range["D" + naechsteZeile].Value = Convert.ToDecimal(versand.Substring(0, versand.Length - 2));
                                            excelWorksheet2.Range["E" + naechsteZeile].Value = mwstsatz;
                                            excelWorksheet2.Range["F" + naechsteZeile].Value = Convert.ToDecimal(mwst.Substring(0, mwst.Length - 2));
                                            excelWorksheet2.Range["G" + naechsteZeile].Value = Convert.ToDecimal(summebrutto.Substring(0, summebrutto.Length - 2));
                                            excelWorksheet2.Range["H" + naechsteZeile].Value = Convert.ToDecimal(summenetto.Substring(0, summenetto.Length - 2));
                                        }
                                        else
                                        {
                                            MessageBox.Show("Die Rechnung R" + frmNR.rechnungsNr + " ist in der Monatsübersicht bereits als Nicht-Stornorechnung vorhanden und wird nicht automatisch in der Monatsübersicht aktualisiert.", "Monatsübersicht", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Sie haben eine alternative Rechnungsnummer angegeben, die jeweilige Rechnung wurde in der Monatsübersicht allerdings nicht gefunden, daher wurde die Rechnung R" + frmNR.rechnungsNr + "_STORNO nicht in der Monatsübersicht aktualisiert. Besteht ggf. eine Lücke?", "Monatsübersicht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }


                                    /*excelWorksheet.Range["C" + naechsteZeile].Cells.NumberFormat = "0.00 €";
                                    excelWorksheet.Range["D" + naechsteZeile].Cells.NumberFormat = "0.00 €";
                                    excelWorksheet.Range["F" + naechsteZeile].Cells.NumberFormat = "0.00 €";
                                    excelWorksheet.Range["G" + naechsteZeile].Cells.NumberFormat = "0.00 €";
                                    excelWorksheet.Range["H" + naechsteZeile].Cells.NumberFormat = "0.00 €";*/

                                    //nächste zeile nicht hochzählen
                                    //excelWorksheet2.Range["K4"].Value = naechsteZeileInt + 1;
                                    //dokument speichern
                                    wb2.Save();
                                    wb2.Close(false);
                                }
                            }

                            save = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bitte den Vorlagenpfad in den Einstellungen festlegen", "justforyou - Excel");
                }
            }
        }
    }
}
