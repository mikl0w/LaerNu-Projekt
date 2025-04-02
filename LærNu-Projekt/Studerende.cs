namespace LærNu_Projekt
{
    internal class Studerende
    {
        //Properties
        public int StuderendeID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string CPR { get; set; }
        public string Email { get; set; }
        public string TelefonNummer { get; set; }
        public string Adresse { get; set; }

        //Constructor
        public Studerende(int studerendeID, string name, int age, string cpr, string email, string tlfNummer, string adresse)
        {
            StuderendeID = studerendeID;
            Name = name;
            Age = age;
            CPR = cpr;
            Email = email;
            TelefonNummer = tlfNummer;
            Adresse = adresse;
        }


        //Metode til at udskrive info om studerende
        public void UdskrivStuderende()
        {
            Console.WriteLine($"""
                ({StuderendeID}) {Name}, {Age}, CPR {CPR}
                Kontaktinformation:
                Tlf: {TelefonNummer}, Email: {Email}
                """);
        }
    }
}
