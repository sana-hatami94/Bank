using BankPrj.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Infrastructure.EF
{
    public class UniDBInitializer<T>: CreateDatabaseIfNotExists<BankContext>
    {
        protected override void Seed(BankContext context)
        {
            IList<Person> people = new List<Person>();
            people.Add(new Person { Id = 1, LastName = "h", Name = "s", MobileNo = "0912" });
            
            IList<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(new BankAccount()
            {
                Balance = 1000,
                BankBranch = "satarKhan",
                BankName = "Saman",
                CartNumber = "111111222",
                CVV2 = "1111",
                ExpirationDate = DateTime.Now,
                //PersonId=1,
                SecondPass="111111"

            });

            bankAccounts.Add(new BankAccount()
            {
                Balance = 1000,
                BankBranch = "satarKhan",
                BankName = "Saman",
                CartNumber = "222222111",
                CVV2 = "1111",
                ExpirationDate = DateTime.Now,
                //PersonId = 1,
                SecondPass = "222222"

            });


            bankAccounts.Add(new BankAccount()
            {
                Balance = 1000,
                BankBranch = "satarKhan",
                BankName = "Saman",
                CartNumber = "333333222",
                CVV2 = "1111",
                ExpirationDate = DateTime.Now,
                //PersonId = 1,
                SecondPass = "333333"

            });
            
            foreach (var item in bankAccounts)
                context.BankAccount.Add(item);
            base.Seed(context);
        }
    }
}
