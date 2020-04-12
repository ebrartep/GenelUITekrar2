using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace GenelUi.ViewModels
{
   public class PickerViewModel :INotifyPropertyChanged
    {
        public List<City> CitiesList { get; set; }

 

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private City _selectedCity { get; set; }
        public City SelectedCity
        {
            get { return _selectedCity; }
            set
            {
                if(_selectedCity != value)
                {
                    _selectedCity = value;
                    MyCity = "Seçilen Şehir: " + _selectedCity;
                }
            }
        }

        private string _myCity;
        public string MyCity
        {
            get { return _myCity; }
            set
            {
                if (_myCity != value)
                {
                    _myCity = value;
                    OnPropertyChanged();
                }
            }
        }
        public PickerViewModel()
        {
            CitiesList = GetCities().OrderBy(t => t.Value).ToList();
        }

        public List<City> GetCities()
        {
            var cities = new List<City>()
            {
                new City(){Key = 1 ,Value="İstanbul "},
                new City(){Key = 2 ,Value="Kütahya"},
                new City(){Key = 3 ,Value="Eskişehir"},
                new City(){Key = 4 ,Value="Bursa"},
                new City(){Key = 5 ,Value="Balıkesir"},
                new City(){Key = 6 ,Value="Sakarya"},
                new City(){Key = 7 ,Value="Afyon"},
                new City(){Key = 8 ,Value="Çanakkale"}

            };
            return cities;
        }
        


    }
    public class City
    {
        public int Key { get; set; }
        public string Value { get; set; }
    }
}
