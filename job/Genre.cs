using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace job
{
    class Genre:BookInfo
    {
        string bookGenre;
        public void getGenre()
        {
            bookGenre = genre;
        }
        
        public void checkGenre()
        {
            switch (bookGenre)
            {
                case ("Horror"):
                    //pass book title, author, and horror
                    break;
                case ("Biography"):
                    //pass book title, author, and horror
                    break;

            }
        }
    }
}
