using System.Net.Http.Json;

namespace LocalhostMAUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCallApiBtnClicked(object sender, EventArgs e)
	{
		var httpClient = new HttpClient();
		var baseUrl = DeviceInfo.Platform == DevicePlatform.Android
						? "https://192.168.8.103:5001"
						: "http://192.168.8.103:5000";

        var response = await httpClient.GetAsync($"{baseUrl}/WeatherForecast");

		var data = await response.Content.ReadAsStringAsync();
	}
}

