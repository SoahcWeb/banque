using System;

public class Personne
{
    // Propriétés publiques
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public DateTime DateDeNaissance { get; set; }

    // Constructeur
    public Personne(string nom, string prenom, DateTime dateDeNaissance)
    {
        Nom = nom;
        Prenom = prenom;
        DateDeNaissance = dateDeNaissance;
    }

    // Méthode pour afficher les informations de la personne
    public void AfficherInfo()
    {
        Console.WriteLine($"Nom : {Prenom}, Prénom : {Nom}, Date de naissance : {DateDeNaissance.ToShortDateString()}");
    }
}
