using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PersonalDictionary
{
    public partial class App : Application
    {
        public static DictionaryDatabase DictionaryDb { get; private set; }

        public App(string dbPath)
        {
            InitializeComponent();

            DictionaryDb = new DictionaryDatabase(dbPath);

            MainPage = new NavigationPage(new Login());

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
