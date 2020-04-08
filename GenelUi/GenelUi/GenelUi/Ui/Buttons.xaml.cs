using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GenelUi.Ui
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Buttons : ContentPage
    {

        public ICommand LocalCommand => new Command<string>(KomutButton_OnClicked);
        public Buttons()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void HadiButton_OnClicked(object sender, EventArgs e)
        {
            lbl_hadi_button.Text = "Butona Tıklandı!!";
        }

        private void KomutButton_OnClicked(string astr)
        {
            lbl_komut_button.Text = astr;
        }
    }
}