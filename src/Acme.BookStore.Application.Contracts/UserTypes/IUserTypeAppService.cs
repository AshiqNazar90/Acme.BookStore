using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.UserTypes
{
    public interface IUserTypeAppService :
        ICrudAppService< //Defines CRUD methods
            UserTypeDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
          CreateUpdateUserTypeDto> //Used to create/update a book
    {
    }
}
