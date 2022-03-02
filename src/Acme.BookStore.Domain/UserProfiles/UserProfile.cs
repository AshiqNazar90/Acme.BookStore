using Acme.BookStore.UserAccounts;
using Acme.BookStore.UserTransactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.UserProfiles
{
    public class UserProfile:AuditedEntity<Guid>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age  { get; set; }

        public DateTime DateofBirth { get; set; }
        public string Address { get; set; }

       
        public ICollection<UserAccount> UserAccounts { get; set; }

    }
}
