using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Directive;
using Shared;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WeatherAppWindowsphone
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Main : Page
    {
        public Main()
        {
            this.InitializeComponent();
        }

        private void GetWeatherButton_Click(object sender, RoutedEventArgs e) {
            Weather weather = Core.GetWeather(txtZipCode.Text).Result;
           
            if (weather != null)
            {
                ResultsTitle.Text = weather.Title;
                TempText.Text = weather.Temperature;
                WindText.Text = weather.Wind;
                VisibilityText.Text = weather.Visibility;
                HumidityText.Text = weather.Humidity;
                SunriseText.Text = weather.Sunrise;
                SunsetText.Text = weather.Sunset;

                btnGetWeather.Content = "Search Again";

            }
            else
            {
                ResultsTitle.Text = "Couldn't find any results";
            }

        }
    }
}
