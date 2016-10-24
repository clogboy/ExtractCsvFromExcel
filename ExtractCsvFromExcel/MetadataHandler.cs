using System.Collections.Generic;
using System.Linq;

namespace ExtractCsvFromExcel
{
    static class MetadataHandler
    {
        private static List<string> m_pmtList;
        private static List<string> m_alias;
        public static int descriptionIndex;
        public static string productRange;
        static List<DataRij> xlData;
        public static List<Feature> features;
        public static List<Parameter> parameters;
        public static List<Commentaar> commentaar;

        public static List<string> ProductModelTypes(int rijOffset, bool recount)
        {
            int i = 0;
            m_pmtList = new List<string>();
            m_alias = new List<string>();
            xlData = CsvGenerator.xlData;
            

            for (int d = rijOffset + 1; d < xlData.Count; d++)
                if (xlData[d].fittingType == null || recount)
                    if (!m_alias.Contains(xlData[d].compatibleHash))
                    {
                        m_alias.Add(xlData[d].compatibleHash);
                        string nummer = i < 9 ? "0" + (i + 1).ToString() : (i + 1).ToString();
                        string subset = "verzameling " + nummer;
                        xlData[d].fittingType = subset;
                        m_pmtList.Add(subset);
                        i++;
                    }

                    else
                        xlData[d].fittingType = m_pmtList[m_alias.IndexOf(xlData[d].compatibleHash)];

                else if (!m_pmtList.Contains(xlData[d].fittingType)) {
                    m_pmtList.Add(xlData[d].fittingType);
                }

            return m_pmtList;
        }

        public static List<bool> ColumnHasData(List<string> headers, string fittingType)
        {
            List<bool> columnHasData = new List<bool>();

            //Kijkt bij elke rij of een kolom gegevens bevat
            for (int c = 0; c < headers.Count; c++)
            {
                bool hasData = false;

                foreach(DataRij dataRij in xlData.Where(d=>d.fittingType == fittingType))
                    if (dataRij.data[c].ToString() != "")
                        hasData = true;

                //Voegt een boolean toe: True bij een kolom met data, False bij een kolom zonder data.
                columnHasData.Add(hasData);
            }

            return columnHasData;
        }

        public static List<string> status()
        {
            List<string> statusList = new List<string>();

            for(int i = CsvGenerator.rijOffset+1; i < CsvGenerator.xlData.Count; i++)
            {
                if (!statusList.Contains(CsvGenerator.xlData[i].status))
                    statusList.Add(CsvGenerator.xlData[i].status);
            }

            return statusList;
        }
    }
}
