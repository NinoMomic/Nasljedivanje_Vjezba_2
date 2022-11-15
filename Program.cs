using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje_Vjezba_2
{
    class NebeskoTijelo
    {
        double brzinaOkoOsi, brzinaOkoSunca;

        public double BrzinaOkoOsi { get => brzinaOkoOsi; set => brzinaOkoOsi = value; }
        public double BrzinaOkoSunca { get => brzinaOkoSunca; set => brzinaOkoSunca = value; }
    }
    class Planet : NebeskoTijelo
    {
        public Planet(double brzinaOkoOsi, double brzinaOkoSunca)
        {
            BrzinaOkoOsi = brzinaOkoOsi;
            BrzinaOkoSunca = brzinaOkoSunca;
        }

        public override string ToString()
        {
            return "Planet ima brzinu oko osi: " + BrzinaOkoOsi + "mph i ima brzinu oko sunca: " + BrzinaOkoSunca + "kmh.";
        }
    }
    class Satelit : NebeskoTijelo
    {
        public Satelit(double brzinaOkoOsi, double brzinaOkoSunca)
        {
            BrzinaOkoOsi = brzinaOkoOsi;
            BrzinaOkoSunca = brzinaOkoSunca;
        }

        public override string ToString()
        {
            return "Satelit ima brzinu oko osi: " + BrzinaOkoOsi + "mph i ima brzinu oko sunca: " + BrzinaOkoSunca + "kmh.";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Planet Zemlja = new Planet(1000, 108000);
            Satelit Mjesec = new Satelit(10, 108000);
            Console.WriteLine(Zemlja.ToString());
            Console.WriteLine(Mjesec.ToString());
            Console.ReadKey();
        }
    }
}