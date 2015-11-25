using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace job
{
    public class BookFactory
    {
        public BookInfo getBook(string genre)
        {
            
            switch (genre)
            {
                case ("NonFiction"):
                    return new NonFictionBook();
                    
                default:
                    return new FictionBook();
                    
            }
          

        }  
    }
}
