// Bu pratikte sizlerden bir Diziler listesi oluşturmanız ve içerisindeki nesneleri tanımlamanız bekleniyor.

//Yani kullanıcıya her diziyi oluşturup listeye ekledikten sonra yeni bir dizi ekleyip eklemediğini sormamız gerekiyor.
using Patikaflix;

bool isFinished = false;

string userResponse;

// Kullanıcıdan cevap alma
do
{
    Console.Write("Hoşgeldiniz. Yeni bir dizi eklemek ister misiniz? (e/h): ");

    userResponse = Console.ReadLine()!;

    switch (userResponse)
    {
        case "e":
            CreateTvSeries();
            break;

        case "h":
            isFinished = true;
            break;

        default:
            Console.WriteLine("Hatalı giriş yaptınız. Lütfen tekrar deneyiniz.");
            break;
    }
} while (!isFinished);

// Komedi dizilerini listeler
ListComedyTvSeries();

// Kullanıcıdan dizi girişi alma
void CreateTvSeries()
{
    string name, category, director, platform;
    int productionYear, releaseYear;

    Console.Write("Lütfen dizinin ismini giriniz: ");
    name = Console.ReadLine()!;
    Console.WriteLine();

    Console.Write("Lütfen dizinin kategorisini giriniz: ");
    category = Console.ReadLine()!;
    Console.WriteLine();

    Console.Write("Lütfen dizinin yönetmenini giriniz: ");
    director = Console.ReadLine()!;
    Console.WriteLine();

    Console.Write("Lütfen dizinin platformunu giriniz: ");
    platform = Console.ReadLine()!;
    Console.WriteLine();

    Console.Write("Lütfen dizinin yapım yılını giriniz: ");
    productionYear = int.Parse(Console.ReadLine()!);
    Console.WriteLine();

    Console.Write("Lütfen dizinin yayınlanma yılını giriniz: ");
    releaseYear = int.Parse(Console.ReadLine()!);
    Console.WriteLine();

    TvSeriesDatas.TvSerieses.Add(new TvSeries(name: name, productionYear: productionYear, category: category, releaseYear: releaseYear, director: director, platform: platform));

    Console.WriteLine("Dizi başarıyla eklendi.");
}

void ListComedyTvSeries()
{
    // var tvSerieses = TvSeriesDatas.TvSerieses.Where(tvSeries => tvSeries.Category == "Komedi").ToList();
    // tvSerieses.foreach(tvSeries => Console.WriteLine(tvSeries));
    // Yukarıdaki gibi bir yaklaşımda benimsenebilir fakat daha dinamik bir yaklaşımda bulunmayı tercih ettim.

    var tvSeriesList = TvSeriesDto.CreateSpecificCategoryDtoList(TvSeriesDatas.TvSerieses, "Komedi");

    foreach (var tvSeries in tvSeriesList)
    {
        Console.WriteLine(tvSeries);
    }
}