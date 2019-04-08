using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        //private void NewWord_Clicked(object sender, EventArgs e)
        //{
        //    switch (addView.IsVisible)
        //    {
        //        case false:
        //            addView.IsVisible = true;
        //            break;
        //        case true:
        //            addView.IsVisible = false;
        //            break;
        //    }
        //}

        //private void UpdateWord_Clicked(object sender, EventArgs e)
        //{
        //    switch (updateView.IsVisible)
        //    {
        //        case false: updateView.IsVisible = true;
        //            break;
        //        case true: updateView.IsVisible = false;
        //            break;
        //    }
           
        //}

        //private void DeleteWord_Clicked(object sender, EventArgs e)
        //{
        //    switch (deleteView.IsVisible)
        //    {
        //        case false:
        //            deleteView.IsVisible = true;
        //            break;
        //        case true:
        //            deleteView.IsVisible = false;
        //            break;
        //    }
        //}

        private void AddButton_Clicked(object sender, EventArgs e)
        {
            App.DictionaryDb.AddNewWord(new Word(tr.Text, en.Text));
            //App.DictionaryDb.conn.Query<Word>("INSERT INTO Words (Turkish, English) VALUES (?, ?)", tr.Text, en.Text);
        } 

        private void UpdateButton_Clicked(object sender, EventArgs e)
        {
            App.DictionaryDb.UpdateWord(new Word(tr.Text, tr.Text));
        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            App.DictionaryDb.DeleteWord(new Word(tr.Text, en.Text));
        }
    }
}