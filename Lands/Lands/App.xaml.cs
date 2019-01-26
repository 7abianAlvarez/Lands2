using Lands.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Lands
{
    public partial class App : Application
    {
        #region Constructors
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }

        #endregion

        #region Methods
        protected override void OnStart() //Cuando la app se ejecuta
        {
            // Handle when your app starts
        }

        protected override void OnSleep() //Cuando se ejecuta en segundo plano
        {
            // Handle when your app sleeps
        }

        protected override void OnResume() //Cuando volvemos a la app
        {
            // Handle when your app resumes
        }
        #endregion

    }
}
