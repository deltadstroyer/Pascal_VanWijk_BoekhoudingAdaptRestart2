using Demo_Boekhouding.Services;
using Demo_Boekhouding.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Demo_Boekhouding.ViewModels
{
    public class AankoopDagBoekViewModel : ObservableObject
    {
        private IBoekhoudingDataService _dataService;
        private ObservableCollection<AankoopFactuur> _aankoopFactuur;
        private AankoopFactuur _selectedAankoopFactuur;
        private ObservableCollection<Leverancier> _leverancier;
        public AankoopDagBoekViewModel(IBoekhoudingDataService dataService)
        {
            _dataService = dataService;
            AankoopFacturen = new ObservableCollection<AankoopFactuur>(dataService.GeefAankoopDagboek());
            Leveranciers = new ObservableCollection<Leverancier>(dataService.GeefAlleLeveranciers());
        }

        public ObservableCollection<AankoopFactuur> AankoopFacturen
        {
            get { return _aankoopFactuur; }
            set { OnPropertyChanged(ref _aankoopFactuur, value); }
        }
        public AankoopFactuur SelectedAankoopFactuur
        {
            get { return _selectedAankoopFactuur; }
            set { OnPropertyChanged(ref _selectedAankoopFactuur, value); }
        }

        public ObservableCollection<Leverancier> Leveranciers
        {
            get { return _leverancier; }
            set { OnPropertyChanged(ref _leverancier, value); }
        }

    }
}
