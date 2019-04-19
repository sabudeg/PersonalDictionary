using SQLite;
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
            string input;
            input = searchEntry.Text;

            switch (switchButton.Text)
            {
                case "TR > EN":
                    {

                        //translatedWord.Text = App.DictionaryDb.conn.Table<Words>().Where(k => k.Turkish == input).FirstOrDefault().English;
                        Word w = App.DictionaryDb.conn.Query<Word>("Select * From Words WHERE Turkish=?", input).FirstOrDefault();
                        translatedWord.Text = w.English;
                        break;
                    }
                case "EN > TR":
                    {
                        translatedWord.Text = App.DictionaryDb.conn.Table<Word>().Where(k => k.English == input).FirstOrDefault().Turkish;
                        //Word w = App.DictionaryDb.conn.Query<Word>("Select * From [Word] WHERE English=?, input").FirstOrDefault();
                        //translatedWord.Text = w.Turkish;
                        break;
                    }
            }
        }

        private void ConfigButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConfigPage());
        }

        private void SwitchButton_Clicked(object sender, EventArgs e)
        {
            switch (switchButton.Text) { 
                case "TR > EN":
                    switchButton.Text = "EN > TR";
                    break;

                case "EN > TR":
                    switchButton.Text = "TR > EN";
                    break;
            }

        }
    }
}
