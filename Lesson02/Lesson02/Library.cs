using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Library
    {
        Book ProvideBook()
        {
           var book = new Book("Rej Bredberi", "Book");
            book.Author = "stephen King";
            book.Title = "Four Seasons";
            return new Book();
        }
    }
}
