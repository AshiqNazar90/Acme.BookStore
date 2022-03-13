using Acme.BookStore.UserAccounts;
using Acme.BookStore.UserProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.UserTransactions
{
    public class UserTransaction: AuditedEntity<Guid>
    {
    
        public int Amount { get; set; }
        public DateTime DateTime { get; set; }

        public Guid UserID { get; set; }
        public UserProfile UserProfile { get; set; }

        public ICollection<UserAccount> UserAccounts { get; set; }
    }
}
