using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyMoney.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DateView : ContentView
    {
        public DateView()
        {
            InitializeComponent();

            flowListView.FlowItemsSource = new List<string> { "DSD" };

        }
    }
}