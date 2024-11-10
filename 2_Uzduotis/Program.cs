class Program
{
    static void Main(string[] args)
    {
        Preke[] krepselis = {new Preke(12.66,5,"arbuzas"), new Preke( 12.66, 5, "arbuzas" ) , new Preke( 12.66, 5, "arbuzas" ) , new Preke(12.66, 5, "arbuzas" ),new Preke(12.66,5,"arbuzas")};

    }

    public void check50Limit(Preke[] krepselis)
    {
        double suma = 0;
        foreach(Preke k in krepselis)
        {
            suma += k.BendraKaina();
        }

        if (suma > 50)
        {
            Console.WriteLine("suma virsija 50");
        }
    }
}

class Preke
{

    public Preke(double kaina, int kiekis, string pavadinimas)
    {
        this.kaina = kaina;
        this.kiekis = kiekis;
        this.pavadinimas = pavadinimas;
    }
    public double kaina = 0;
    public int kiekis = 0;
    public string pavadinimas = "";

    public double BendraKaina()
    {
        return kaina*kiekis;
    }
}