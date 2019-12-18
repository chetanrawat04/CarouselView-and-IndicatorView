using CarouselViewDemo.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarouselViewPage : ContentPage
	{
        CarouselViewModel a = null;
        public CarouselViewPage ()
		{
			InitializeComponent ();
            int slidePosition = 0;
             a =  new ViewModels.CarouselViewModel();
            this.BindingContext = a;
           
            Device.StartTimer(TimeSpan.FromSeconds(5), () =>
            {
                if (a.Items.Count == 0 || a.Items == null)
                {
                    return true;
                }
                slidePosition++;
                if (slidePosition == a.Items.Count) slidePosition = 0;
                carouselView.Position = slidePosition;
                return true;
            });
        }
    }
}