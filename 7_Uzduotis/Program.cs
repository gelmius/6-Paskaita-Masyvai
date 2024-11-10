
List<int> numbers = new List<int>();
int sum = 0;

Console.WriteLine("Įveskite skaičius (kai baigsite, įveskite 'stop'):");
while (true)
{
    string input = Console.ReadLine();
    if (input.ToLower() == "stop")
        break;

    numbers.Add(int.Parse(input));
}

foreach (int num in numbers)
{
    if (num < 0)
        break;
    sum += num;
}

bool hasNegative = numbers.Exists(n => n < 0);

if (hasNegative)
{
    Console.WriteLine($"Suma iki pirmo neigiamo skaičiaus: {sum}");
}
else
{
    Console.WriteLine($"Visų skaičių suma: {sum}");
}