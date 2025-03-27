using MauiRegistrationApp.pages;

namespace MauiRegistrationApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // ลงทะเบียน Route สำหรับ HomePage
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));

        // ตั้งค่าเริ่มต้นไปที่ LoginPage
        CurrentItem = new ShellContent
        {
            ContentTemplate = new DataTemplate(typeof(LoginPage))
        };
    }
}

