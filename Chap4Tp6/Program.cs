using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chap4Cours1ClassExo2;

namespace Chap4Tp6
{
    class Program
    {
        static void Main(string[] args)
        {

            Employe unEmploye;
            string nomEmploye;
            int numEmploye;
            int ageEmploye;
            float salaireAnnuelEmploye;
            float unMontantVenteEmploye;
            bool laboucle = false;
            List<Employe> lesEmploye = new List<Employe>();

            string valSai;

            while (laboucle == false)
            {
                Console.WriteLine("Bienvenue chez l'ajouteur d'employé 4000");
                Console.ReadLine();
                // NUM DE L'EMPLOYE
                Console.WriteLine("Veuillez saisir le numéro de l'employé: ");
                valSai = Console.ReadLine();
                int.TryParse(valSai, out numEmploye);
                // NOM DE L'EMPLOYE
                Console.WriteLine("Veuillez saisir le nom de l'employé: ");
                nomEmploye = Console.ReadLine();
                // AGE DE L'EMPLOYE
                Console.WriteLine("Veuillez saisir l'age de l'employé: ");
                valSai = Console.ReadLine();
                int.TryParse(valSai, out ageEmploye);
                if (ageEmploye < Employe.GetAgeMin())
                {
                    Console.WriteLine("Ah mince, t'es trop jeune garçon !");
                }
                // SALAIRE ANNUEL DE L'EMPLOYE
                Console.WriteLine("Veuillez saisir le salaire annuel de l'employé: ");
                valSai = Console.ReadLine();
                float.TryParse(valSai, out salaireAnnuelEmploye);
                // MONTANT DE VENTE A L'ANNEE DE L'EMPLOYE
                Console.WriteLine("Veuillez saisir le montant de vente a l'année: ");
                valSai = Console.ReadLine();
                float.TryParse(valSai, out unMontantVenteEmploye);

                // CREATION DE L'EMPLOYE
                unEmploye = new Employe(numEmploye, nomEmploye, ageEmploye, salaireAnnuelEmploye, unMontantVenteEmploye);
                // AJOUT DE L'EMPLOYE DANS UNE LIST DE TYPE EMPLOYE
                lesEmploye.Add(unEmploye);

                Console.WriteLine("Souhaitez-vous saisir un nouvelle employé ? o/n");
                string verif = Console.ReadLine();
                if (verif == "o")
                {
                    laboucle = false;
                }
                else
                {
                    laboucle = true;
                }
            }

            Console.WriteLine("Nous allons maintenant afficher le montant TOTAL TTC des ventes.");

            int ind = 0;
            float totalHT = 0;
            float laTVA = 0;
            float calcul = 0;
            
            
            while (ind < lesEmploye.Count)
            {
                totalHT = lesEmploye[ind].GetMontantAnnuelHT();
                laTVA = TVA.CalculMontantTva(totalHT,'n');
                calcul = calcul + laTVA + totalHT;
                ind++;
                
            }

            Console.WriteLine("Le montant total des ventes est de " + calcul + "€");


            
            
            
            
        }

        
    }
    
}
