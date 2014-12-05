using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMissionSoft
{
    public class Mission
    {
        /// <summary>
        /// Le nom;
        /// </summary>
        private string nom;

        /// <summary>
        /// La description.
        /// </summary>
        private string description;

        /// <summary>
        /// Le nombre d'heures prévues pour réaliser la mission.
        /// </summary>
        private int nbHeuresPrevues;

        /// <summary>
        /// Le nombre d'heures passées par jour par la personne chargée d'exécuter cette mission.
        /// </summary>
        private Dictionary<DateTime, int> releveHoraire;

        /// <summary>
        /// La personne chargée d'exécuter la mission.
        /// </summary>
        private Intervenant executant;

        /// <summary>
        /// Accesseur sur l’attribut relevéHoraire.
        /// </summary>
        public Dictionary<DateTime, int> ReleveHoraire
        {
            get { return releveHoraire; }
        }

        /// <summary>
        /// Accesseur sur l’attribut exécutant.
        /// </summary>
        public Intervenant Executant
        {
            get { return executant; }
        }

        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        /// <param name="pNom">Le nom</param>
        /// <param name="pDesc">La description</param>
        /// <param name="nbHPrevues">Le nombre d'heure prévu</param>
        /// <param name="relHor">Le relevé horraire</param>
        /// <param name="exec">L'éxécutant</param>
        public Mission(string pNom, string pDesc, int nbHPrevues, Dictionary<DateTime, int> relHor, Intervenant exec)
        {
            this.nom = pNom;
            this.description = pDesc;
            this.nbHeuresPrevues = nbHPrevues;
            this.releveHoraire = relHor;
            this.executant = exec;        
        }

        /// <summary>
        /// Ajoute au relevé, une date et un nombre d’heures.
        /// </summary>
        /// <param name="jour"></param>
        /// <param name="nbHeures"></param>
        public void ajoutReleve(DateTime jour, int nbHeures)
        {
            if (releveHoraire.ContainsKey(jour))
            {
                if (releveHoraire[jour] + nbHeures <= 8)
                {
                    releveHoraire[jour] =  nbHeures + releveHoraire[jour];
                }
                else
                {
                    releveHoraire[jour] = 8;
                }
            }
            else
            {
                if (nbHeures <= 8)
                {
                    releveHoraire.Add(jour, nbHeures);
                }
                else
                {
                    releveHoraire.Add(jour, 8);
                }
            }
        }

        /// <summary>
        /// Total du nombre d'heures effectués du relevé horraire.
        /// </summary>
        /// <returns>le nombre d’heures réellement effectuées du relevé horaire</returns>
        public int nbHeuresEffectuees()
        {
            int nbHeure = 0;
            Dictionary<DateTime, int>.ValueCollection valuColl = releveHoraire.Values;
            foreach(int nb in valuColl)
            {
                nbHeure += nb;
            }
            return nbHeure;
        }       
    }
}