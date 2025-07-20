using DataBindingTutorial.Models;
using System.Net.Http.Json;

namespace DataBindingTutorial
{
    public partial class MainPage : ContentPage
    {
        private readonly HttpClient httpClient;
        public MainPage()
        {
            InitializeComponent();
            httpClient = new HttpClient();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            try
            {
                string url = "https://dog.ceo/api/breeds/image/random";

                DogResponse dog = await httpClient.GetFromJsonAsync<DogResponse>(url) ?? new DogResponse();
                if (dog != null && dog.Status == "success")
                {
                    BindingContext = dog;
                }
                else
                {
                    await DisplayAlert("Error", "Failed to fetch dog image", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }

}
