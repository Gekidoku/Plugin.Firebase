using Plugin.Firebase.CloudMessaging;

namespace Playground;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
        CrossFirebaseCloudMessaging.Current.NotificationReceived += async (s, po) => {

        };
    }
}