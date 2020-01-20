using Newtonsoft.Json;
using System.Collections.Generic;
using Xamarin.Forms;

namespace TestBD
{

    public partial class HomeViewPage : ContentPage
    {
        public HomeViewPage()
        {
            InitializeComponent();
            usersList.ItemsSource = new List<string>();

            getUsersBtn.Clicked += async (s, e) =>
            {
                var client = new System.Net.Http.HttpClient();
                string url = "https://rubenalbausers.azurewebsites.net/api/Users?code=QPBzkwsmhcV2qt3kCVSLXdPYt0t0bxv/Y2AJDI555sMIjfCWDb9u3w==";
                var response = await client.GetAsync(url);
                var usersJson = response.Content.ReadAsStringAsync().Result;
                List<string> listUsers = JsonConvert.DeserializeObject<List<string>>(usersJson);
                usersList.ItemsSource = listUsers;
            };
        }
    }
}