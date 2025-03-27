using MauiRegistrationApp.ViewModel;

namespace MauiRegistrationApp.pages;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
		BindingContext = new ShowDataStudent();
	}
	private async void OnDetailsClickedback(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}