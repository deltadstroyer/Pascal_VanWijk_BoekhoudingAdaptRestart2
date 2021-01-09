using Demo_Boekhouding.Services;
using Demo_Boekhouding.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Demo_Boekhouding.ViewModels
{
    public class VerkoopDagBoekViewModel : ObservableObject
    {
        private IBoekhoudingDataService _dataService;
        private ObservableCollection<VerkoopFactuur> _verkoopFactuur;
        private VerkoopFactuur _selectedVerkoopFactuur;
        private ObservableCollection<Leverancier> _leverancier;
        public VerkoopDagBoekViewModel(IBoekhoudingDataService dataService)
        {
            _dataService = dataService;
            VerkoopFacturen = new ObservableCollection<VerkoopFactuur>(dataService.GeefVerkoopDagboek());
            Leveranciers = new ObservableCollection<Leverancier>(dataService.GeefAlleLeveranciers());
        }

        public ObservableCollection<VerkoopFactuur> VerkoopFacturen
        {
            get { return _verkoopFactuur; }
            set { OnPropertyChanged(ref _verkoopFactuur, value); }
        }
        public VerkoopFactuur SelectedVerkoopFactuur
        {
            get { return _selectedVerkoopFactuur; }
            set { OnPropertyChanged(ref _selectedVerkoopFactuur, value); }
        }

        public ObservableCollection<Leverancier> Leveranciers
        {
            get { return _leverancier; }
            set { OnPropertyChanged(ref _leverancier, value); }
        }
    }
}
