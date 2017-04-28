using System.Windows.Input;
using Xamarin.Forms;
namespace MVVM
{
	public class MainViewModel : BindableObject
	{
		private string _message;
		private int _counter;

		public ICommand ClicCommand { get { return new Command(ButtonClic); } }

		public MainViewModel()
		{
			Message = "Hello from ViewModel";
		}

		public string Message
		{
			get { return _message; }
			set
			{
				_message = value;
				OnPropertyChanged("Message");
			}
		}

		private void ButtonClic()
		{
			_counter++;

			Message = string.Format("Click {0} ", _counter);
		}
	}
}
