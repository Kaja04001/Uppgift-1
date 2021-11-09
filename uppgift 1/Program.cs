using System;

namespace uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variabler av paper och kuvert namgeda med respektive area
            double c4 = 0.229 * 0.324;
            double a3 = 0.297 * 0.420;
            double a4 = 0.210 * 0.297;
            int kuvert = (int)(2 * c4);
            //Fråga efter gram/m^2 vikt på föremålen
            Console.WriteLine("Ange Vikt På Paperna (I gram)");
            //Vikt för c4 frågas först, sen följs det ner i listan som det frågas i uppgifts bladet
            Console.WriteLine("Ange vikt för ett blad c4 (får inte vara mindre än eller lika med 50 eller lika med eller större än 200):");
            int vikt1 = int.Parse(Console.ReadLine());
            if (vikt1 > 200 || vikt1 < 50){
                Console.WriteLine("Felaktig input");
            }
            else{
                Console.WriteLine("Förstått");
            }
            Console.WriteLine("Ange vikt för ett blad a3 (samma regel följs här och för nästa:");
            int vikt2 = int.Parse(Console.ReadLine());
            if (vikt2 > 200 || vikt2 < 50){
                Console.WriteLine("Felaktig input");
            }
            else{
                Console.WriteLine("Förstått");
            }
            Console.WriteLine("Ange vikt för a4:");
            int vikt3 = int.Parse(Console.ReadLine());
            if (vikt3 > 200 || vikt3 < 50){
                Console.WriteLine("Felaktig input");
            }
            else{
                Console.WriteLine("förstått");
            }
            // g/m^2 * m^2 blir total vikten
            int totalc4 = ((int)(c4 * vikt1));
            int totala3 = ((int)(a3 * vikt2));
            int totala4 = ((int)(a4 * vikt3));
            int totalkuvert = ((int)(kuvert * vikt1));
            int totalavikt = ((int)(totalkuvert + totala4 + totala3 + totalc4));
            //Vikten blir utmatad med information om man undvek portoten eller icke.
            if(totalavikt <= 50){
                Console.WriteLine("Du lyckades undvika det dubbla portoten!");
                Console.WriteLine("Resultat: " + totalavikt + "gram");
            }
            else{

                Console.WriteLine("Dy mysslyckades undvika det dubbla portoten!");
                Console.WriteLine("Resultat: " + totalavikt + "gram");
            }

        }
    }
}
