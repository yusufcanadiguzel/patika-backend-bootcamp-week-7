using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoin
{
    internal class Book
    {
        public Book(int id, string title, int authorId)
        {
            Id = id;
            Title = title;
            AuthorId = authorId;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
    }
}
