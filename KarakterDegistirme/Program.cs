﻿//Algoritma
//Verilen string ifade içerisindeki karakterleri bir önceki karakter ile yer değiştiren console uygulamasını yazınız.

//Örnek: Input: Karakter Değiştirme Hello Question

//Output: Karakter Değiştirme Hello Question


string word = "Karakter Değiştirme";
char first = word[0];
char last = word[word.Length - 1];
word = last + word.Substring(1, word.Length - 2) + first;
Console.WriteLine(word);



Console.WriteLine("-------------------------------------------------");

Console.Write("Karakter Değiştirme : ");
string input = Console.ReadLine();

char first2 = input[0];
char last2 = input[input.Length - 1];
input = last + input.Substring(1, input.Length - 2) + first;
Console.WriteLine(input);


// Tüm kelimeyi cevirme
string x = "Karakter Değiştirme";
string reversed = "";
for (int i = x.Length - 1; i >= 0; i--)
{
    reversed += (char)(x[i]);
}
Console.WriteLine(reversed);
