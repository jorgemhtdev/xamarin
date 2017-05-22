using CurrencyConverterJSON.ViewModels;

namespace CurrencyConverterJSON.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel(); 
        }
    }
}
