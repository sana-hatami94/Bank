using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankPrj.Domain
{ 
    public class BankAccount
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public string BankBranch { get; set; }
        public string CartNumber { get; set; }
        public string CVV2 { get; set; }
        public string SecondPass { get; set; }
        public double Balance { get; set; }
        public DateTime ExpirationDate { get; set; }
        //public int PersonId { get; set; }
        //public Person Person { get; set; }

    }
}
