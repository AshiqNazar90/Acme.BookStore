using Acme.BookStore.Books;
using Acme.BookStore.Parties;

namespace Acme.BookStore.UserTypes
{
    public class CombainedData
    {

        public BookDto Book { get; set; }
        public PartyDto Partie { get; set; }
    }
}