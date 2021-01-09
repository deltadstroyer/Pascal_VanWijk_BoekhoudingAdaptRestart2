using Demo_Boekhouding.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Boekhouding
{
    public class Factuur : ObservableObject
    {
        private DateTime _factuurDatum;

        public string UniekNr { get; set; }
        public DateTime FactuurDatum 
        {
            get { return _factuurDatum; }
            set { OnPropertyChanged(ref _factuurDatum, value); }
            }
        public double BedragExclBTW { get; set; }
        public int BTWTarief { get; set; }
        public string Status { get; set; }
        public double BedragInclBTW { get { return BedragExclBTW + BTWBedrag; } }
        public string Omschrijving { get; set; }
        public DateTime BetaalDatum { get; set; }
        public double BTWBedrag { get { return BedragExclBTW * BTWTarief / 100.0; }  }
        public DateTime VervalDatum { get; set; }
        public Contact Contact { get; set; }
        public string Maand
        {
            get { return _factuurDatum.ToString("MMM"); }
            set { }
        }

    }
}
