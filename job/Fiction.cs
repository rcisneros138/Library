using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace job
{
    class Fiction: BookInfo
    {
       
        public  string getTitle()
        {
            return title;
        }
        public  string getGenre()
        {
            return genre;
        }
        public  string getAuthor()
        {
            return author;
        }

    }
}
