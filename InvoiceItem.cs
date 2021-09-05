using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace justforyou_Excel
{
    class InvoiceItem
    {
        public String name { get; set; }
        public double preis { get; set; }
        public int mwst { get; set; }

        public InvoiceItem(string pName, double pPreis, int pMwst)
        {
            name = pName;
            preis = pPreis;
            mwst = pMwst;
        }

        public static InvoiceItem[] FromFile(string file)
        {
            string[] strArray = System.IO.File.ReadAllLines(file);
            InvoiceItem[] ret = new InvoiceItem[0];
            foreach (string s in strArray)
            {
                string[] strArraySplit = s.Split(new[] { "|%$|" }, StringSplitOptions.None);
                string pName = strArraySplit[0];
                double pPreis = Convert.ToDouble(strArraySplit[1]);
                int pMwst = Convert.ToInt32(strArraySplit[2]);
                Array.Resize(ref ret, ret.Length + 1);
                ret[(ret.Length)-1] = new InvoiceItem(pName, pPreis, pMwst);
            }

            return ret;
        }

        public static void ToFile(InvoiceItem[] array, string file)
        {
            string[] temp = new string[array.Length];
            int ii = 0;
            foreach (InvoiceItem i in array)
            {
                temp[ii] = i.name + "|%$|" + i.preis + "|%$|" + i.mwst;
                ii++;
            }
            System.IO.File.WriteAllLines(file, temp);

        }

        public static double getPreisFromArray(InvoiceItem[] array, string identifier)
        {
            if (array != null)
            {
                foreach (InvoiceItem i in array)
                {
                    if (i.name.Equals(identifier))
                    {
                        return i.preis;
                    }
                }
            }
            return 0;
        }

        public static int getMwstFromArray(InvoiceItem[] array, string identifier)
        {
            if (array != null)
            {
                foreach (InvoiceItem i in array)
                {
                    if (i.name.Equals(identifier))
                    {
                        return i.mwst;
                    }
                }
            }
            return 0;
        }

        public static bool alreadyInArray(InvoiceItem[] array, string identifier)
        {
            if (array != null)
            {
                foreach (InvoiceItem i in array)
                {
                    if (i.name.Equals(identifier))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static InvoiceItem[] changeValues(InvoiceItem[] array, string identifier, double pPreis, int pMwst)
        {
            int ii = 0;
            foreach (InvoiceItem i in array)
            {
                if (i.name.Equals(identifier))
                {
                    array[ii].preis = pPreis;
                    array[ii].mwst = pMwst;
                    return array;
                }
                ii++;
            }
            return array;
        }
    }
}
