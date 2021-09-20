namespace BankPrj.Domain
{
    public interface IBankAccountRepository
    {
        int Update(BankAccount entity);
        BankAccount GetByCartNumber(string cartNumber);
    }
}
