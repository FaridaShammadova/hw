using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework__ORM_
{
    public interface IBookService
    {
        void Create(Book book);
        Book GetById(int id);
        List<Book> GetAll();
        void Update(int id, Book book);
        void Delete(int id);

    }
}
