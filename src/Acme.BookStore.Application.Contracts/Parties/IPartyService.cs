using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Parties
{
    public interface IPartyService:
        ICrudAppService<
            PartyDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdatePartyDto
            >
    {
    }
}
