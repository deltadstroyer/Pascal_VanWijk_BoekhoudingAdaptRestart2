using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Boekhouding
{
    public class Klant: Contact
    {
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
        public override string ToString()
        {
            return $"{Voornaam} {Familienaam}";
        }
    }
}
