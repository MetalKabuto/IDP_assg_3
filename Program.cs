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
                Console.WriteLine($"Antal atomer: {Z}");
                Console.WriteLine($"Typ: {typ}");
                Console.WriteLine($"Smältpunkt: {smältpunkt}");
                Console.WriteLine($"Kokpunkt: {kokpunkt}");
                Console.WriteLine("");
                //får error om det inte finns med en 'return', även om den inte behövs
                return typ;
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

            // arrayen för uppgift 4. skrev 3 null för att fylla ut elementen.
            Grundämne[] ämneslista = new Grundämne[6] {syre, järn, guld, null, null, null };

            //skapar ämnena som ska "direkt-tilldelas" arrayen.
            Grundämne väte = new Grundämne() { 
                namn = "väte", Z = 1, typ = "ickemetall", smältpunkt = 13.99, kokpunkt = 20.271
            };
            Grundämne brom = new Grundämne() { 
                namn = "brom", Z = 35, typ = "ickemetall", smältpunkt = 265.8, kokpunkt = 332.0
            };
            Grundämne kvicksilver = new Grundämne() { 
                namn = "kvicksilver", Z = 80, typ = "metall", smältpunkt = 234.3210, kokpunkt = 629.88
            };

            //uppgift 4. Tror det är såhär man direkt-tilldelar?
            ämneslista[3] = väte;
            ämneslista[4] = brom;
            ämneslista[5] = kvicksilver;

            //uppgift 5, foreach loop.
            foreach (Grundämne x in ämneslista)
            {
                x.Print();
            }

            //uppgift 6, skriv endast metall namn
            foreach (Grundämne x in ämneslista)
            {
                //y blir elementets 'typ' värde.
                string y = x.typ;
                if (y == "metall")
                {
                    Console.WriteLine(x.namn);
                }
            }

            //gör ett tomrum så att det blir lättare att läsa i konsolen.
            Console.WriteLine("");

            /*uppgift 7, skriv ämnena med smältpunkt < 273 och kok > 273. antar att båda ska vara uppfyllda samtidigt?
            annars kan man enkelt byta ut && i 'if' satsen mot ||.*/
            foreach (Grundämne x in ämneslista)
            {
                //som i loopen ovan blir variablerna attributen som behövs.
                double smält = x.smältpunkt;
                double kok = x.kokpunkt;
                if (smält < 273.16 && kok > 273.16)
                {
                    Console.WriteLine($"{x.namn} har en smältpunkt på {smält}kelvin, kokpunkten är {kok}kelvin");
                }
            }
        }
    }
}