using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GenelUi
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ui.Buttons());
        }
        private async void ImageButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ui.ImageButton());
        }
        private async void Image_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ui.Image());
        }
        private async void CheckBox_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ui.CheckBox());
        }
        private async void SearchBar_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.SearchBarList());
        }
        private async void ScrollView_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ui.ScrollView());
        }
    }
}
