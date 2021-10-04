using DistributeurBoissons.Builder;
using DistributeurBoissons.Modeles;
using DistributeurBoissons.Modeles.Produits;
using DistributeurBoissons.Repositories.Common;
using DistributeurBoissons.Repositories.Interfaces;
using DistributeurBoissons.Repositories.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DistributeurBoissons.TestsUnitaires.BuilderTests
{
    [TestClass]
    public class BuilderTests
    {
        [TestMethod]
        public void RecupererBoisson_SansCreation_Retourne_UnObjetNul()
        {
            //Arrangement
            AbstractBuillder abstractBuilder = new ExpressoBuilder();

            //Action
            Boisson nouvelleBoisson = abstractBuilder.RecupererBoisson();

            //Assertion
            Assert.IsNull(nouvelleBoisson);
        }

        [TestMethod]
        public void RecupererBoisson_AvecCreation_Retourne_UnObjetNonNul()
        {
            //Arrangement
            ExpressoBuilder expressoBuilder = new ExpressoBuilder();

            //Action
            expressoBuilder.CreerBoisson();
            Boisson nouvelleBoisson = expressoBuilder.RecupererBoisson();

            //Assertion
            Assert.IsNotNull(nouvelleBoisson);
        }

        [TestMethod]
        public void AjouterProduit_Doit_ModifierLaListeDesProduits()
        {
            //Arrangement
            AbstractBuillder abstractBuilder = new ExpressoBuilder();
            abstractBuilder.CreerBoisson();
            Boisson boisson = abstractBuilder.RecupererBoisson();
            int valeurIntiale = boisson.ListeProduits.Count;

            //Action
            abstractBuilder.AjouterProduit();
            int valeurActuelle = abstractBuilder.RecupererBoisson().ListeProduits.Count;

            //Assertion
            Assert.IsTrue(valeurActuelle == 2);
            Assert.AreNotEqual(valeurIntiale, valeurActuelle);
        }

        [TestMethod]
        public void SetNomBoisson_Dune_Boisson_Doit_ModifierNomBoisson()
        {
            //Arrangement
            string nomInitial = null;
            AbstractBuillder expressoBuilder = new ExpressoBuilder();
            expressoBuilder.CreerBoisson();
            string nomInitialApresCreation = expressoBuilder.RecupererBoisson().NomBoisson;
            string nomAttendu = "Expresso";

            //Action
            expressoBuilder.SetNomBoisson();

            //Assertion
            Assert.AreEqual(nomAttendu, expressoBuilder.RecupererBoisson().NomBoisson);
            Assert.AreEqual(nomInitial, nomInitialApresCreation);
        }

        [TestMethod]
        public void RecupererPrixBoisson_Dun_Expresso_Retourne_UnVirguleCinquanteSix()
        {
            //Arrangement
            double prixAttendu = 1.56;
            AbstractBuillder expressoBuilder = new ExpressoBuilder();
            expressoBuilder.CreerBoisson();

            //Action
            expressoBuilder.AjouterProduit();
            double prixActuel = expressoBuilder.RecupererPrixBoisson();

            //Assertion
            Assert.AreEqual(prixAttendu, prixActuel);
        }

        [TestMethod]
        public void RecupererPrixBoisson_Dun_Allonger_Retourne_UnVirguleQuatreVingtDeux()
        {
            //Arrangement
            double prixAttendu = 1.82;
            AbstractBuillder allongeBuilder = new AllongeBuilder();
            allongeBuilder.CreerBoisson();

            //Action
            allongeBuilder.AjouterProduit();
            double prixActuel = allongeBuilder.RecupererPrixBoisson();

            //Assertion
            Assert.AreEqual(prixAttendu, prixActuel);
        }

        [TestMethod]
        public void RecupererPrixBoisson_Dun_Capuccino_Retourne_TroisVirguleCinquanteUn()
        {
            //Arrangement
            double prixAttendu = 3.51;
            CapuccinoBuilder capuccinoBuilder = new CapuccinoBuilder();
            capuccinoBuilder.CreerBoisson();

            //Action
            capuccinoBuilder.AjouterProduit();
            double prixActuel = capuccinoBuilder.RecupererPrixBoisson();

            //Assertion
            Assert.AreEqual(prixAttendu, prixActuel);
        }

        [TestMethod]
        public void RecupererPrixBoisson_Dun_Chocolat_Retourne_CinqVirguleTrenteTrois()
        {
            //Arrangement
            double prixAttendu = 5.33;
            ChocolatBuilder chocolatBuilder = new ChocolatBuilder();
            chocolatBuilder.CreerBoisson();

            //Action
            chocolatBuilder.AjouterProduit();
            double prixActuel = chocolatBuilder.RecupererPrixBoisson();

            //Assertion
            Assert.AreEqual(prixAttendu, prixActuel);
        }

        [TestMethod]
        public void RecupererPrixBoisson_Dun_The_Retourne_TroisVirguleDouze()
        {
            //Arrangement
            double prixAttendu = 3.12;
            TheBuilder theBuilder = new TheBuilder();
            theBuilder.CreerBoisson();

            //Action
            theBuilder.AjouterProduit();
            double prixActuel = theBuilder.RecupererPrixBoisson();

            //Assertion
            Assert.AreEqual(prixAttendu, prixActuel);
        }

    }
}
