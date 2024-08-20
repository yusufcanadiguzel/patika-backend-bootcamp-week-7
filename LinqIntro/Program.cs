// Rastgele 10 adet sayıdan oluşan bir liste oluşturunuz.
var numbers = new List<int>();

Random random = new Random();

for (int i = 0; i < 10; i++)
{
    numbers.Add(random.Next(-100, 101));
}

//Listenin elemanları
Console.Write("Listedeki sayılar: ");
numbers.ForEach(number => Console.Write(number.ToString() + " "));
Console.WriteLine();

// Çift olan sayılar
Console.Write("Çift olan sayılar: ");
numbers.Where(number => number % 2 == 0).ToList().ForEach(evenNumber => Console.Write(evenNumber + " "));
Console.WriteLine();

// Tek olan sayılar
Console.Write("Tek olan sayılar: ");
numbers.Where(number => number % 2 != 0).ToList().ForEach(oddNumber => Console.Write(oddNumber + " "));
Console.WriteLine();

// Negatif sayılar
Console.Write("Negatif olan sayılar: ");
numbers.Where(number => (number < 0)).ToList().ForEach(negativeNumber => Console.Write(negativeNumber + " "));
Console.WriteLine();

// Pozitif Sayılar
Console.Write("Pozitif olan sayılar: ");
numbers.Where(number => number > 0).ToList().ForEach(positiveNumber => Console.Write(positiveNumber + " "));
Console.WriteLine();

// 15'ten büyük ve 22'den küçük sayılar
Console.Write("15'ten büyük ve 22'den küçük sayılar: ");
numbers.Where(number => (number > 15) && (number < 22)).ToList().ForEach(number => Console.Write(number + " "));
Console.WriteLine();

// Listedeki her bir sayının karesi (Bunun için yeni bir liste oluşturup yazdırabilirsiniz.)
var squaredNumbers = numbers.Select(number => Math.Pow(number, 2)).ToList();

Console.Write("Listedeki her bir sayının karesi: ");
foreach (var number in squaredNumbers)
{
    Console.Write(number + " ");
}

// Bazı durumlarda sayi bulunmaması durumunda ternary operator ile mesaj gosterilebilir.