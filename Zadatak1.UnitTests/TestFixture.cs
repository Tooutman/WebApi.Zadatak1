using Zadatak1.API.Controllers;
using Zadatak1.Data;
using Zadatak1.Data.Repos;

namespace Zadatak1.UnitTests
{
    public class TestFixture : IDisposable
    {
        internal BooksController controller { get; }
        public TestFixture()
        {
            var dbContext = new AppDbContext();
            var repository = new BookRepository(dbContext);
            controller = new BooksController(repository);
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
