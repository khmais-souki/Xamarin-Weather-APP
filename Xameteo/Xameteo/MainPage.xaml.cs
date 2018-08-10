using System;
using System.Net.Http;
using Xamarin.Forms;
using Xameteo.Model;
using Xameteo.Work;

namespace Xameteo 
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            BindingContext = new Weather();
		}
        private async void GetWeatherBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(cityNameEntry.Text))
                {
                    Weather weather = await Core.GetWeather(cityNameEntry.Text);
                    if (weather != null)
                    {
                        BindingContext = weather;
                        temperature.FontSize = 150;
                       //minTmp.Text = "min";
                       //maxTmp.Text = "max";
                    }
                    else
                    {
                        BindingContext = new Weather("", "", "", "", "");
                        await DisplayAlert("oops!", "veuillez vérifier de nouveau le nom de la ville", "OK");
                       //minTmp.Text = "";
                       //maxTmp.Text = "";
                    }
                }
            } catch(HttpRequestException)
            {
               await DisplayAlert("WARNING", "you're out of connection", "OK");              
            }
            
            
           
        }

    }
}
