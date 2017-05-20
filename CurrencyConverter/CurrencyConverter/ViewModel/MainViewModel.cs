using System;
using System.ComponentModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace CurrencyConverter.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {

        #region Attributes
        public double dollar;
        public double pound;
        public double swiss;


        #endregion

        #region Properties
        public double Euro { get; set; }
        public double Dollar 
        {

            set
            {
                if (this.dollar != value)
                {
                    this.dollar = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dollar"));
                }
            }
            get
            {
                return this.dollar;
            }
        }
        public double Pound 
        {
			set
			{
                if (this.pound != value)
				{
					this.pound = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pound"));
				}
			}
			get
			{
				return this.pound;
			}    
        }
        public double Swiss
        {
			set
			{
                if (this.swiss != value)
				{
					this.swiss = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Swiss"));
				}
			}
			get
			{
				return this.swiss;
			}
        }
        #endregion

        public MainViewModel()
        {
            
        }

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion


        #region Commands
        public ICommand ConvertCommand { get { return new RelayCommand(ChangeCurrency); } }

        private async void ChangeCurrency()
        {
            if (this.Euro <= 0)
            {
                await App.Current.MainPage.DisplayAlert("Error", "You must enter a value greater than zero ", "Accept");
            }
            else
            {
                this.Dollar = this.Euro / 1.12;
                this.Pound = this.Euro / 0.86;
                this.Swiss = this.Euro / 1.09;
            }
        }
        #endregion

    }
}
