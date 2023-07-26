Console.WriteLine("Alan Hesaplama");
// kodu ileştirme yap !
double radius, height, edge1, edge2, edge3, baseLength, width;
double pi = 3.14;
double result;
string? input = "";
string exit = "Oturumu kapatmak için: Çıkış yazın; devam etmek için GİRİŞ yapın.  Alan Hesaplama";
string codeError = "You have selected the wrong transaction code!";

Console.WriteLine("Geometrik Şekli Seçin : daire = 0 , üçgen = 3 , kare = 4");
int geoType = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Hesaplamak istediğiniz boyutu seçin: Çevre = 1, Alan = 2, Hacim = 3   ");
int areaType = Convert.ToInt32(Console.ReadLine());



while (input.ToLower() != "ÇIKIŞ")
{
    if (geoType == 0) // Daire 
    {
        switch (areaType)
        {
            case 1:
                Console.WriteLine("Çemberin Çevresini hesaplamak için lütfen Yarıçapı Girin  : ");
                Console.Write("yarıçap : "); radius = Convert.ToInt32(Console.ReadLine());
                result = 2 * pi * radius;
                Console.WriteLine("dairenin çevresi " + result);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;

            case 2:
                Console.WriteLine("Dairenin Alanını hesaplamak için lütfen Yarıçapı Girin  : ");
                Console.Write("yarıçap : "); radius = Convert.ToInt32(Console.ReadLine());
                result = pi * (radius * radius);
                Console.WriteLine("Alanın çevresi " + result);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;

            case 3:
                Console.WriteLine("Hacmini hesaplamak için lütfen Dairenin Yarıçapını ve Yüksekliğini Girin : ");
                Console.Write("yarıçap : "); radius = Convert.ToInt32(Console.ReadLine());
                Console.Write("yükseklik : "); height = Convert.ToInt32(Console.ReadLine());
                result = pi * (radius * radius) * height;
                Console.WriteLine("hacmin çevresi " + result);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;

            default:
                Console.WriteLine(codeError);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;
        }
    }
    else if (geoType == 3) // üçgen
    {
        switch (areaType)
        {
            case 1:
                Console.WriteLine("Üçgenin çevresini hesaplamak için lütfen 3 kenar uzunluğunu girin : ");
                Console.Write("1. Kenar : "); edge1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2. Kenar : "); edge2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("3. Kenar : "); edge3 = Convert.ToInt32(Console.ReadLine());
                result = edge1 + edge2 + edge3;
                Console.WriteLine("üçgenin çevresi " + result);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;

            case 2:
                Console.WriteLine("Üçgenin alanını hesaplamak için lütfen taban uzunluğunu ve yüksekliğini girin: ");
                Console.Write("Taban Uzunluğu: "); baseLength = Convert.ToInt32(Console.ReadLine());
                Console.Write("yükseklik : "); height = Convert.ToInt32(Console.ReadLine());
                result = (baseLength * height) / 2;
                Console.WriteLine("üçgenin alanı " + result);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;

            case 3:
                Console.WriteLine("Üçgenin hacmini hesaplamak için lütfen taban uzunluğunu ve yüksekliğini girin : ");
                Console.Write("Taban Uzunluğu : "); baseLength = Convert.ToInt32(Console.ReadLine());
                Console.Write("yükseklik : "); height = Convert.ToInt32(Console.ReadLine());
                result = ((baseLength * height) / 2) * height;
                Console.WriteLine("üçgenin hacmi " + result);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;

            default:
                Console.WriteLine(codeError);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;
        }
    }
    else if (geoType == 4) // kare
    {
        switch (areaType)
        {
            case 1:
                Console.WriteLine("Lütfen karenin çevresini hesaplamak için bir kenar uzunluğu girin : ");
                Console.Write("Kenar uzunluğu : "); edge1 = Convert.ToInt32(Console.ReadLine());
                result = edge1 * 4;
                Console.WriteLine(" Medyanın çevresi  " + result);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;
            case 2:
                Console.WriteLine("Lütfen karenin alanını hesaplamak için bir kenar uzunluğu girin : ");
                Console.Write("Kenar uzunluğu : "); edge1 = Convert.ToInt32(Console.ReadLine());
                result = edge1 * edge1;
                Console.WriteLine("karenin alanı  " + result);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;
            case 3:
                Console.WriteLine("Lütfen karenin Hacmini hesaplamak için, bir kenar uzunluğunu , genişliğini ve yüksekliğini   giriniz ! ");
                Console.Write("Kenar uzunluğu : "); edge1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("genişlik : "); width = Convert.ToInt32(Console.ReadLine());
                Console.Write("yükseklik : "); height = Convert.ToInt32(Console.ReadLine());
                result = edge1 * width + height;
                Console.WriteLine("karenin hacmi : " + result);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;

            default:
                Console.WriteLine(codeError);
                Console.WriteLine(exit);
                input = Console.ReadLine();
                break;

        }
    }
    else
    {
        Console.WriteLine(codeError);
        Console.WriteLine(exit);
        input = Console.ReadLine();
    }
}