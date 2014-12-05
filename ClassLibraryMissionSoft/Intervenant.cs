using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMissionSoft
{
    public class Intervenant
    {
        /// <summary>
        /// Le nom.
        /// </summary>
        private string nom;

        /// <summary>
        /// LE taux horraire.
        /// </summary>
        private double tauxHoraire;

        /// <summary>
        /// Constructeur de classe.
        /// </summary>
        /// <param name="pNom"></param>
        /// <param name="pTxHoraire"></param>
        public Intervenant(string pNom, double pTxHoraire) // accesseur
        {
            this.nom = pNom;
            this.tauxHoraire = pTxHoraire;
        }

        /// <summary>
        /// Accesseur du taux horraire.
        /// </summary>
        public double TauxHoraire
        {
            get { return tauxHoraire; }
        }
    }
}