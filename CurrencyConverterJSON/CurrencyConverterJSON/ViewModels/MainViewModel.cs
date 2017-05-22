using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Input;
using CurrencyConverterJSON.Models;
using CurrencyConverterJSON.Services;
using GalaSoft.MvvmLight.Command;

namespace CurrencyConverterJSON.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {

        #region Attributes
        private ExchangeRates exchangeRates;
        private double amount;
        private double sourceRate; 
        private double targetRate;
        private bool isEnabled;
        private bool isRunning;
        private string message;
        #endregion

        #region Properties
        public ObservableCollection<Rate> Rates { get; set; }
        ApiServices apiService;
       
		public double Amount
		{
			set
			{
				if (this.amount != value)
				{
					this.amount = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Amount"));
				}
			}
			get
			{
				return this.amount;
			}
		}

		public double SourceRate
		{
			set
			{
				if (this.sourceRate != value)
				{
					this.sourceRate = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SourceRate"));
				}
			}
			get
			{
				return this.sourceRate;
			}
		}

		public double TargetRate
		{
			set
			{
				if (this.targetRate != value)
				{
					this.targetRate = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TargetRate"));
				}
			}
			get
			{
				return this.targetRate;
			}
		}

		public bool IsRunning
		{
			set
			{
				if (this.isRunning != value)
				{
					this.isRunning = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRunning"));
				}
			}
			get
			{
				return this.isRunning;
			}
		}

		public bool IsEnabled
		{
			set
			{
				if (this.isEnabled != value)
				{
					this.isEnabled = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsEnabled"));
				}
			}
			get
			{
				return this.isEnabled;
			}
		}

		public string Message
		{
			set
			{
                if (this.message != value)
				{
					this.message = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Message"));
				}
			}
			get
			{
                return this.message;
			}
		}
        #endregion

        #region Constructors
        public MainViewModel()
        {
            Rates = new ObservableCollection<Rate>();
            apiService = new ApiServices();
            LoadRates();
            Message = "Enter an amount, select a source currency, select a target currency and press Convert button";

        }
		#endregion

		#region Commands
        public ICommand ConvertCurrencyCommand { get { return new RelayCommand(ConvertCurrency); } }

        private async void ConvertCurrency(){

            if (Amount <= 0 || SourceRate == 0 || TargetRate == 0) 
            {
                await App.Current.MainPage.DisplayAlert("Error", "You must enter a value greater than zero and select a source rate", "OK");
            }
            else
            {
                var converted = Amount / (double)SourceRate * (double)TargetRate;
                Message = string.Format("{0:C2}={1:C2}", Amount, converted);
            }
        }

		#endregion


		#region Methods
		private async void LoadRates()
        {
            IsRunning = true;

            try
            {
                this.exchangeRates = await apiService.GetAllOrders();

            }
            catch(System.Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", ex.Message, "Accept");
                this.isRunning = false;
                IsEnabled = false;
                return;
            }

            ConvertRates();

            IsRunning = false;
            IsEnabled = true;
        }


		private void ConvertRates()
        {
			Rates.Clear();
			var type = typeof(Rates);
			var properties = type.GetRuntimeFields();


			foreach (var property in properties)
            {
				var code = property.Name.Substring(1, 3);
				Rates.Add(new Rate
				{
                    Code = code,
                    TaxtRate = (double)property.GetValue(exchangeRates.Rates),
                });
            }
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
		#endregion


	}
}
