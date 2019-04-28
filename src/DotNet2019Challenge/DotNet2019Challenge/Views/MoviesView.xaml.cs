using Autofac;
using DotNet2019Challenge.ViewModels;
using Xamarin.Forms;

namespace DotNet2019Challenge.Views
{
    public partial class MoviesView : ContentPage
    {
        private MoviesViewModel _viewModel;

        public MoviesView()
        {
            InitializeComponent();

            _viewModel = App.Container.Resolve<MoviesViewModel>();
            BindingContext = _viewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await _viewModel.LoadDataAsync();
        }
    }
}