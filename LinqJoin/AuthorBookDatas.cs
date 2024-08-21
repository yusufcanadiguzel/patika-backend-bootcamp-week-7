using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoin
{
    internal class AuthorBookDatas
    {
        public static List<Author> Authors { get; set; }
        public static List<Book> Books { get; set; }

        static AuthorBookDatas()
        {
            Authors = new List<Author>()
            {
                new Author(id: 1, name: "Orhan Pamuk"),
                new Author(id: 2, name: "Elif Şafak"),
                new Author(id: 3, name: "Ahmet Ümit")
            };


            Books = new List<Book>()
            {
                new Book(id: 1, title: "Kar", authorId: 1),
                new Book(id: 2, title: "İstanbul", authorId: 1),
                new Book(id: 1, title: "10 Minutes 38 Seconds In This Strange World", authorId: 2),
                new Book(id: 2, title: "Beyoğlu Rapsodisi", authorId: 3)
            };
        }
    }
}
