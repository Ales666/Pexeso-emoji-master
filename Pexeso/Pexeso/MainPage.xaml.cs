using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using SQLite;

namespace Pexeso
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //presmerovani na Easy, kde je lehka obtiznost
        public void EasyMove(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Easy());
        }

        //presmerovani na Medium, kde je stredni obtiznost
        public void MediumMove(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Medium());
        }

        //presmerovani na Hard, kde je tezka obtiznost
        public void HardMove(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Hard());
        }
    }
}
