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
    public partial class Picker : ContentPage
    {
        public Picker()
        {
            InitializeComponent();

            /* PickerName.Items.Add("Erik");
             PickerName.Items.Add("Kiraz");
             PickerName.Items.Add("Karpuz");
             PickerName.Items.Add("Elma");
             PickerName.Items.Add("Portakal");
             PickerName.Items.Add("Mandalina");


         }

         private void PickerName_SelectedIndexChanged(object sender, EventArgs e)
         {
             var name = PickerName.Items[PickerName.SelectedIndex];
             DisplayAlert(name, "Meyve : ", "OK");
         }*/

            BindingContext = new ViewModels.PickerViewModel();
        }
    }
}