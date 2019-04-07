using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PersonalDictionary
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
                InitializeComponent();

            
        }

        private void SearchButton_Clicked(object sender, EventArgs e)
        {
            searchButton.Focus();
        }

        private void ConfigButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConfigPage());
        }
    }
}
