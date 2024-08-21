// Kitapları ve yazarları birleştiren bir LINQ sorgusu oluşturun. Bu sorgu, her kitabın başlığını ve yazarının adını içermelidir.

using LinqJoin;

var authorBooks = from author in AuthorBookDatas.Authors
                  join book in AuthorBookDatas.Books
                  on author.Id equals book.AuthorId
                  select new
                  {
                      BookTitle = book.Title,
                      AuthorName = author.Name
                  };

foreach (var authorBook in authorBooks)
{
    Console.WriteLine($"{authorBook.BookTitle} - {authorBook.AuthorName}");
}