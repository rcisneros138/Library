using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace job
{
    class FictionBook:BookInfo
    {
        public string getTitle()
        {
            return title;
        }
        public string bookAuthor()
        {
            return author;
        }
        public string bookGenre()
        {
            return genre;
        }
    }
}
