using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokoviNovca.MVVM.Models;

namespace TokoviNovca.MVVM.ViewModels
{

    [AddINotifyPropertyChangedInterface]
    public class PopisViewModel
    {
        public ObservableCollection<Transaction> Transactions {  get; set; }
        public decimal Balance { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }

        public string FormattedBalance => Balance.ToString("C", CultureInfo.GetCultureInfo("hr-HR"));
        public string FormattedIncome => Income.ToString("C", CultureInfo.GetCultureInfo("hr-HR"));
        public string FormattedExpenses => Expenses.ToString("C", CultureInfo.GetCultureInfo("hr-HR"));
        public PopisViewModel() 
        {
            FillData();
        }

        public void FillData()
        {
            var transactions =
                App.TransactionsRepo.GetItems();
            transactions = transactions.OrderByDescending(x => x.OperationDate).ToList();
            Transactions = new ObservableCollection<Transaction>(transactions);

            Balance = 0;
            Income = 0;
            Expenses = 0;
            foreach (var transaction in Transactions)
            {
                if (transaction.IsIncome)
                {
                    Income += transaction.Amount;
                }
                else
                {
                    Expenses += transaction.Amount;
                }
            }
            Balance=Income-Expenses;
            
        }
    }
}
