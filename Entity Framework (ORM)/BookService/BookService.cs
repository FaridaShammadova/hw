using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework__ORM_
{
    public class BookService : IBookService
    {
        public void Create(Book book)
        {
            AppDbContext context = new AppDbContext();

            context.Books.Add(book);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            AppDbContext context = new AppDbContext();

            var book = context.Books.FirstOrDefault(b => b.Id == id);

            if (book is null) throw new NullReferenceException("Book not found");
            context.Books.Remove(book);
            context.SaveChanges();
        }

        public List<Book> GetAll()
        {
            List<Book> allBooks = new List<Book>();

            AppDbContext context = new AppDbContext();

            allBooks = context.Books.ToList();
            return allBooks;
        }

        public Book GetById(int id)
        {
            AppDbContext context = new AppDbContext();

            var book = context.Books.Include(x=>x.Genre).FirstOrDefault(b => b.Id == id);

            if (book is null) throw new NullReferenceException("Book not found");
            return book;
        }

        public void Update(int id, Book book)
        {
            AppDbContext context = new AppDbContext();

            var existBook = context.Books.FirstOrDefault(b => b.Id == id);

            if (existBook is null) throw new NullReferenceException("Book not found.");

            existBook.Name = book.Name;
            existBook.SalePrice = book.SalePrice;
            existBook.CostPrice = book.CostPrice;

            context.SaveChanges();
        }
    }
}
