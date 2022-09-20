
namespace Biblio
{
    public class Stagiaire
    {

        #region Informations personnelles du stagiaire
        public string Matricule { get; set; }
        public string Login { get; set; }
        public string MotDePasse { get; set; }
        public string Cni { get; set; }
        public string Adresse { get; set; }
        public string Etablissement { get; set; }
        public bool Niveau { get; set; }
        #endregion

        #region Informations liées au stage
        public string Lieu { get; set; }
        public Villes Ville { get; set; }
        public string Theme { get; set; }
        public Domaines Domaine { get; set; }
        public DateTime Datedebut { get; set; }
        public DateTime Datefin { get; set; }
        public int Note { get; set; }
        #endregion

        public string NomComplet => $"{Matricule} ({Login}; {MotDePasse})";

        #region Propriétés Details et Resume de l'objet (et réécriturre de la méthode ToString()
        //Propriété statique utilisée dans une application console comme entête pour l'affichage des données des personnes.
        public static string DetailsEntetes
        {
            get
            {
                string Resultat = $"\n|{"Stagiaire",-35}|{"N°CNI",-12}|{"Etablissement",-20}|{"Adresse",-2}|{"Domaine",-17}|{"Niveau",-10}|{"Thème",-25}|{"Ville",-20}|{"Lieu de stage",-20}|{"Date de debut",-20}|{"Date de fin",-20}|{"Note",-5}|\n";
                Resultat = Resultat.PadRight(2 * Resultat.Length - 2, '-');
                return Resultat;
            }
        }
        public string Details => $"|{NomComplet,-35}|{Cni,-12}|{Etablissement,-20}|{Adresse,-22}|{Domaine.GetDescription(),-17}|{(Niveau ? "Bachelier" : "Master"),-10}|{Theme,-25}|{Ville,-20}|{Lieu,-20}|{Datedebut,-20}|{Datefin,-20}|{Note,-5}|";
        public override string ToString() => Details; //Réécriture (override) de la méthode ToString de conversion d'un objet en chaine de caractères. 
        #endregion

        #region Ajout d'un identifiant pour le projet Entity Framework Core
        public int ID { get; set; }
        #endregion
    }
}
