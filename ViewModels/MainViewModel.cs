using System;
using System.Collections.Generic;
using System.Text;
using Demo_Boekhouding.Services;
using Demo_Boekhouding.Utilities;

namespace Demo_Boekhouding.ViewModels
{
    public class MainViewModel:ObservableObject
    {

        private IBoekhoudingDataService _dataService;
        private KlantenViewModel _klantenVM;
        private KasBoekViewModel _kasBoekVM;
        private LeveranciersViewModel _leveranciersVM;

        private AankoopDagBoekViewModel _aankoopDagboekVM;
        private VerkoopDagBoekViewModel _verkoopDagboekVM;
        private OverzichtViewModel _overzichtVM;
        public MainViewModel()
        {
            _dataService = new MockBoekhoudingDataService();
            KlantenVM = new KlantenViewModel(_dataService);
            KasBoekVM = new KasBoekViewModel(_dataService);
            LeveranciersVM = new LeveranciersViewModel(_dataService);
            AankoopDagboekVM = new AankoopDagBoekViewModel(_dataService);
            VerkoopDagBoekVM = new VerkoopDagBoekViewModel(_dataService);
            OverzichtVM = new OverzichtViewModel(_dataService);
        }

        public KlantenViewModel KlantenVM
        {
            get { return _klantenVM; }
            set { OnPropertyChanged(ref _klantenVM, value); }
        }
        public KasBoekViewModel KasBoekVM
        {
            get { return _kasBoekVM; }
            set { OnPropertyChanged(ref _kasBoekVM, value); }
        }
        public LeveranciersViewModel LeveranciersVM
        {
            get { return _leveranciersVM; }
            set { OnPropertyChanged(ref _leveranciersVM, value); }
        }
        public AankoopDagBoekViewModel AankoopDagboekVM
        {
            get { return _aankoopDagboekVM; }
            set { OnPropertyChanged(ref _aankoopDagboekVM, value); }
        }
        public VerkoopDagBoekViewModel VerkoopDagBoekVM
        {
            get { return _verkoopDagboekVM; }
            set { OnPropertyChanged(ref _verkoopDagboekVM, value); }
        }
        public OverzichtViewModel OverzichtVM
        {
            get { return _overzichtVM; }
            set { OnPropertyChanged(ref _overzichtVM, value); }
        }

        //code aanvullen met public properties voor LeveranciersVM,  AankoopDagboekVM, VerkoopDagboekVM en OverzichtVM
    }
}
