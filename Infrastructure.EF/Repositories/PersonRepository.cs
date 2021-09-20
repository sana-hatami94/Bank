using BankPrj.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EF.Repositories
{
    public class PersonRepository : IGerericRepository<Person>
    {
        public BankContext _context;
        public PersonRepository(BankContext context)
        {
            this._context = context;
        }
        public int Add(Person entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public Person GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
