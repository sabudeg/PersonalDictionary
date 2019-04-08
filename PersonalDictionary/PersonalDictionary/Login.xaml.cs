using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SQLite;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace PersonalDictionary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public SQLiteConnection conn;

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

                    if (Regex.IsMatch(password.Text, passwordPattern))
                    {
                        try
                        {
                            Debug.WriteLine( conn.Table<User>().Where(u => u.Email == user.Email && u.Password == user.Password).FirstOrDefault().ToString() ); 

                            conn.Insert(user);
                            Debug.WriteLine("new user");
                            //TOAST NEW USER 
                            return true;
                        }
                        catch (Exception e)
                        {
                            Debug.WriteLine("user already exists");
                            //TOAST USER EXISTS
                            return true;
                        }

                    }
                    else
                    {
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