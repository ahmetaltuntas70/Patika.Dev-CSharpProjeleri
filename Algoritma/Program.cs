//Algoritma
//Ekrandan bir string bir de sayı alan (aralarında virgül ile),
//ilgili string ifade içerisinden verilen indexteki karakteri çıkartıp ekrana yazdıran console uygulasını yazınız.

//Örnek: Input: Algoritma,3 Algoritma,5 Algoritma,22 Algoritma,0

//Output: Algritma Algortma Algoritma lgoritma

// Get input from the user
Console.Write("Virgülle ayırarak bir dize ve dizin girin (çıkmak için 'exit' yazın): ");
string input = Console.ReadLine();

while (input.ToLower() != "ÇIKIŞ")
{
    // Giriş dizesini dizeye ve dizine ayırın
    string[] inputParts = input.Split(',');
    string stringInput = inputParts[0];
    int indexInput = int.Parse(inputParts[1]);

    // Karakteri verilen dizinde yazdır

    string output = stringInput.Remove(indexInput, 1);
    Console.WriteLine(output);

    // Sonraki giriş

    Console.Write("Virgülle ayırarak bir dize ve dizin girin (çıkmak için 'exit' yazın): ");
    input = Console.ReadLine();
}
