using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryMissionSoft;
using System.Collections.Generic;

namespace UnitTestProjectMissionSoft
{
    [TestClass]
    public class UnitTestAjoutReleve
    {
        [TestMethod]
        public void TestMethodAjoutReleve()
        {
            Mission laMission;
            DateTime laDate1, laDate2;
            int nbHeures;
            laMission = new Mission("Client", "Conception vecteur", 15, new Dictionary<DateTime, int>(), new Intervenant("Dupont", 45));	// instanciation d’une mission
            laDate1 = new DateTime(2007, 4, 4);
            laMission.ajoutReleve(laDate1, 5);
            nbHeures = laMission.ReleveHoraire[laDate1];
            Assert.AreEqual(5, nbHeures, "résultat non conforme");

            laDate2 = new DateTime(2007, 4, 6);
            laMission.ajoutReleve(laDate2, 9);
            nbHeures = laMission.ReleveHoraire[laDate2];
            Assert.AreEqual(8, nbHeures, "résultat non conforme");

            DateTime laDate = new DateTime(2007, 4, 4);
            laMission.ajoutReleve(laDate, 6);
            laMission.ajoutReleve(laDate, 5);	// ajout d’un relevé pour la même date
            nbHeures = laMission.ReleveHoraire[laDate];
            Assert.AreEqual(8, nbHeures, "résultat non conforme");

        }
    }
}
