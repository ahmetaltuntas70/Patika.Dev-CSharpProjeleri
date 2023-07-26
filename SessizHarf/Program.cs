//Algoritma
//Verilen string ifade içerisinde yanyana 2 tane sessiz varsa ekrana true, yoksa false yazdıran console uygulamasını yazınız.

//Örnek: Input: Merhaba Ahmo Fero

//Output: True False True




while (true)
{
    Console.WriteLine(" Boşluk bırakıp kelimelerİ girin");

    foreach (var item in Console.ReadLine().Split())
    {
        bool def = false;
        for (int i = 1; i < item.Length; i++)
        {
            if (sessizMi(item[i]) == sessizMi(item[i - 1]))
                def = true;
        }
        Console.Write(def + " ");
    }

    bool sessizMi(char c)
    {
        return !"eaiüaeö".ToCharArray().Contains(c);
    }
}