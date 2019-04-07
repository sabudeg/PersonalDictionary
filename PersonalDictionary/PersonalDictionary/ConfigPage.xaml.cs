using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PersonalDictionary
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConfigPage : ContentPage
	{
		public ConfigPage ()
		{
			InitializeComponent ();
		}

        private void NewWord_Clicked(object sender, EventArgs e)
        {
            switch (addView.IsVisible)
            {
                case false:
                    addView.IsVisible = true;
                    break;
                case true:
                    addView.IsVisible = false;
                    break;
            }
        }

        private void UpdateWord_Clicked(object sender, EventArgs e)
        {
            switch (updateView.IsVisible)
            {
                case false: updateView.IsVisible = true;
                    break;
                case true: updateView.IsVisible = false;
                    break;
            }
           
        }

        private void DeleteWord_Clicked(object sender, EventArgs e)
        {
            switch (deleteView.IsVisible)
            {
                case false:
                    deleteView.IsVisible = true;
                    break;
                case true:
                    deleteView.IsVisible = false;
                    break;
            }
        }

        private void addButton_Clicked(object sender, EventArgs e)
        {
            App.DictionaryDb.AddNewWord(new Word(addTr.Text, addEn.Text));
        }

        private void UpdateButton_Clicked(object sender, EventArgs e)
        {
            App.DictionaryDb.UpdateWord(new Word(addTr.Text, addEn.Text));
        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            App.DictionaryDb.DeleteWord(new Word(addTr.Text, addEn.Text));
        }
    }
}