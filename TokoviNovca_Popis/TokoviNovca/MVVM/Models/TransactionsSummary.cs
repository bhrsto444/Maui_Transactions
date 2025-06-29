using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokoviNovca.MVVM.Models
{
    public class TransactionsSummary
    {
        public DateTime TransactionsDate { get; set; }
        public string ShownDate { get; set; }
        public decimal TransactionsTotal {  get; set; }
    }
}
