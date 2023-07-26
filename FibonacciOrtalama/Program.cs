//Ortalama Hesaplama
//Kulanıcıdan alınan derinliğe göre fibonacci serisindeki rakamların ortalamasını alıp ekrana yazdıran uygulamayı yazınız.

//Dikkat Edilmesi Gereken Noktalar :
//Kod tekrarından kaçınılmalı
//Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli.

using FibonacciOrtalama;

Console.WriteLine("Fibonacci Ortalama ");


Console.WriteLine("Lütfen fibonacci serisinin derinliğini giriniz: ");
int length = Convert.ToInt32(Console.ReadLine());

FibonacciCalculator fibonacci = new FibonacciCalculator();
AverageCalculator average = new AverageCalculator();

int[] fibonacciSeries = fibonacci.CalculateFibonacciSeries(length);

foreach (var item in fibonacciSeries)
{
    Console.Write(item + " ");
}

double averageResult = average.CalculateAverage(fibonacciSeries);

Console.WriteLine("  Girilen derinlikteki fibonacci serisinin ortalaması: " + averageResult);