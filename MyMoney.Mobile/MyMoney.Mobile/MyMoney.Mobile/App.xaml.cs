using DLToolkit.Forms.Controls;
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

            FlowListView.Init();
        }

		protected override void OnStart ()
		{
            var masterDetailPage = new MasterDetailPage
            {
                Master = new LeftMenuView { Title = "Menu" },
                Detail = new NavigationPage(new MainPage { Title = "Main Page" })
            };

            MainPage = masterDetailPage;
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
