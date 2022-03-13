﻿using Acme.BookStore.UserProfiles;
using Acme.BookStore.UserTransactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.UserAccounts
{
    public class UserAccount:AuditedEntity<Guid>
    {
      
        public string BankName { get; set; }
        public int ActNumber { get; set; }

        public string UserName { get; set; }
        public DateTime DateofBrith { get; set; }

        public Guid UserID { get; set; }
        public UserProfile UserProfile { get; set; }

        public Guid UserTransactionID { get; set; }
        public UserTransaction UserTransaction { get; set; }
    }
}
