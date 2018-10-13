using MyMoney.Mobile.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace MyMoney.Mobile
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            var masterDetailPage = new MasterDetailPage
            {
                Master = new LeftMenuView { Title = "Menu" },
                Detail = new NavigationPage(new MainPage { Title = "Main Page" })
            };

            MainPage = masterDetailPage;
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
