using TokoviNovca.MVVM.ViewModels;

namespace TokoviNovca.MVVM.Views;

public partial class Popis : ContentPage
{
	public Popis()
	{
		InitializeComponent();
		BindingContext=new PopisViewModel();
	}

    private async void AddTransaction_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Transakcije());
    }

    // ne pokazuju se prihodi zato override
    protected override void OnAppearing()
    {
        base.OnAppearing();
        var vm=(PopisViewModel)BindingContext;
        vm.FillData();
    }
}