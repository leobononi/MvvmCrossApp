using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvvmApp.Core
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAll();
        Task<Book> Add(string title, string author, string genre);
        Task Update(Book book);
        Task Delete(string isbn);
        Task<Book> GetBookById(string isbn);
    }
}
