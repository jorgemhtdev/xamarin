using Xamarin.Forms;

namespace Cities
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CitiesPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
