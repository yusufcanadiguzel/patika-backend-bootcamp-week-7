// Bu pratikte sizlerden bir Diziler listesi oluşturmanız ve içerisindeki nesneleri tanımlamanız bekleniyor.

//Yani kullanıcıya her diziyi oluşturup listeye ekledikten sonra yeni bir dizi ekleyip eklemediğini sormamız gerekiyor.
using Patikaflix;

bool isFinished = false;

string userResponse;

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

ListTvSeries();

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

void ListTvSeries()
{
    var tvSeriesList = TvSeriesDto.CreateDtoList(TvSeriesDatas.TvSerieses);

    foreach (var tvSeries in tvSeriesList)
    {
        Console.WriteLine(tvSeries);
    }
}