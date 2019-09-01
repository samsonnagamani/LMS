using System.Collections.Generic;
using System.Linq;
using LMS.Data;
using LMS.Models;
using Microsoft.EntityFrameworkCore;

namespace LMS.Repositories
{
    public class MockBookRepository : IBookRepository
    {
        private readonly LibraryContext _context;

        public MockBookRepository(LibraryContext context)
        {
            _context = context;
        }

        public BookModel GetBookById(int id)
        {
            return _context.Books.Find(id);
        }

        public IEnumerable<BookModel> GetAllBooks()
        {
            return _context.Books;
        }

        public BookModel Add(BookModel book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return book;
        }

        public BookModel Update(BookModel bookChanges)
        {
            var entity = _context.Books.FirstOrDefault(b => b.Id == 11);

            // Validate entity is not null
            if (entity != null)
            {
                // Answer for question #2

                // Make changes on entity
                entity.Author = bookChanges.Author;
                entity.Genre = bookChanges.Genre;
                entity.Title = bookChanges.Title;
                entity.Rating = bookChanges.Rating;
                entity.ReplacementPrice = bookChanges.ReplacementPrice;
                entity.Status = bookChanges.Status;

                // Update entity in DbSet
                _context.Books.Update(entity);
                
                _context.Entry(entity).State = EntityState.Modified;

                // Save changes in database
                _context.SaveChanges();
            }
            
            return bookChanges;
        }

        public BookModel DeleteById(int id)
        {
            BookModel book = _context.Books.Find(id);
            if (book == null) return book;
            _context.Books.Remove(book);
            _context.SaveChanges();

            return book;
        }

        public void SwitchStatus(int? id)
        {
            BookModel updatedBook = _context.Books.FirstOrDefault(c => c.Id == id);
            if (updatedBook != null)
            {
                updatedBook.Status = !updatedBook.Status;
                _context.Books.Update(updatedBook);
            }
            

            _context.SaveChanges();
        }
    }
}