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
    public partial class CheckBox : ContentPage
    {
        public CheckBox()
        {
            InitializeComponent();
        }

        private void CbToplanti_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value == true)
                lbl_check_box.Text = "Eveeett,bende!";
            else
                lbl_check_box.Text = "Hayır!";

        }
    }
}