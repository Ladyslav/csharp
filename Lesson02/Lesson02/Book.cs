using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    public class Book
    {
        public string Author { get; private set; }
        public string Title;
        private int _numberOfPages;
       private DateTime _dateOfPublish;
        private string category;


        public Book(string author, string title)
        {
            Author = author;
            Title = title;
        }
        public Book(string author)
        {
            Author = author;
        }
    }
}
