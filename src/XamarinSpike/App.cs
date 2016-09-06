namespace XamarinSpike
{
    using FreshMvvm;
    using Xamarin.Forms;

    public class App: Application
    {
        public App()
        {
            var page = FreshPageModelResolver.ResolvePageModel<UserListPageModel>();
            var navigationContainer = new FreshNavigationContainer( page );
            MainPage = navigationContainer;
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
