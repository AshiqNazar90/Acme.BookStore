using Acme.BookStore.Books;
using Acme.BookStore.Departments;
using Acme.BookStore.Parties;
using Acme.BookStore.UserTypes;
using AutoMapper;

namespace Acme.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<UserType, UserTypeDto>();
        CreateMap<CreateUpdateUserTypeDto, UserType>();
        CreateMap<Party, PartyDto>();
        CreateMap<CreateUpdatePartyDto, Party>();
        CreateMap<Department, DepartmentDto>();
        CreateMap<CreateUpdateDepartmentDto, Department>();
    }
}
