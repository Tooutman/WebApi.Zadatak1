using Microsoft.AspNetCore.Mvc;
using Zadatak1.Data.Entities;

namespace Zadatak1.UnitTests
{
    public class BookControllerTests(TestFixture fixture) : IClassFixture<TestFixture>
    {
        [Fact]
        public async void BookControler_getBooks_OK()
        {
            // Arrange

            var controller = fixture.controller;
            // Act
            var result = await controller.GetBooks();

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ActionResult<IEnumerable<Book>>>(result);
            var value = result.Value;
            Assert.NotNull(value);
            Assert.IsType<List<Book>>(value);

        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public async void BookControler_getBookById_OK(int bookId)
        {
            // Arrange
            var controller = fixture.controller;
            // Act
            var result = await controller.GetBook(bookId);
            // Assert
            Assert.NotNull(result);
            Assert.IsType<ActionResult<Book>>(result);
            var value = result.Value;
            Assert.NotNull(value);
            Assert.IsType<Book>(value);
        }

        [Theory]
        [InlineData(9999)]

        public async void BookControler_getBookById_NotFound(int bookId)
        {
            // Arrange
            var controller = fixture.controller;
            // Act
            var result = await controller.GetBook(bookId);
            // Assert
            Assert.NotNull(result);
            Assert.IsType<ActionResult<Book>>(result);
            Assert.IsType<NotFoundResult>(result.Result);
        }
    }
}
