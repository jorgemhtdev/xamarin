using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MVVM
{
	public partial class MainView : ContentPage
	{
		public MainView()
		{
			InitializeComponent();

			BindingContext = new MainViewModel();

		}
	}
}
