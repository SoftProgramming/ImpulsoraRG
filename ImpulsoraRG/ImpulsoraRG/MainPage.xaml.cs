using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImpulsoraRG
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var url = "http://www.impulsorarg.com/";
            vizualizadorWeb.Source = url;
            vizualizadorWeb.HeightRequest = 1;


        }
        protected override bool OnBackButtonPressed()
        {
            if (vizualizadorWeb.CanGoBack)
            {
                vizualizadorWeb.GoBack();
                return true;
            }
            else
            {
                base.OnBackButtonPressed();
                return false;
            }
        }
    }
}
