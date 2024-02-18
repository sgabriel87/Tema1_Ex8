/*Ex8
Se citesc trei numere de la tastatura, x, y,z. Scrieti un program care va afisa cele
trei valori in ordine descrescatoare.
• Exemplu: citim 3 9 0 Afisam : 9 3 0*/

Console.WriteLine("Introduceti primul numar:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduceti al doilea numar:");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduceti al treilea numar:");
int z = Convert.ToInt32(Console.ReadLine());

// Verificăm și ordonăm cele trei numere în ordine descrescătoare
if (x < y)
{
    int temp = x;
    x = y;
    y = temp;
}
if (x < z)
{
    int temp = x;
    x = z;
    z = temp;
}
if (y < z)
{
    int temp = y;
    y = z;
    z = temp;
}

Console.WriteLine("Cele trei numere în ordine descrescatoare sunt:");
Console.WriteLine(x + " " + y + " " + z);