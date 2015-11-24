using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace job
{
    class Librarian
    {
        public string title;
        public string author;
        public string genre;
        public void inputBookInfo()
        {
            Console.Write("Enter book title: ");
            title = Console.ReadLine();
            Console.Write("Enter book Author: ");
            author = Console.ReadLine();
            Console.Write("Enter book genre: ");
            genre = Console.ReadLine();

        }
        
    }
        
}
