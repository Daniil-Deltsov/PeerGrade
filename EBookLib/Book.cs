using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookLib
{
    public class Book : PrintEdition
    {
        private string author;

        public Book(string name, int pages, string author) : base(name, pages)
        {
            this.author = author;
        }
        public string Author
        {
            get { return author; }
        }

        public override string ToString()
        {
            return $"{base.ToString()}; author={author}";
        }
    }
}
