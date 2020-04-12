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
    public partial class Switch : ContentPage
    {
        public Switch()
        {
            InitializeComponent();
        }

       

        private void Switch_OnToggled(object sender, ToggledEventArgs e)
        {
            bool isToggled = e.Value;
            SwitchLabel.Text = isToggled.ToString();
        }
    }
}