
double[] temperaturos = new double[7];

Console.WriteLine("Įveskite savaitės temperatūras:");
for (int i = 0; i < temperaturos.Length; i++)
{
    Console.Write($"Temperatūra {i + 1} dieną: ");
    temperaturos[i] = double.Parse(Console.ReadLine());
}

double max = temperaturos[0];
foreach (double temp in temperaturos)
{
    if (temp > max)
    {
        max = temp;
    }
}

double sum = 0;
foreach (double temp in temperaturos)
{
    sum += temp;
}
double averageTemperature = sum / temperaturos.Length;

Console.WriteLine($"\nAukščiausia savaitės temperatūra: {max}");
if (averageTemperature < 10)
{
    Console.WriteLine("Savaitės temperatūros vidurkis yra mažesnis nei 10");
}
