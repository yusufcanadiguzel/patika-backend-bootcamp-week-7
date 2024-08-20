using Patikafy;

// Adı 'S' ile başlayan şarkıcılar
Console.WriteLine("Adı 'S' ile başlayan şarkıcılar:");

var singers = from singer in SingerDatas.Singers
                  // where SqlMethods.ILike(singer.FullName, "S%")
              where singer.FullName.StartsWith('S')
              select singer;

foreach (var singer in singers)
{
    Console.WriteLine(singer);
}
Console.WriteLine("-----------------------");

// Albüm satışları 10 milyon'un üzerinde olan şarkıcılar
Console.WriteLine("Albüm satışları 10 milyon'un üzerinde olan şarkıcılar:");
SingerDatas.Singers.Where(singer => singer.AlbumSolds > 10000000).ToList().ForEach(singer => Console.WriteLine(singer));
Console.WriteLine("-----------------------");

// 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. ( Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırınız.
Console.WriteLine("2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar:");

singers = SingerDatas.Singers.Where(singer => (singer.DebutYear < 2000) && (singer.MusicCategory.Contains("Pop")));
singers.GroupBy(singer => singer.DebutYear).Select(group => group.OrderBy(singer => singer.FullName));

foreach (var singer in singers)
{
    Console.WriteLine(singer);
}
Console.WriteLine("-----------------------");

// En çok albüm satan şarkıcı
Console.WriteLine("En çok albüm satan şarkıcı:");
var result = SingerDatas.Singers.MaxBy(singer => singer.AlbumSolds);
Console.WriteLine(result);
Console.WriteLine("-----------------------");

// En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı
Console.WriteLine("En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı");
var singersByDebutYear = SingerDatas.Singers.OrderBy(singer => singer.DebutYear).ToList();
Console.WriteLine($"En yeni çıkış yapan: {singersByDebutYear[singersByDebutYear.Count - 1]}");
Console.WriteLine($"En eski çıkış yapan: {singersByDebutYear[0]}");