using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExtractCsvFromExcel
{
    public static class ReadFromExcel
    {
        static Microsoft.Office.Interop.Excel.Application xlApp;
        public static int colCount;
        

        public static List<DataRij> LeesWerkbladen(string excelFile)
        {
            frmWorking working = new frmWorking("Excelbestand aan het openen...");
            working.Show();

            List<string> werkbladen = OpenExcelBestand(excelFile);

            working.Close();

            int werkbladIndex = KiesWerkblad(werkbladen);

            working = new frmWorking("Inhoud aan het laden...");
            working.Show();

            object[,] data = OpenWerkblad(werkbladIndex, excelFile);
            List<DataRij> xlData = GenereerDataRijen(data);

            working.Close();

            return xlData;
        }

        static List<string> OpenExcelBestand(string excelFile) { 
            xlApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook xlBestand = xlApp.Workbooks.Open(excelFile, true);

            List<string> werkbladen = new List<string>();
            foreach (Worksheet werkblad in xlBestand.Worksheets)
                werkbladen.Add(werkblad.Name);

            xlBestand.Close(false);
            xlApp.Quit();

            return werkbladen;
        }

        static int KiesWerkblad(List<string> werkbladen) {
            frmSelectWorksheet selectWorksheet = new frmSelectWorksheet(werkbladen);
            

            if(selectWorksheet.ShowDialog() == DialogResult.OK)
            {
                return selectWorksheet.werkbladIndex;
            }
            else
            {
                return -1;
            }

        }

        static object[,] OpenWerkblad(int werkbladIndex, string excelFile) { 
            if(werkbladIndex == -1)
            {
                return null;
            }

            Workbook xlBestand = xlApp.Workbooks.Open(excelFile, true);
            Worksheet xlWerkblad = (Worksheet)xlBestand.Worksheets.get_Item(werkbladIndex);

            MetadataHandler.productRange = xlWerkblad.Name;

            object[,] data = xlWerkblad.UsedRange.Value2 as object[,];

            xlBestand.Close(false);
            xlApp.Quit();

            xlBestand = null;
            xlApp = null;

            return data;
        }

        public static List<DataRij> GenereerDataRijen(object[,] data)
        {            
            int rowsCount = data.GetUpperBound(0);
            int colsCount = data.GetUpperBound(1);

            List<DataRij> xlData = new List<DataRij>();

            for (int r = 1; r <= rowsCount; r++)
            {
                DataRij dataRij = new DataRij();
                for (int c = 1; c <= colsCount; c++)
                {
                    object record = data[r, c];
                    dataRij.AddRecord(record);
                }
                dataRij.globalIndex = r;
                dataRij.status = "Niet toegewezen";
                xlData.Add(dataRij);
            }

            return xlData;
        }
    }
}