using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseResourcePlanning.Models
{
    public enum TransactionType
    {
        Income,
        Expense
    }
    public class Transaction
    {
        public DateTime TransactionDate { get; set; }

        public TransactionType Type { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}
