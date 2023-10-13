using EnterpriseResourcePlanning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseResourcePlanning.Modules
{
    public class FinanceModule : Module
    {
        private List<Transaction> Transactions { get; set; }
        private List<Invoice> Invoices { get; set; }


        public FinanceModule(): base("Finance")
        {
            Transactions = new List<Transaction>();
            Invoices = new List<Invoice>();

        }

        public override void Run()
        {
            base.Run();
            // Add transactions
            AddTransaction(new Transaction
            {
                TransactionDate = DateTime.Now,
                Type = TransactionType.Income,
                Amount = 1000,
                Description = "Sales Income"
            });
            AddTransaction(new Transaction
            {
                TransactionDate = DateTime.Now,
                Type = TransactionType.Expense,
                Amount = 500,
                Description = "Office Outing"

            });

            // Create invoices
            CreateInvoice(new Invoice
            {
                InvoiceNumber = 1,
                DueDate = DateTime.Now.AddMonths(1),
                TotalAmount = 500,
            });

            // Mark an invoice as paid
            MarkInvoiceAsPaid(1);

            // List transactions and invoices
            ListTransactions();
            ListInvoices();

        }

        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
        }

        public void CreateInvoice(Invoice invoice)
        {
            Invoices.Add(invoice);
        }

        public void MarkInvoiceAsPaid(int invoiceId)
        {
            var invoice = Invoices.FirstOrDefault(inv => inv.InvoiceNumber == invoiceId);
            if(invoice != null)
            {
                invoice.IsPaid = true;
            } 
        }

        public void ListTransactions()
        {
            Console.WriteLine("Transactions:");
            foreach (var transaction in Transactions)
            {
                Console.WriteLine($"{transaction.TransactionDate} - {transaction.Type}: {transaction.Amount:C} - {transaction.Description}");
            }
        }

        public void ListInvoices()
        {
            Console.WriteLine("Invoices:");
            foreach (var invoice in Invoices)
            {
                Console.WriteLine($"Invoice #{invoice.InvoiceNumber} - Due Date: {invoice.DueDate:MM/dd/yyyy} - Total Amount: {invoice.TotalAmount:C} - Paid: {invoice.IsPaid}");
            }
        }
    }
}
