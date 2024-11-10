class Program
{
    static void Main(string[] args)
    {
        Produktas[] krepselis = { new Produktas(12.66, 5, "arbuzas"), new Produktas(9, 0, "bananai"), new Produktas(0.55, 9, "coca cola"), new Produktas(2.55, 5, "kiauliena"), new Produktas(8.88, 0, "makaronai") };
        Console.WriteLine("produktai kuriu yra sandelyje ir kaina mazesne nei 10");
    }

    public void check50Limit(Produktas[] krepselis)
    {
        foreach (Produktas p in krepselis)
        {
            if(p.kiekis>0 && p.kaina < 10)
            {
                Console.WriteLine(p.pavadinimas);
            }
        }


    }
}

class Produktas
{

    public Produktas(double kaina, int kiekis, string pavadinimas)
    {
        this.kaina = kaina;
        this.kiekis = kiekis;
        this.pavadinimas = pavadinimas;
    }
    public double kaina = 0;
    public int kiekis = 0;
    public string pavadinimas = "";

    public bool YraSandelyje()
    {
        return kiekis > 0 ? true : false;
    }
}