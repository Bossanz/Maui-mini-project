using MauiRegistrationApp.Model;
using MauiRegistrationApp.ViewModel;

namespace MauiRegistrationApp.pages;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        BindingContext = new ShowDataStudent();
    }

}