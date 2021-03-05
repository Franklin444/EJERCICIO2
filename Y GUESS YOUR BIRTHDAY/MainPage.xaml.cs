using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Y_GUESS_YOUR_BIRTHDAY
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            var happy = (Convert.ToInt32 (Final.Text)-365);

            DisplayAlert("Tu fecha de cumpleaños es...", happy.ToString(), "Te adivine verdad");
             
            Fin.Text =happy.ToString();

            hola.Text = Fin.Text.Substring(0,2);
            hol.Text = Fin.Text.Substring(Fin.Text.Length -2);
        }
    }
}

