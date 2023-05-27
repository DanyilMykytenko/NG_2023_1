using DAL.DbStartUp;
using DAL.Entity;
using DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class AccountRepository : GenericRepository<Account>,IAccountRepository
    {
        public AccountRepository(DBContext dBContext) : base(dBContext) { }
    }
}
