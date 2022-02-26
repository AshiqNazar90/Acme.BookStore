using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.UserTypes
{
    public class UserTypeAppService :
         CrudAppService<
           UserType, //The Book entity
           UserTypeDto, //Used to show books
           Guid, //Primary key of the book entity
           PagedAndSortedResultRequestDto,//Used for paging/sorting
        CreateUpdateUserTypeDto>, //Used to create/update a book
       IUserTypeAppService //implement the IBookAppService
    {
        public UserTypeAppService(IRepository<UserType, Guid> repository)
            : base(repository)
        {

        }
        
    }
}
