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
    public partial class OperationsView : ContentView
    {
        public OperationsView()
        {
            InitializeComponent();

            flowListView.FlowItemsSource = new List<string> { "dsadas", "dsadas" , "dsadas" , "dsadas" , "dsadas" , "dsadas" , "dsadas" , "dsadas" , "dsadas" , "dsadas" , "dsadas" , "dsadas" , "dsadas" , "dsadas" , "dsadas" , "dsadas" };

        }
    }
}