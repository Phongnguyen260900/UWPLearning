using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNavigate
{
    public class BookInfo
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }

        public BookInfo(string bookName, string author, string price, string image)
        {
            BookName = bookName;
            Author = author;
            Price = price;
            Image = image;
        }
    }
}
