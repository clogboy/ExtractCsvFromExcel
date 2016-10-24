using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractCsvFromExcel
{
    static class UndoHandler
    {
        public static List<Actie> acties = new List<Actie>();

        public static void BewaarWijzigingen()
        {
            foreach (Actie actie in acties.Where(a => a.uitgevoerd == false))
            {
                actie.VoerActieUit();
            }
        }

        public static void VerwijderWijzigingen()
        {
            for (int a = acties.Count - 1; a >= 0 ; a--)
            {
                if (acties[a].uitgevoerd == false)
                {
                    acties.Remove(acties[a]);
                }
            }
        }
    }
}
