using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.BookStore.Parties
{
    public class CreateUpdatePartyDto
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public bool Active { get; set; }
    }
}
