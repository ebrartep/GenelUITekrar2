using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GenelUi.Ui
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebView : ContentPage
    {
        public WebView()
        {
            InitializeComponent();
        }

        private void GetData_OnClicked(object sender, EventArgs e)
        {
            var url = "http://"+urlEntry.Text;
            Browser.Source = url;
        }
    }
}