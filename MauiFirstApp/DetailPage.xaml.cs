using MauiFirstApp.ViewModel;

namespace MauiFirstApp;

public partial class DetailPage : ContentPage
{
    public DetailPage(DetailViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}