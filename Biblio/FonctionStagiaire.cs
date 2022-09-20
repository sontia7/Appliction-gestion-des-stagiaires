using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class FonctionStagiaire : ObservableCollection<Stagiaire>
    {
        private readonly string _cheminFichier = $@"{Directory.GetCurrentDirectory()}/StagiairesData.txt";

        public void ChargerStagiaire()
        {
            if (File.Exists(_cheminFichier))
            {
                using (FileStream fs = new(_cheminFichier, FileMode.Open))
                {
                    using (StreamReader sr = new(fs))
                    {
                        this.Clear();

                        bool Conversion = byte.TryParse(sr.ReadLine(), out byte NbStagiaires);

                        if (Conversion && NbStagiaires > 0)
                        {
                            for (int i = 0; i < NbStagiaires; i++)
                            {
                                Stagiaire s = new();

                                s.Matricule = sr.ReadLine();
                                s.Login = sr.ReadLine();
                                s.MotDePasse = sr.ReadLine();
                                s.Cni = sr.ReadLine();
                                s.Adresse = sr.ReadLine();
                                s.Etablissement = sr.ReadLine();
                                if (bool.TryParse(sr.ReadLine(), out bool tmpNiveau))
                                {
                                    s.Niveau = tmpNiveau;
                                }
                                s.Lieu = sr.ReadLine();
                                if (Enum.TryParse(sr.ReadLine(), out Villes tmpVille))
                                {
                                    s.Ville = tmpVille;
                                }
                                s.Theme = sr.ReadLine();
                                if (Enum.TryParse(sr.ReadLine(), out Domaines tmpDomaine))
                                {
                                    s.Domaine = tmpDomaine;
                                }
                                DateTime dateDebut = DateTime.Now;
                                while (!DateTime.TryParse(sr.ReadLine(), out dateDebut))
                                {
                                    Console.WriteLine("Date incorrecte, veuillez entrer une date valide :");
                                }
                                s.Datedebut = dateDebut;
                                DateTime dateFin = DateTime.Now;
                                while (!DateTime.TryParse(sr.ReadLine(), out dateFin))
                                {
                                    Console.WriteLine("Date incorrecte, veuillez entrer une date valide :");
                                }
                                s.Datefin = dateFin;
                                s.Note = int.Parse(sr.ReadLine());

                                this.Add(s);
                            }
                        }
                    }
                }
            }
        }

        public void SauvegarderStagiaire()
        {
            using (FileStream fs = new(_cheminFichier, FileMode.Create))
            {
                using (StreamWriter sw = new(fs))
                {
                    sw.WriteLine(this.Count);
                    foreach (Stagiaire s in this)
                    {
                        sw.WriteLine(s.Matricule);
                        sw.WriteLine(s.Login);
                        sw.WriteLine(s.MotDePasse);
                        sw.WriteLine(s.Cni);
                        sw.WriteLine(s.Adresse);
                        sw.WriteLine(s.Etablissement);
                        sw.WriteLine(s.Niveau);
                        sw.WriteLine(s.Lieu);
                        sw.WriteLine(s.Ville);
                        sw.WriteLine(s.Theme);
                        sw.WriteLine(s.Domaine);
                        sw.WriteLine(s.Datedebut);
                        sw.WriteLine(s.Datefin);
                        sw.WriteLine(s.Note);
                    }
                }
            }
        }
    }
}
