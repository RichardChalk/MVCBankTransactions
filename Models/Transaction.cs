using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransactions.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        
        [Column(TypeName ="nvarchar(12)")]
        public string AccountNumber { get; set; } = string.Empty;
        
        
        [Column(TypeName = "nvarchar(100)")]
        public string BenificiaryName { get; set; } = string.Empty;


        [Column(TypeName = "nvarchar(100)")]
        public string BankName { get; set; } = string.Empty;


        [Column(TypeName = "nvarchar(11)")]
        public string SWIFTCode { get; set; } = string.Empty;

        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
