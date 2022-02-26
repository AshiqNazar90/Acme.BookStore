using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Parties
{
    public class PartyService:
        CrudAppService<
            Party,
            PartyDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdatePartyDto>,
        IPartyService
    {
        public PartyService(IRepository<Party, Guid> repository):base(repository)
        {

        }
    }
}
