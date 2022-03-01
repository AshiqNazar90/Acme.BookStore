using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Departments
{
    public class Department:FullAuditedAggregateRoot<Guid>
    {

        public string Code { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

    }
}
