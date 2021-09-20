namespace Infrastructure.EF.Migrations
{
    using BankPrj.Domain;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Infrastructure.EF.BankContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Infrastructure.EF.BankContext context)
        {
            IList<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(new BankAccount()
            {
                Balance = 1000,
                BankBranch = "satarKhan",
                BankName = "Saman",
                CartNumber = "111111222",
                CVV2 = "1111",
                ExpirationDate = DateTime.Now,
                //PersonId = 1,
                SecondPass = "111111"

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
