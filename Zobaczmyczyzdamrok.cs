#Funkcje i StreamWriter
/*int n = int.Parse(Console.ReadLine());
int sumaCyfr(int n)
{
    int suma = 0;
    while (n > 0)
    {
        suma += n % 10;
        n /= 10;
    }
    return suma;
}
Console.WriteLine(sumaCyfr(n));
*/
/*
string napis = Console.ReadLine();
char[] T = napis.ToCharArray();
Array.Reverse(T);
Console.WriteLine(T);
*/
// 1.3 - Napisz funkcje, która wypisuje łańcuch połówek wpisanej liczby, aż do 1. Np po wpisaniu 30 otrzymujemy 30-15-7-3-1. Rozumiecie? :)
/*int n = int.Parse(Console.ReadLine()) ;
string napis = "";
napis += n + "-";
while (n > 1)
{       
    n = n / 2;
    napis += n;
    if (n > 1)
    {
        napis += "-";
    }
}
Console.WriteLine(napis);*/

/*int n = int.Parse(Console.ReadLine());

string Czypierwsza(int n)
{
    for (int i = 2; i < n / 2 + 1; i++)
    {
        if (n % i == 0)
        {
            return ("Nie");
        }
        else
        {
            return ("Pierwsza");
        }
    }
    return ("");
}
Console.WriteLine(Czypierwsza(n));


*//* to są moje pierwsze 
 czy to jest funkcja?
git tylko teraz patrz na to na moment proszę?
*/
/*
using System.Collections;

Random r = new Random();
ArrayList kupa = new ArrayList();

for (int i = 2; i < x / 2 + 1;i++)
{
    int x = r.Next(1, 10);
    if (x % i == 0)
    {
        kupa.Add(x);
    }
}
foreach (var item in kupa) Console.WriteLine(item);
*//* co mam zrob*//*ić
 rozumiem 
/*dodaj 10 cyfr pierwszych do tablicy*/



/*int n;
bool CzyPierwsza(int n)
{
    if (n > 2)
    {
        for(int i = 2; i < n/2 + 1; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
            
        }

    }
    return true;
}




Random r = new Random();
int[] T = new int[10];
for (int i = 0; i < T.Length;)
{
    int x = r.Next(1, 10);
    if (CzyPierwsza(x) == true)
    {
        T[i] = x;
        i++;
    }
}
foreach (int i in T) Console.WriteLine(i);
*/


// 3.3 Zapisz do pliku 100 losowych liczb trzycyfrowych. Odczytaj ten plik i wypisz wszystkie liczby-palindromy, np 242 itp.

/*Random r = new Random();
StreamWriter Sw1 = new StreamWriter(@"C:\Users\Izuhn\Desktop\\plik1.txt");
for (int i = 0; i < 100; i++)
{
    Sw1.WriteLine(r.Next(100, 1000));
}
Sw1.Close();

string[] L = File.ReadAllLines(@"C:\Users\Izuhn\Desktop\\plik1.txt");
int[] T = new int[100];
for (int i = 0; i < L.Length; i++)
{
    T[i] = int.Parse(L[i]);
    if (T[i] % 10 == T[i] / 100 % 10)
    {
        Console.WriteLine(T[i]);
    }
}*/
/*Console.WriteLine(123 / 100 % 10);
Console.WriteLine(123 % 10);*/
