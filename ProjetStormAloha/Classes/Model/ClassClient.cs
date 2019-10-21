namespace ProjetStormAloha.Classes.Model
{
    public class Client : Personne
    {
        public string TypeCarte { get; set; }

        public string NumeroCarte { get; set; }

        public string Solde { get; set; }

        public string RefCarte { get; set; }
    }
}
