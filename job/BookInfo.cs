using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace job
{
    abstract class BookInfo
    {
        
        Librarian librarian = new Librarian();
        public  string title
        {
            get { return librarian.title; }
            set { librarian.title = value; }
        }
        public string author
        {
            get { return librarian.author; }
            set { librarian.author = value; }
        }
        public string genre
        {
            get { return librarian.author; }
            set { librarian.author = value; }
        }

    }
}
