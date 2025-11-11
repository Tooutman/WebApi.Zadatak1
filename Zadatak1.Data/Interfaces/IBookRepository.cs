using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak1.Data.Entities;

namespace Zadatak1.Data.Interfaces
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllBooksAsync();

        Task<Book?> GetBookByIdAsync(int id);

        Task<int> AddBookAsync(Book book);

        Task UpdateBookAsync(Book book);

        Task DeleteBookAsync(int id);

        bool BookExists(int id);
    }
}
