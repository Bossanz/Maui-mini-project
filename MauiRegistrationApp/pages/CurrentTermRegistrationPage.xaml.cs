using MauiRegistrationApp.ViewModel;

namespace MauiRegistrationApp.pages;

public partial class CurrentTermRegistrationPage : ContentPage
{
	public CurrentTermRegistrationPage()
	{
		InitializeComponent();
		BindingContext = new ShowDataStudent();
	}
	private async void OnClickedHome(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}