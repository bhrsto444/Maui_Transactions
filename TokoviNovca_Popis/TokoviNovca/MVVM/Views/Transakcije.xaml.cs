using TokoviNovca.MVVM.ViewModels;

namespace TokoviNovca.MVVM.Views;

public partial class Transakcije : ContentPage
{
	public Transakcije()
	{
        InitializeComponent();
		BindingContext=new TransakcijeViewModel();
	}

    private async void Save_Clicked(object sender, EventArgs e)
    {
        var currentVM=
            (TransakcijeViewModel)BindingContext;
        var message =
            currentVM.SaveTransaction();
        await DisplayAlert("Info", message, "ok");
        await Navigation.PopToRootAsync();
    }

    private async void Cancel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
    
}