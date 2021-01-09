using Demo_Boekhouding.Services;
using Demo_Boekhouding.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Demo_Boekhouding.ViewModels
{
    public class OverzichtViewModel : ObservableObject
    {
        private IBoekhoudingDataService _dataService;
        private ObservableCollection<TotaalOverzicht> _totaalOverzicht;
        public ObservableCollection<TotaalOverzicht> TotaalOverzicht
        {
            get { return _totaalOverzicht; }
            set { OnPropertyChanged(ref _totaalOverzicht, value); }
        }

        public OverzichtViewModel(IBoekhoudingDataService _dataService)
        {

        }
    }
}
