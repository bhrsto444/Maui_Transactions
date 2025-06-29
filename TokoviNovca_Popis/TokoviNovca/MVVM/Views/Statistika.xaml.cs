using TokoviNovca.MVVM.ViewModels;

namespace TokoviNovca.MVVM.Views;

public partial class Statistika : ContentPage
{
	public Statistika()
	{
		InitializeComponent();
		BindingContext = new StatistikaViewModel();
	}
    protected override void OnAppearing()
    {
        var vm = (StatistikaViewModel)BindingContext;
        vm.GetTransactionsSummary();
    }
}