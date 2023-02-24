using System.Xml;

namespace D15_inlämning
{
    //Skrivet av Hannes Paulsson
    internal class Program
    {
        //Uppgift 1.
        public class Grundämne
        {
            public string namn;
            // Z = atomnummer
            public int Z;
            public string typ;
            // smält och kok mäts i kelvin
            public double smältpunkt;
            public double kokpunkt;

            //Metoden för uppgift 3.
            public string Print()
            {
                Console.WriteLine($"Grundämne: {namn}");
                Console.WriteLine($"Typ: {typ}");
                Console.WriteLine($"Antal atomer: {Z}");
                Console.WriteLine($"Smältpunkt: {smältpunkt}");
                Console.WriteLine($"Kokpunkt: {kokpunkt}");
                //får error om det inte finns med en 'return', även om den inte behövs
                return namn;
            }
        }
        static void Main(string[] args)
        {
            //Instansiering för uppgift 2.
            Grundämne syre = new Grundämne() { 
                namn = "syre", Z = 8, typ = "ickemetall", smältpunkt = 54.36, kokpunkt = 90.188
            };
            Grundämne järn = new Grundämne() { 
                namn = "järn", Z = 26, typ = "metall", smältpunkt = 1811, kokpunkt = 3134
            };
            Grundämne guld = new Grundämne() { 
                namn = "guld", Z = 79, typ = "metall", smältpunkt = 1337.33, kokpunkt = 3243
            };

            syre.Print();
            järn.Print();
            guld.Print();
        }
    }
}