using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace ExtractCsvFromExcel
{
    class UpdateExcelData
    {
        List<DataRij> xlData;
        List<Parameter> parameters;
        List<string> headers;

        List<DataRij> oldXlData = CsvGenerator.xlData;
        List<Parameter> oldParameters = MetadataHandler.parameters;
        List<string> oldHeaders = CsvGenerator.headers;

        public void Main(string excelFile)
        {
            xlData = ReadFromExcel.LeesWerkbladen(excelFile);

            headers = xlData[CsvGenerator.rijOffset].data;

            parameters = UpdatedParameters(headers);

            int uniqueHeaders = GetUniqueHeaders();

            UpdateProductModelType(uniqueHeaders);

            UpdateProjectData();
        }

        List<Parameter> UpdatedParameters(List<string> headers)
        {
            parameters = new List<Parameter>();

            for (int i = 0; i < oldHeaders.Count; i++)
            {
                foreach (Parameter parameter in oldParameters.Where(p => p.headerIndex == i))
                {
                    if (headers.Contains(oldHeaders[i]))
                        parameters.Add(parameter);
                }
            }

            for (int p = 0; p < parameters.Count; p++)
            {
                parameters[p].headerIndex = headers.IndexOf(oldHeaders[parameters[p].headerIndex]);
            }

            return parameters;
        }

        int GetUniqueHeaders()
        {
            int uniqueHeaderIndex = 0;

            for(int c = 0; c < oldHeaders.Count; c++)
            {
                bool uniqueItems = true;
                List<string> kolomData = new List<string>();
                for(int r = CsvGenerator.rijOffset; r < xlData.Count; r++)
                {
                    if (!kolomData.Contains(xlData[r].data[c]) || kolomData == null)
                    {
                        kolomData.Add(xlData[r].data[c]);
                    }
                    else
                    {
                        uniqueItems = false;
                        break;
                    }
                }
                if(uniqueItems == true)
                {
                    uniqueHeaderIndex = c;
                    break;
                }
            }
            
            return uniqueHeaderIndex;
        }

        void UpdateProductModelType(int uniqueHeader)
        {
            int newUniqueHeader = headers.IndexOf(oldHeaders[uniqueHeader]);
            List<DataRij> oldData = oldXlData;
            for (int i = 0; i < oldData.Count; i++)
            {
                foreach(DataRij dataRij in xlData.Where(d=>d.data[newUniqueHeader] == oldData[i].data[uniqueHeader]))
                {
                    dataRij.fittingType = oldData[i].fittingType;
                    dataRij.globalIndex = oldData[i].globalIndex;
                    dataRij.status = oldData[i].status;
                }
            }
        }

        void UpdateProjectData()
        {
            CsvGenerator.headers = headers;
            MetadataHandler.parameters = parameters;
            CsvGenerator.xlData = xlData;
        }

        public void RecoverProjectData()
        {
            CsvGenerator.headers = oldHeaders;
            MetadataHandler.parameters = oldParameters;
            CsvGenerator.xlData = oldXlData;
        }
    }
}
