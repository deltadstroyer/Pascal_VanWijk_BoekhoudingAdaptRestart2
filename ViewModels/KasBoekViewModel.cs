using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Demo_Boekhouding.Services;
using Demo_Boekhouding.Utilities;

namespace Demo_Boekhouding.ViewModels
{
    public class KasBoekViewModel:ObservableObject
    {
        private IBoekhoudingDataService _dataService;
        private ObservableCollection<KasVerrichting> _kasboek;
        private KasVerrichting _selectedKasVerrichting;
        public KasBoekViewModel(IBoekhoudingDataService dataService)
        {
            _dataService = dataService;
            _kasboek = new ObservableCollection<KasVerrichting>(dataService.GeefKasboek());
        }
        public ObservableCollection<KasVerrichting> KasBoek
        {
            get { return _kasboek; }
            set { OnPropertyChanged(ref _kasboek, value); }
        }
        public KasVerrichting SelectedKasVerrichting
        {
            get { return _selectedKasVerrichting; }
            set { OnPropertyChanged(ref _selectedKasVerrichting, value); }
        }
    }
}
