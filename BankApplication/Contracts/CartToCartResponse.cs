namespace BankApplication.Contracts
{
    public class CartToCartResponse
    {
        public StatusCodeEnum StatusCode { get; set; }
        public string Remark { get; set; }
        public string FollowingNumber { get; set; }
        public int TransactionId { get; set; }
    }
}
