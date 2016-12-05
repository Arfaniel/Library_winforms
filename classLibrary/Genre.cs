using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeLibrary.classLibrary
{
    public class Genre
    {
        public string genreName;
        public Genre(string name)
        {
            genreName = name;
        }
        public override string ToString()
        {
            return genreName;
        }
    }
}