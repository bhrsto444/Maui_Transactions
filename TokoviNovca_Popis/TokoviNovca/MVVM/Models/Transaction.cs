using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokoviNovca.Abstractions;

namespace TokoviNovca.MVVM.Models
{
    public class Transaction: TableData
    {
        /*public Transaction()
        {
            OperationDate = DateTime.Now;
        }*/

        public string Name { get; set; }
        public decimal Amount {  get; set; }
        public bool IsIncome {  get; set; }
        public DateTime OperationDate { get; set; }


    }
}
