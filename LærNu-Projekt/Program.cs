namespace LærNu_Projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vi opretter et matematik-kursus som starter d. 3 februar 2025
            Kursus matematik = new Kursus(1, "Matematik", 'A', 1, false, 7499.95m, new DateTime(2025, 2, 3), new DateTime(2025, 6, 6), "Matematik på A-niveau");

            //Vi opretter en liste af studerende som vi kalder kursusMatematik
            List<Studerende> kursusMatematik = new List<Studerende>();

            //Her oprettes 3 studerende
            Studerende mikkel = new Studerende(1, "Mikkel Klitgaard", 30, "040594-1234", "mikkel@mail.dk", "26284155", "Mindegade 22, 7100 Vejle");
            Studerende stephanie = new Studerende(2, "Stephanie Lindorf", 25, "010799-1234", "stephanie@mail.com", "26854718", "Søndergade 1, 7100 Vejle");
            Studerende adam = new Studerende(3, "Adam Badr", 23, "050601-1234", "adam@gmail.com", "65347213", "Vestergade 7, 5500 Middelfart");

            //Benyttelse af metoden "UdskrivKursusDetaljer()" på "objektet" matematik
            matematik.UdskrivKursusDetaljer();

            //2 tomme linjer for bedre overskuelighed
            Console.WriteLine();
            Console.WriteLine();

            //3 studerende tilføjes til listen kursusMatematik (de er nu tilmeldt kurset)
            kursusMatematik.Add(mikkel);
            kursusMatematik.Add(stephanie);
            kursusMatematik.Add(adam);

            //For hver studerende (som vi kalder tilmeldte) på listen kursusMatematik, skal der udskrives info om de tilmeldte
            //med metoden "UdskrivStuderende()"
            Console.WriteLine("Tilmeldte studerende på Matematik A:");
            Console.WriteLine("-----------------------");
            foreach (Studerende tilmeldte in kursusMatematik)
            {
                tilmeldte.UdskrivStuderende();
                Console.WriteLine();
            }

            //ReadLine for input før koden afsluttes.
            Console.ReadLine();
        }
    }
}
