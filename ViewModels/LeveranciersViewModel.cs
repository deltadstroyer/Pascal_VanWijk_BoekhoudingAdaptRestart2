using Demo_Boekhouding.Services;
using Demo_Boekhouding.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Demo_Boekhouding.ViewModels
{
    public class LeveranciersViewModel : ObservableObject
    {
        private IBoekhoudingDataService _dataService;
        private ObservableCollection<Leverancier> _leverancier;
        private Leverancier _selectedLeverancier;
        public LeveranciersViewModel(IBoekhoudingDataService dataService)
        {
            _dataService = dataService;
            Leveranciers = new ObservableCollection<Leverancier>(dataService.GeefAlleLeveranciers());
        }
        public ObservableCollection<Leverancier> Leveranciers
        {
            get { return _leverancier; }
            set { OnPropertyChanged(ref _leverancier, value); }
        }
        public Leverancier selectedLeverancier
        {
            get { return _selectedLeverancier; }
            set { OnPropertyChanged(ref _selectedLeverancier, value); }
        }
    }
}
