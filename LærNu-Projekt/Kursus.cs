namespace LærNu_Projekt
{
    internal class Kursus
    {
        //Her opretter vi de forskellige Properties som objekter af klassen Kursus kan have
        public int KursusID { get; set; }
        public string KursusNavn { get; set; }
        public char Niveau { get; set; }
        public int InstruktørID { get; set; }
        public bool Fjernundervisning { get; set; }
        public decimal Pris { get; set; }

        //Vi bruger DateTime som datatype, da det giver os en dato og mulighed for at arbejde med denne dato.
        public DateTime StartDato { get; set; }
        public DateTime SlutDato { get; set; }
        public string Beskrivelse { get; set; }

        //Dette er vores constructor for oprettelse af nye objekter af klassen Kursus
        public Kursus(int kursusID, string navn, char niveau, int instruktørID, bool fjernundervisning,
                      decimal pris, DateTime startDato, DateTime slutDato, string beskrivelse)
        {
            KursusID = kursusID;
            KursusNavn = navn;
            Niveau = niveau;
            InstruktørID = instruktørID;
            Fjernundervisning = fjernundervisning;
            Pris = pris;
            StartDato = startDato;
            SlutDato = slutDato;
            Beskrivelse = beskrivelse;
        }

        //Metoden til at udskrive detaljer om det omhandlende kursus
        public void UdskrivKursusDetaljer()
        {
            Console.WriteLine($"""
                Detaljer om kursus
                -----------------------
                Kursus: {KursusNavn} {Niveau}
                Beskrivelse: {Beskrivelse}
                Start: {StartDato.ToString("D")}
                Slut:  {SlutDato.ToString("D")}
                Pris: {Pris:C2}
                KursusID: {KursusID}
                InstruktørID: {InstruktørID}
                """);
            //Her laver vi et if-statement så vi får "Ja/Nej" som udskrift til Fjernundervisning, istedet for True/False
            if (Fjernundervisning == true) Console.WriteLine("Fjernundervisning: Ja");
            else Console.WriteLine("Fjernundervisning: Nej");
        }

    }
}
