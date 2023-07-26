Console.WriteLine("Karakter Tersten Yazdırma");

string input = Console.ReadLine();


string[] strings = input.Split(" ");

foreach (var word in strings)
{
    char[] chars = word.ToCharArray();
    Array.Reverse(chars);
    string reverseWord = new string(chars);
    Console.Write(reverseWord + " ");
    break;
}





