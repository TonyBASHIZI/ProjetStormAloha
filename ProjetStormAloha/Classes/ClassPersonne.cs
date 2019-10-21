namespace ProjetStormAloha.Classes
{
    public abstract class Personne : Base
    {
        public string Matricule { get; set; }

        public string Nom { get; set; }

        public string Postnom { get; set; }

        public string Prenom { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }

        public string Adresse { get; set; }
    }
}
