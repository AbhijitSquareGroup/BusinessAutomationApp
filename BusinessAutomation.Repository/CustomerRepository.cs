using BusinessAutomation.Database;
using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Repository
{
    public class CustomerRepository :BaseRepository<Customer>
    {
        BusinessAutomationDbContext db;
        public CustomerRepository()
        {
            db = new BusinessAutomationDbContext();
            _db = db;
        }


    }
}
