using MauiRegistrationApp.ViewModel;

namespace MauiRegistrationApp.pages;

public partial class CourseWithdrawalPage : ContentPage
{
	public CourseWithdrawalPage()
	{
		InitializeComponent();
		BindingContext = new ShowDataStudent();
	}
	private async void OnClickedHome(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}