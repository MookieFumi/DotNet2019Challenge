using Autofac;
using DotNet2019Challenge.Views;
using Xamarin.Forms;
using DotNet2019Challenge.ViewModels;
using DotNet2019Challenge.Services.Movies;

namespace DotNet2019Challenge
{
    public partial class App : Application
    {
        public static IContainer Container;

        public App()
        {
            InitializeComponent();

            var builder = new ContainerBuilder();
            RegisterDependencies(builder);
            Container = builder.Build();

            MainPage = new NavigationPage(new MoviesView());
        }

        private void RegisterDependencies(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<MoviesService>().As<IMoviesService>();
            containerBuilder.RegisterType<MoviesViewModel>();
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
