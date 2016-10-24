using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractCsvFromExcel
{
    class Actie
    {
        public string oldVal {get; set;}
        public string newVal {get; set; }

        public int row { get; set; }
        public int col { get; set; }

        public string fittingType { get; set; }

        public bool uitgevoerd = false;

        public void VoerActieUit()
        {
            CsvGenerator.xlData[row].data[col] = newVal;
            uitgevoerd = true;
            CsvGenerator.data.hasChanged = true;
        }
    }
}
