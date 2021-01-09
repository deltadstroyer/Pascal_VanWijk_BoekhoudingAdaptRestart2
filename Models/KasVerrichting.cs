using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Boekhouding
{
    public class KasVerrichting : Factuur
    {
        
        public string Betaalwijze { get; set; }
        public string Type { get; set; }
    }
}
