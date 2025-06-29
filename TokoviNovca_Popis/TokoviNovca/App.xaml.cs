using TokoviNovca.MVVM.Models;
using TokoviNovca.MVVM.Views;
using TokoviNovca.Repositories;

namespace TokoviNovca
{
    public partial class App : Application
    {
        public static BaseRepository<Transaction> 
            TransactionsRepo {  get; private set; }
        public App(BaseRepository<Transaction> _transactionsRepo)
        {
            InitializeComponent();
            TransactionsRepo = _transactionsRepo;
            //MainPage = new NavigationPage(new Transakcije());
            //MainPage = new NavigationPage(new Popis());
            //MainPage = new Statistika();
            MainPage = new AppContainer();
        }
    }
}
