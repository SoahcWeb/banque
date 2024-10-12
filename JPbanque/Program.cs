using System;

class Program
{
    static void Main(string[] args) // La méthode Main doit être statique
    {
        // Créer une instance de Personne
        Personne personne = new Personne("John", "Pauwels", new DateTime(1982, 01, 04));

        // Afficher les informations de la personne
        personne.AfficherInfo();
    }
}
