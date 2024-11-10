class Program
{
    static void Main(string[] args)
    {
        Studentas[] studentai = new Studentas[] { new Studentas(new double[] { 1, 2, 3, 4, 5, 6 }, "tomas"), new Studentas(new double[] { 6, 2, 3, 5, 5, 6 }, "egle"), new Studentas(new double[] { 2, 2, 3, 1, 5, 6 }, "lukas") };

        foreach (Studentas studentas in studentai)
        {
            if (studentas.Išlaikė())
            {
                Console.WriteLine("Islaike " + studentas.vardas);
            }
        }
    }

    class Studentas
    {
        //blic int amzius = 0, pazymiuKiekis = 0;
        public double[] pazymiai;
        public string vardas = "";

        public Studentas(double[] pazymiai, string vardas)
        {
            this.pazymiai = pazymiai;
            this.vardas = vardas;
        }
        public double Vidurkis()
        {
            double suma = 0;

            foreach (double p in pazymiai)
            {
                suma += p;
            }

            return suma / pazymiai.Length;
        }

        public bool Išlaikė()
        {
            return Vidurkis() >= 5 ? true : false;
        }

    }