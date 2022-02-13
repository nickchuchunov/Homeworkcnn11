using Microsoft.AspNetCore.Mvc;
using SecureDevelopment_1;
namespace SecureDevelopment_1.Controllers
{
    [Route("api/BookServices")]
    [ApiController]
    public class BookServicesController : Controller
    {
        private readonly BookServices bookServices;


        public BookServicesController(BookServices bookServices) 
        {
            this.bookServices = bookServices;
        }

        [HttpGet]
        [Route("BookList")]
        public List<BookContract> Get() => bookServices.Get();

        [HttpGet]
        [Route("Book/{id}")]
        public ActionResult<BookContract> Get(int id)
        {
            var book = bookServices.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        /*
         public int BookId { get; set; }
        [BsonElement("BookTitle")]
       public string BookTitle { get; set; }

        [BsonElement("NumberPages")]
        public int NumberPages { get; set; }

        [BsonElement("Language")]
        public string Language { get; set; }

        [BsonElement("Author")]
        public string Author { get; set; }

        [BsonElement("ISBN")]
        public string ISBN { get; set; }
         */


        [HttpPost]
        [Route("Create/{BookTitle}/{NumberPages}/{Language}/{Author}/{ISBN}/")]
        public void Create([FromQuery] int NumberPages, [FromQuery] string Language, [FromQuery] string Author, [FromQuery] string ISBN)
        {

            BookContract book = new BookContract();

            
            book.NumberPages = NumberPages;
            book.Language = Language;
            book.Author = Author;
            book.ISBN = ISBN;


            bookServices.Create(book);

          //  return CreatedAtRoute("GetBook", new { id = book.BookId.ToString() }, book);
        }

        [HttpPut]
        [Route("Update/{BookId}/{BookTitle}/{NumberPages}/{Language}/{Author}/{ISBN}/")]
        public IActionResult Update([FromQuery] int BookId, [FromQuery] int NumberPages, [FromQuery] string Language, [FromQuery] string Author, [FromQuery] string ISBN)
        {

            BookContract book = new BookContract();


            book.NumberPages = NumberPages;
            book.Language = Language;
            book.Author = Author;
            book.ISBN = ISBN;


            var _book = bookServices.Get(BookId);

            if (book == null)
            {
                return NotFound();
            }

            bookServices.Update(BookId, book);

            return NoContent();
        }

        [HttpDelete]
        [Route("Delete/{BookId}")]
        public IActionResult Delete(int BookId)
        {
            BookContract book = bookServices.Get(BookId);

            if (book == null)
            {
                return NotFound();
            }

            bookServices.Remove(book);

            return NoContent();
        }



    }
}
