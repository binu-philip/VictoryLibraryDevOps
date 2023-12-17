using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VictoryLibraryAPI.Model;

namespace VictoryLibraryAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        List<Book> books = new List<Book>();
        public BooksController()
        {          
            books.Add(new Book { Id=1 ,Title = "If Tomorrow comes", Author = "Sydney Sheldon", Genere = "Novel" });
            books.Add(new Book { Id=2,Title = "The Story of My Experiments with Truth", Author = "MK Gandhi", Genere = "AutoBiography" });
        }
        [HttpGet]
        public List<Book> Get()
        { 
        
          return books;
        }
        [HttpPost]
        public List<Book> Post(Book book)
        {
            books.Add(book);
            return books;
        }
        [HttpPut]
        public List<Book> Put(Book book)
        {
            var selectedBook = books.FirstOrDefault(x => x.Id == book.Id);
            books.Remove(selectedBook);           
            books.Add(book);
            return books;
        }
        [HttpDelete]
        public List<Book> Delete(int id)
        {
            var selectedBook = books.FirstOrDefault(x=>x.Id==id);
            books.Remove(selectedBook);         
            return books;
        }
    }
}
