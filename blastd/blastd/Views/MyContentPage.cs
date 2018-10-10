using blastd.ViewModels;
using Xamarin.Forms;

namespace blastd.Views
{
    public class MyContentPage<TViewModel> : ContentPage 
        where TViewModel : ViewModelBase
    {
        protected TViewModel ViewModel => (TViewModel) BindingContext;

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.Initialize();
        }
    }
}