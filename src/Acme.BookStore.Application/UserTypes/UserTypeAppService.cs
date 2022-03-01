using Acme.BookStore.Books;
using Acme.BookStore.Parties;
using Microsoft.AspNetCore.Mvc;
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
        IRepository<Book, Guid> bookrepository;
        IRepository<Party, Guid> partiesrepository;
        IRepository<UserType, Guid> usertyperepository;
        public UserTypeAppService(IRepository<UserType, Guid> usertyperepository, 
            IRepository<Book, Guid> bookrepository,
            IRepository<Party, Guid> partiesrepository)
            : base(usertyperepository)
        {
            this.bookrepository=bookrepository;
            this.partiesrepository=partiesrepository;
            this.usertyperepository=usertyperepository;
        }
        
    [HttpGet]
            public async Task<CombainedData> helloAsync()

       
            {
                var bookList = await bookrepository.GetListAsync();
                var partieList = await partiesrepository.GetListAsync();

                var result = new CombainedData();



                result.Book = ObjectMapper.Map<Book, BookDto>(bookList[0]);
            result.Partie = ObjectMapper.Map<Party, PartyDto>(partieList[0]);
                //result.Partie = ObjectMapper.Map<Party, PartyDto>(partieList[0]);


                return result;


        }



    }
}
