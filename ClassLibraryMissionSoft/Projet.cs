using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMissionSoft
{
    public class Projet
    {
        /// <summary>
        /// Le nom.
        /// </summary>
        private string nom;

        /// <summary>
        /// La date de début.
        /// </summary>
        private DateTime début;

        /// <summary>
        /// La date de fin.
        /// </summary>
        private DateTime fin;

        /// <summary>
        /// Prix auquel le projet a été vendu pour la main d’œuvre.
        /// </summary>
        private double prixFactureMO;

        /// <summary>
        /// La liste des missions.
        /// </summary>
        private List<Mission> missions;

        /// <summary>
        /// Calcul le coût cumulé des heures de main d’œuvre effectuées pour l’ensemble des missions du projet.
        /// </summary>
        /// <returns>le coût cumulé des heures de main d’œuvre effectuées pour l’ensemble des missions du projet</returns>
        private double cumulCoutMO()
        {
            double coutCumulMO = 0;
            foreach(Mission m in missions)
            {
                coutCumulMO += m.Executant.TauxHoraire * m.nbHeuresEffectuees();
            }
            return coutCumulMO;
        }

        /// <summary>
        /// Calcul de la marge brute courante.
        /// </summary>
        /// <returns>la différence entre le prix facturé au chapitre main d’œuvre et le coût des heures de main d’œuvre effectuées pour l’ensemble des missions du projet</returns>
        public double margeBruteCourante()
        {
            return this.prixFactureMO - cumulCoutMO();
        }
    }
}