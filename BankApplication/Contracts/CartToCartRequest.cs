using System;

namespace BankApplication.Contracts
{
    public class CartToCartRequest
    {
        public string FromCartNumber { get; set; }
        public string ToCartNumber { get; set; }
        public string SecondPass { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string CVV2 { get; set; }
        public double Amount { get; set; }
    }
}
