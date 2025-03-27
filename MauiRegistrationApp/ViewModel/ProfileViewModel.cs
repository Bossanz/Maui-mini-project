using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiRegistrationApp.pages;

namespace MauiRegistrationApp.ViewModel;

public partial class ProfileViewModel : ObservableObject
{
	 [RelayCommand]
    async Task HomeAsync(){
      await GoToPage(nameof(HomePage));
    }
    // Task => Future
    [RelayCommand]
async Task GoToPage(string page){
  await Shell.Current.GoToAsync(page);
}
}