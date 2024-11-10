
int[] skaiciai = new int[10];
List<int> daugiau20 = new List<int>();
int neigiami = 0;

Console.WriteLine("Įveskite 10 skaičių:");
for (int i = 0; i < 10; i++)
{
    Console.Write($"Įveskite skaičių {i + 1}: ");
    skaiciai[i] = int.Parse(Console.ReadLine());

    if (skaiciai[i] > 20)
    {
        daugiau20.Add(skaiciai[i]);
    }

    if (skaiciai[i] < 0)
    {
        neigiami++;
    }
}

Console.WriteLine("\nSkaičiai didesni už 20:");
foreach (int num in daugiau20)
{
    Console.Write(num + " ");
}

Console.WriteLine($"\nNeigiamų skaičių kiekis: {neigiami}");