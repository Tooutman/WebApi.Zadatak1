using System.ComponentModel.DataAnnotations;

namespace Zadatak1.Data.Entities
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublishedDate { get; set; }
        public bool isAvailable { get; set; }   
    }
}
