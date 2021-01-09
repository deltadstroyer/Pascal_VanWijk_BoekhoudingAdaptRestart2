using System.Collections.Generic;
using Demo_Boekhouding.ViewModels;

namespace Demo_Boekhouding.Services
{
    public interface IBoekhoudingDataService
    {
        IList<AankoopFactuur> GeefAankoopDagboek();
        IList<KasVerrichting> GeefKasboek();
        IList<VerkoopFactuur> GeefVerkoopDagboek();
        IList<Klant> GeefAlleKlanten();
        IList<Leverancier> GeefAlleLeveranciers();

        IList<AankoopFactuur> VerwijderAankoopFactuur(AankoopFactuur factuur);
        IList<AankoopFactuur> VoegAankoopFactuurToe(AankoopFactuur factuur);
        void WijzigAankoopFactuur(AankoopFactuur nieuwefactuur);

        IList<VerkoopFactuur> VerwijderVerkoopFactuur(VerkoopFactuur factuur);
        IList<VerkoopFactuur> VoegVerkoopFactuurToe(VerkoopFactuur factuur);
        void WijzigVerkoopFactuur(VerkoopFactuur nieuwefactuur);

        IList<Klant> VerwijderKlant(Klant klant);
        IList<Klant> VoegKlantToe(Klant klant);
        void WijzigKlant(Klant klant);

        IList<Leverancier> VerwijderLeverancier(Leverancier leverancier);
        IList<Leverancier> VoegLeverancierToe(Leverancier leverancier);
        void WijzigLeverancier(Leverancier leverancier);
        
    }
}