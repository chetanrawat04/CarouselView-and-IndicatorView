using CarouselViewDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace CarouselViewDemo.ViewModels
{
    public class CarouselViewModel : INotifyPropertyChanged
    {
        ObservableCollection<CarouselModel> _Items;
        ObservableCollection<CarouselModel> _Items1;
        public ObservableCollection<CarouselModel> Items
        {
            get
            {
                return _Items;
            }
            set
            {
                _Items = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<CarouselModel> Items1
        {
            get
            {
                return _Items1;
            }
            set
            {
                _Items1 = value;
                OnPropertyChanged();
            }
        }


        public CarouselViewModel()
        {
            Items = new ObservableCollection<CarouselModel>();
            Items1 = new ObservableCollection<CarouselModel>();
            AddItems();
            AddItems1();
        }

        void AddItems()
        {
            _Items.Add(new CarouselModel { Images = "Bg1.jpg", BgColors = Color.White });
            _Items.Add(new CarouselModel { Images = "Bg2.png", BgColors = Color.White});
            _Items.Add(new CarouselModel { Images = "Bg3.jpg", BgColors = Color.White });
            _Items.Add(new CarouselModel { Images = "spiderman.png", BgColors = Color.Blue });
            _Items.Add(new CarouselModel { Images = "Bg2.png", BgColors = Color.White });
        }

        void AddItems1()
        {
            _Items1.Add(new CarouselModel { Images = "Bg4.jpg", BgColors = Color.White });
            _Items1.Add(new CarouselModel { Images = "Bg5.jpg", BgColors = Color.White });
            _Items1.Add(new CarouselModel { Images = "Bg6.jpg", BgColors = Color.White });
            _Items1.Add(new CarouselModel { Images = "Bg7.jpg", BgColors = Color.White });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
