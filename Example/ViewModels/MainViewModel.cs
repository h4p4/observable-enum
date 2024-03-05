using observableEnum.Example.Enums;
using observableEnum.Models;

namespace observableEnum.Example.ViewModels
{
    internal class MainViewModel : ViewModel
    {
		//private BindableEnum<CounterweightSide> _selectedCounterweightSide;
		private CounterweightSide _selectedCounterweightSide;
        private ObservableEnumCollection<CounterweightSide> _counterweightSides;

        public MainViewModel()
        {
            CounterweightSides = new ObservableEnumCollection<CounterweightSide>()
            {                 
                CounterweightSide.Left,
                CounterweightSide.Right,
                CounterweightSide.Top,
                CounterweightSide.Bottom,
            };
        }

        public CounterweightSide SelectedCounterweightSide
        {
            get => _selectedCounterweightSide;
            set
            {
                _selectedCounterweightSide = value;
                OnPropertyChanged(nameof(SelectedCounterweightSide));
            }
        }
        //public BindableEnum<CounterweightSide> SelectedCounterweightSide
        //{
        //    get => _selectedCounterweightSide;
        //    set
        //    {
        //        _selectedCounterweightSide = value;
        //        OnPropertyChanged(nameof(SelectedCounterweightSide));
        //    }
        //}

        public ObservableEnumCollection<CounterweightSide> CounterweightSides
		{
			get => _counterweightSides;
            set
            {
                _counterweightSides = value;
                OnPropertyChanged(nameof(CounterweightSides));
            }
        }
    }
}
