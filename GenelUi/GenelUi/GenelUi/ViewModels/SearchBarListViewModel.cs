using GenelUi.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace GenelUi.ViewModels
{
    public class SearchBarListViewModel
    {
        public ObservableCollection<MyListModel> MyListCollector
        {
            get; set;
        }
        public SearchBarListViewModel()
        {
            MyListCollector = new ObservableCollection<MyListModel>()
            {
                new MyListModel(){ MyName="Ebrar",MyDetail="Dumlupınar Üniversitesi",Image=""},
            new MyListModel() { MyName = "Ebrar", MyDetail = "Dumlupınar Üniversitesi", Image = "" },
            new MyListModel() { MyName = "Ali", MyDetail = "Dumlupınar Üniversitesi", Image = "" },
            new MyListModel() { MyName = "Büşra", MyDetail = "Dumlupınar Üniversitesi", Image = "" },
            new MyListModel() { MyName = "Ceyda", MyDetail = "Dumlupınar Üniversitesi", Image = "" },

            new MyListModel() { MyName = "Deniz", MyDetail = "Dumlupınar Üniversitesi", Image = "" },
            new MyListModel() { MyName = "Fatma", MyDetail = "Dumlupınar Üniversitesi", Image = "" },
            new MyListModel() { MyName = "Gediz", MyDetail = "Dumlupınar Üniversitesi", Image = "" },
            new MyListModel() { MyName = "Hakan", MyDetail = "Dumlupınar Üniversitesi", Image = "" },

            new MyListModel() { MyName = "Işık", MyDetail = "Dumlupınar Üniversitesi", Image = "" },
            new MyListModel() { MyName = "İlayda", MyDetail = "Dumlupınar Üniversitesi", Image = "" },
            new MyListModel() { MyName = "Kemal", MyDetail = "Dumlupınar Üniversitesi", Image = "" },
            new MyListModel() { MyName = "Leyla", MyDetail = "Dumlupınar Üniversitesi", Image = "" }
        };
        }
        }
        
}
    

