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
    public partial class Slider : ContentPage
    {
        public Slider()
        {
            InitializeComponent();
        }

        private void MainSlider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            MainLabel.Text = MainSlider.Value.ToString();
        }
    }
}