using System.Collections.Generic;

namespace LMS.Models
{
    public interface IBookRepository
    {
        BookModel GetBookById(int id);
        IEnumerable<BookModel> GetAllBooks();
        BookModel Add(BookModel book);
        BookModel Update(BookModel bookChanges);
        BookModel DeleteById(int id);

        void SwitchStatus(int? id);
    }
}