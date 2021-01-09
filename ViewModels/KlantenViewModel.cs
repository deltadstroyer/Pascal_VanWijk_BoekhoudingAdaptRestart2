using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Demo_Boekhouding.Services;
using Demo_Boekhouding.Utilities;

namespace Demo_Boekhouding.ViewModels
{
    public class KlantenViewModel:ObservableObject
    {
        private IBoekhoudingDataService _dataService;
        private  ObservableCollection<Klant> _klanten;
        private Klant _selectedKlant;
        public KlantenViewModel(IBoekhoudingDataService dataService)
        {
            _dataService = dataService;
            Klanten = new ObservableCollection<Klant>(dataService.GeefAlleKlanten());
        }
        public ObservableCollection<Klant> Klanten
        {
            get { return _klanten; }
            set { OnPropertyChanged(ref _klanten,value); }
        }
        public Klant SelectedKlant
        {
            get { return _selectedKlant; }
            set { OnPropertyChanged(ref _selectedKlant, value); }
        }
    }
}
