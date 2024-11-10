// See https://aka.ms/new-console-template for more information
Console.WriteLine("Iveskite 6 skaiciu masyva");

int[] arr = new int[6];
int teigiams = 0, neigiamas = 0, nuliai = 0;
bool lyginis = false;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());

    if (arr[i] > 0)
    {
        teigiams++;
    }
    else if (arr[i] < 0)
    {
        neigiamas++;
    }
    else { nuliai++; }

    if (arr[i] % 2 == 0)
    {
        lyginis = true;
    }
}
int dydziausias = arr[0];
int maziausias = arr[0];


for (int i = 1; i < arr.Length; i++)
{
    if (dydziausias < arr[i])
    {
        dydziausias = arr[i];
    }

    if (maziausias > arr[i])
    {
        maziausias = arr[i];
    }
}

Console.WriteLine("Teigiami: " + teigiams);
Console.WriteLine("Neigiamas: " + neigiamas);
Console.WriteLine("Nuliai: " + nuliai);
Console.WriteLine("Ar yra nors vienas lyginis: "+lyginis);
Console.WriteLine("Dydziausias: " + dydziausias);
Console.WriteLine("Maziausias: " + maziausias);

