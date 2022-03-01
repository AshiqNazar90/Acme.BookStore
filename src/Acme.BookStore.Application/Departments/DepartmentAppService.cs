using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Departments
{
    public class DepartmentAppService :
         CrudAppService<
            Department, //The Book entity
             DepartmentDto,//Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateDepartmentDto>,
    IDepartmentAppService
    {
        public DepartmentAppService(IRepository<Department, Guid> repository)
            : base(repository)
        {

        }
    }
}
