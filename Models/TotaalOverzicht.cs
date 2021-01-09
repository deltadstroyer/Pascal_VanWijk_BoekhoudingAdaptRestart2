using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Boekhouding
{
    public class TotaalOverzicht
    {
        public List<AankoopFactuur> AankoopDagboek;
        public List<VerkoopFactuur> VerkoopDagboekn;
        public List<KasVerrichting> Kasboek;

        public double TeBetalenBTW6 { get; }
        public double TeBetalenBTW21 { get; }
        public double TeOntvangenBTW6 { get; }
        public double TeOntvangenBTW21 { get; }
        public double BTWSaldo { get; }
        public double OpenstaandeDebiteuren { get; }
        public double OpenstaandeCrediteuren { get; }
        public double Omzet { get; }
        public double BedrijfsKostsen { get; }
        public double ResultaatVoorAfschrijvingEnBelastingen { get; }

    }
}
