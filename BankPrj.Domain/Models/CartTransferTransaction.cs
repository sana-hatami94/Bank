using System;
using System.Collections.Generic;
using System.Text;

namespace BankPrj.Domain
{
    public class CartTransferTransaction
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public string FromCartNumber { get; set; }
        public string ToCartNumber { get; set; }
        public DateTime Date { get; set; }
        public Guid FollowingNumber { get; set; }
    }
}
