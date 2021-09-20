using BankPrj.Domain;
using System.Data.Entity;

namespace Infrastructure.EF
{
    public class BankContext : DbContext
    {
        public BankContext() : base("BankConnectionString")
        {
         
            Database.SetInitializer<BankContext>(new UniDBInitializer<BankContext>());
            
        }
        public DbSet<BankAccount> BankAccount { get; set; }
        //public DbSet<Person> People { get; set; }
        public DbSet<CartTransferTransaction> CartTransferTransaction { get; set; }

    }
}
