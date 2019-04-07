using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SQLite;
using System.Text.RegularExpressions;

namespace PersonalDictionary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {

        static SQLiteConnection connection;

        public Login()
        {
            InitializeComponent();

        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {

            User user = new User(email.Text, password.Text);

            if (Authenticate(user))
                Navigation.PushAsync(new MainPage());
        }


        private bool Authenticate(User user)
        {
            try
            {

                var emailPattern = ".+\\@.+\\..+";
                var passwordPattern = "^.{5,}$";


                if (Regex.IsMatch(email.Text, emailPattern))
                {
                    emailerror.IsVisible = false;
                    email.BackgroundColor = Color.Transparent;

                    if (Regex.IsMatch(password.Text, passwordPattern)){
                        return true;
                    }
                    else {
                        passworderror.IsVisible = true;
                        password.BackgroundColor = Color.Red;
                        password.Focus();
                        return false;
                    }
                }
                else
                {
                    email.BackgroundColor = Color.Red;
                    emailerror.IsVisible = true;
                    email.Focus();
                    return false;
                }

            }
            catch (ArgumentNullException e)
            {
                nullEntry.IsVisible = true;
                return false;
            }
        }

    }

}