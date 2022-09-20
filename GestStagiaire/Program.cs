using Biblio;

byte Valeur = 0;

FonctionStagiaire fonctionStagiaire = new FonctionStagiaire();
fonctionStagiaire.ChargerStagiaire();

do
{
    Console.Clear();
    Console.WriteLine("******************************************************************************************************************");
    Console.WriteLine("******************************************************************************************************************");
    Console.WriteLine("******************************************************************************************************************");
    Console.WriteLine("*********************                                                                        *********************");
    Console.WriteLine("*********************                                                                        *********************");
    Console.WriteLine("*********************                 APPLICATION DE GESTION DES STAGIAIRES                  *********************");
    Console.WriteLine("*********************                                                                        *********************");
    Console.WriteLine("*********************                                                                        *********************");
    Console.WriteLine("******************************************************************************************************************");
    Console.WriteLine("******************************************************************************************************************");
    Console.WriteLine("******************************************************************************************************************");
    Console.WriteLine("*********************                                                                        *********************");
    Console.WriteLine("*********************                                                                        *********************");
    Console.WriteLine("*********************                             MENU PRINCIPAL                             *********************");
    Console.WriteLine("*********************                                                                        *********************");
    Console.WriteLine("*********************                                                                        *********************");
    Console.WriteLine("*********************                     [1]. Ajouter un stagiaire                          *********************");
    Console.WriteLine("*********************                     [2]. Supprimer un stagiaire                        *********************");
    Console.WriteLine("*********************                     [3]. Afficher la liste des stagiaires              *********************");
    Console.WriteLine("*********************                                                                        *********************");
    Console.WriteLine("*********************                     [4]. SORTIR DU PROGRAMME                           *********************");
    Console.WriteLine("*********************                                                                        *********************");
    Console.WriteLine("*********************                                                                        *********************");
    Console.WriteLine("******************************************************************************************************************");
    Console.WriteLine("******************************************************************************************************************");
    Console.WriteLine("********************************************************************************** Palier #1 *********************");
    Console.WriteLine("******************************************************************************************************************");
    Console.WriteLine("******************************************************************************************************************");
    Console.WriteLine("\n");

    Console.Write("\n\t\t ---> CHOIX : ");
    while (!byte.TryParse(Console.ReadLine(), out Valeur) || Valeur < 1 || Valeur > 4)
    {
        Console.WriteLine($"Erreur, le nombre doit être compris entre 1 et 4, veuillez recommencer :");
    }

    switch (Valeur)
    {
        #region 1.Ajouter un nouveau stagiaire
        case 1:
            Console.Clear();
            Stagiaire NouveauStagiaire = new();

            Console.WriteLine("\n\n");
            Console.WriteLine("\t Enregistrement d'un nouveau stagiaire\n");

            Console.Write("\n\t-> Matricule : ");
            NouveauStagiaire.Matricule = Console.ReadLine();
            while (NouveauStagiaire.Matricule == string.Empty)
            {
                Console.Write($"Erreur, il faut un matricule, veuillez recommencer : ");
                NouveauStagiaire.Matricule = Console.ReadLine();
            }

            Console.Write("\n\t-> Login : ");
            NouveauStagiaire.Login = Console.ReadLine();
            while (NouveauStagiaire.Login == string.Empty)
            {
                Console.Write($"Erreur, il faut un login, veuillez recommencer : ");
                NouveauStagiaire.Login = Console.ReadLine();
            }

            Console.Write("\n\t-> Mot de passe : ");
            NouveauStagiaire.MotDePasse = Console.ReadLine();
            while (NouveauStagiaire.MotDePasse == string.Empty)
            {
                Console.Write($"Erreur, il faut un mot de passe, veuillez recommencer : ");
                NouveauStagiaire.MotDePasse = Console.ReadLine();
            }

            Console.Write("\n\t-> N° CNI : ");
            NouveauStagiaire.Cni = Console.ReadLine();
            while (NouveauStagiaire.Cni == string.Empty)
            {
                Console.Write($"Erreur, il faut un N° de CNI, veuillez recommencer : ");
                NouveauStagiaire.Cni = Console.ReadLine();
            }

            Console.Write("\n\t-> Adresse : ");
            NouveauStagiaire.Adresse = Console.ReadLine();
            while (NouveauStagiaire.Adresse == string.Empty)
            {
                Console.Write($"Erreur, il faut une adresse, veuillez recommencer : ");
                NouveauStagiaire.Adresse = Console.ReadLine();
            }

            Console.Write("\n\t-> Etablissement : ");
            NouveauStagiaire.Etablissement = Console.ReadLine();
            while (NouveauStagiaire.Etablissement == string.Empty)
            {
                Console.Write($"Erreur, il faut un login, veuillez recommencer : ");
                NouveauStagiaire.Etablissement = Console.ReadLine();
            }

            Console.Write("\n\t-> Niveau (0->Bachelier / 1->Master) : ");
            string _resultatNiveau = Console.ReadLine();
            while (_resultatNiveau != "0" && _resultatNiveau != "1")
            {
                Console.WriteLine($"Genre erronné, veuillez entrer un niveau (0->Bachelier / 1->Master) :");
                _resultatNiveau = Console.ReadLine();
            }
            if (_resultatNiveau == "0") NouveauStagiaire.Niveau = false; else NouveauStagiaire.Niveau = true;

            Console.Write("\n\t-> Lieu : ");
            NouveauStagiaire.Lieu = Console.ReadLine();
            while (NouveauStagiaire.Lieu == string.Empty)
            {
                Console.Write($"Erreur, il faut un lieu de stage, veuillez recommencer : ");
                NouveauStagiaire.Lieu = Console.ReadLine();
            }

            Villes _resultatVille = (Villes)Enum.GetValues(typeof(Villes)).GetValue(0);
            Console.WriteLine("\n\t-> Choisir une ville : ");

            foreach (Villes Ville in Enum.GetValues(typeof(Villes))) { Console.WriteLine($"{Ville:D}.{Ville.GetDescription()}"); }

            Console.Write("\n\t Choix : ");
            while (!Enum.TryParse(Console.ReadLine(), out _resultatVille) || !Enum.IsDefined(typeof(Villes), _resultatVille))
            {
                Console.Write("Valeur erronnée, veuillez recommencer : ");
            }
            NouveauStagiaire.Ville = _resultatVille;

            Console.Write("\n\t-> Thème de stage : ");
            NouveauStagiaire.Theme = Console.ReadLine();
            while (NouveauStagiaire.Theme == string.Empty)
            {
                Console.Write($"Erreur, il faut un thème de stage, veuillez recommencer : ");
                NouveauStagiaire.Theme = Console.ReadLine();
            }

            Domaines _resultatDomaine = (Domaines)Enum.GetValues(typeof(Domaines)).GetValue(0);
            Console.WriteLine("\n\t-> Choisir un domaine d'étude : ");

            foreach (Domaines Domaine in Enum.GetValues(typeof(Domaines))) { Console.WriteLine($"{Domaine:D}.{Domaine.GetDescription()}"); }

            Console.Write("\n\t Choix : ");
            while (!Enum.TryParse(Console.ReadLine(), out _resultatDomaine) || !Enum.IsDefined(typeof(Domaines), _resultatDomaine))
            {
                Console.Write("Valeur erronnée, veuillez recommencer : ");
            }
            NouveauStagiaire.Domaine = _resultatDomaine;

            DateTime ResultatD = DateTime.Now;
            DateTime ResultatF = DateTime.Now;

            Console.Write("\n\t-> Date de début de stage : ");
            while (!DateTime.TryParse(Console.ReadLine(), out ResultatD))
            {
                Console.WriteLine("Date incorrecte, veuillez entrer une date valide :");
            }
            NouveauStagiaire.Datedebut = ResultatD;

            Console.Write("\n\t-> Date de fin de stage : ");
            while (!DateTime.TryParse(Console.ReadLine(), out ResultatF))
            {
                Console.WriteLine("Date incorrecte, veuillez entrer une date valide :");
            }
            while (ResultatF.Year < ResultatD.Year && ResultatF.Month < ResultatD.Month)
            {
                Console.WriteLine("La date de fin de stage doit être supérieure à la date de début de stage. Bien vouloir reprendre : ");
                while (!DateTime.TryParse(Console.ReadLine(), out ResultatF))
                {
                    Console.WriteLine("Date incorrecte, veuillez entrer une date valide :");
                }
            }
            NouveauStagiaire.Datefin = ResultatF;

            byte ResultatNote = byte.MinValue;

            Console.Write("\n\t-> Note obtenue : ");
            while (!byte.TryParse(Console.ReadLine(), out ResultatNote) || ResultatNote < 0 || ResultatNote > 20)
            {
                Console.WriteLine($"Erreur, le nombre doit compris entre 0 et 20, veuillez recommencer :");
            }
            NouveauStagiaire.Note = ResultatNote;

            //Ajout de le nouveau stagiaire à la liste.
            fonctionStagiaire.Add(NouveauStagiaire);
            //Sauvegarde dans le fichier par défaut.
            fonctionStagiaire.SauvegarderStagiaire();
            break;
        #endregion
        #region 2.Supprimer un stagiaire
        case 2:
            Console.WriteLine("\n\n");
            if (fonctionStagiaire.Count > 0)
            {
                byte _aEnlever = 0;

                //Execute le code pour chaque personne dans la liste.
                //Contrairement à un for il n'y a pas de compteur.
                //IndexOf : renvoie l'indice de l'objet dans la liste.
                foreach (Stagiaire stag in fonctionStagiaire) { Console.WriteLine($"{fonctionStagiaire.IndexOf(stag)} : {stag.Details}."); }
                //Un objet de la liste est enlevé sur base de sa position (Récupérée par TryParses.Lire)
                Console.WriteLine("\nVeuillez faire un choix :");
                while (!byte.TryParse(Console.ReadLine(), out _aEnlever) || _aEnlever < 0 || _aEnlever > fonctionStagiaire.Count - 1)
                {
                    Console.WriteLine($"\nErreur, le nombre doit compris entre 0 et {fonctionStagiaire.Count - 1}, veuillez recommencer :");
                }
                fonctionStagiaire.Remove(fonctionStagiaire[_aEnlever]);
                fonctionStagiaire.SauvegarderStagiaire();
            }
            else { Console.WriteLine("\nListe vide, rien à supprimer."); }
            break;
        #endregion
        #region 3.Afficher la liste des stagiaires
        case 3:
            Console.WriteLine("\n\n\t Liste des stagiaires\n");

            Console.WriteLine(Stagiaire.DetailsEntetes);
            foreach (Stagiaire s in fonctionStagiaire) { Console.WriteLine($"{s.Details}"); }
            Console.WriteLine("\n\nAppuyez sur une touche pour retourner au menu.....");
            Console.ReadLine();
            break;
        #endregion
    }
}while (Valeur != 4);