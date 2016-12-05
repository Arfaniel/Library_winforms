using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeLibrary.classLibrary
{
    class Book
    {
        public string _title;
        public string _autor;
        public List<Genre> _genre = new List<Genre>();
        public Book(string title, string author, Genre genre)
        {
            _title = title;
            _autor = author;
            _genre.Add(genre);
        }
        public override string ToString()
        {
            return _title;
        }
    }
}
