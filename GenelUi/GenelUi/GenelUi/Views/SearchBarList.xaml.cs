using GenelUi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GenelUi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchBarList : ContentPage
    {
        public SearchBarList()
        {
            InitializeComponent();
            BindingContext = new SearchBarListViewModel();
        }
        void Handle_TextChanged(object sender,Xamarin.Forms.TextChangedEventArgs e)
        {
            var _container= BindingContext as SearchBarListViewModel;
            EmployeeListView.BeginRefresh();
            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                EmployeeListView.ItemsSource = _container.MyListCollector;

            }
            else
            {
                EmployeeListView.ItemsSource = _container.MyListCollector.Where(i => i.MyName.Contains(e.NewTextValue));
  
                    
            }
            EmployeeListView.EndRefresh();
        }

        void Handle_Clicked(object sender,System.EventArgs e)
        {
            var _container = BindingContext as SearchBarListViewModel;
            DisplayAlert("Başarılı", "You have subscribed", "Tamam", "İptal");
        }
    }
}