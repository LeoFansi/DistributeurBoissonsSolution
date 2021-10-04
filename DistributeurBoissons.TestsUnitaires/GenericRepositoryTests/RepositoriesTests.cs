using DistributeurBoissons.Modeles.Produits;
using DistributeurBoissons.Repositories.Common;
using DistributeurBoissons.Repositories.Interfaces;
using DistributeurBoissons.Repositories.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DistributeurBoissons.TestsUnitaires.GenericRepositoryTests
{
    [TestClass]
    public class RepositoriesTests
    {
        [TestMethod]
        public void GetTEntityClassName_Retourne_NomDeLaCLasse()
        {
            //Arrange
            string valeurAttendue = "ProduitBase";
            IGenericRepository genericRepository = new GenericRepository<ProduitBase>();

            //Action
            string valeurActuelle = genericRepository.GetTEntityClassName();

            //Assertion
            Assert.AreEqual(valeurAttendue, valeurActuelle);
        }

        [TestMethod]
        public void GetLibelleProduit_Retourne_Chaine_Vide()
        {
            //Arrange
            string valeurAttendue = "";
            IGenericRepository genericRepository = new GenericRepository<ProduitBase>();

            //Action
            string valeurActuelle = genericRepository.GetLibelle();

            //Assertion
            Assert.AreEqual(valeurAttendue, valeurActuelle);
        }

        [TestMethod]
        public void GetPrixProduit_Retourne_Zero()
        {
            //Arrange
            double prixAttendu = 0.0;
            IGenericRepository genericRepository = new GenericRepository<ProduitBase>();

            //Action
            double prixActuel = genericRepository.GetPrix();

            //Assertion
            Assert.AreEqual(prixAttendu, prixActuel);
        }

        [TestMethod]
        public void GetTEntityClassName_SurPlusieursClasses_Retourne_NomExactDeLaCLasseDuProduit()
        {
            //Arrange
            string valeurAttendueBase = "ProduitBase";
            string valeurAttendueCafe = "Cafe";
            string valeurAttendueSucre = "Sucre";
            string valeurAttendueCreme = "Creme";
            string valeurAttendueThe = "The";
            string valeurAttendueEau = "Eau";
            string valeurAttendueChocolat = "Chocolat";
            string valeurAttendueLait = "Lait";

            IGenericRepository genericRepository = new GenericRepository<ProduitBase>();
            ICafeRepository cafeRepository = new CafeRepository();
            ISucreRepository sucreRepository = new SucreRepository();
            ICremeRepository cremeRepository = new CremeRepository();
            ITheRepository theRepository = new TheRepository();
            IEauRepository eauRepository = new EauRepository();
            IChocolatRepository chocolatRepository = new ChocolatRepository();
            ILaitRepository laitRepository = new LaitRepository();

            //Action
            string valeurActuelleBase = genericRepository.GetTEntityClassName();
            string valeurActuelleCafe = cafeRepository.GetTEntityClassName();
            string valeurActuelleSucre = sucreRepository.GetTEntityClassName();
            string valeurActuelleCreme = cremeRepository.GetTEntityClassName();
            string valeurActuelleThe = theRepository.GetTEntityClassName();
            string valeurActuelleEau = eauRepository.GetTEntityClassName();
            string valeurActuelleChocolat = chocolatRepository.GetTEntityClassName();
            string valeurActuelleLait = laitRepository.GetTEntityClassName();

            //Assertion
            Assert.AreEqual(valeurAttendueBase, valeurActuelleBase);
            Assert.AreEqual(valeurAttendueCafe, valeurActuelleCafe);
            Assert.AreEqual(valeurAttendueSucre, valeurActuelleSucre);
            Assert.AreEqual(valeurAttendueCreme, valeurActuelleCreme);
            Assert.AreEqual(valeurAttendueThe, valeurActuelleThe);
            Assert.AreEqual(valeurAttendueEau, valeurActuelleEau);
            Assert.AreEqual(valeurAttendueChocolat, valeurActuelleChocolat);
            Assert.AreEqual(valeurAttendueLait, valeurActuelleLait);
        }

        [TestMethod]
        public void GetLibelle_SurPlusieursClasses_Retourne_LibelleExactCorrespondantAuProduit()
        {
            //Arrange
            string valeurAttendueBase = "";
            string valeurAttendueCafe = "Cafe";
            string valeurAttendueSucre = "Sucre";
            string valeurAttendueCreme = "Crème";
            string valeurAttendueThe = "Thé";
            string valeurAttendueEau = "Eau";
            string valeurAttendueChocolat = "Chocolat";
            string valeurAttendueLait = "Lait";

            IGenericRepository genericRepository = new GenericRepository<ProduitBase>();
            ICafeRepository cafeRepository = new CafeRepository();
            ISucreRepository sucreRepository = new SucreRepository();
            ICremeRepository cremeRepository = new CremeRepository();
            ITheRepository theRepository = new TheRepository();
            IEauRepository eauRepository = new EauRepository();
            IChocolatRepository chocolatRepository = new ChocolatRepository();
            ILaitRepository laitRepository = new LaitRepository();

            //Action
            string valeurActuelleBase = genericRepository.GetLibelle();
            string valeurActuelleCafe = cafeRepository.GetLibelle();
            string valeurActuelleSucre = sucreRepository.GetLibelle();
            string valeurActuelleCreme = cremeRepository.GetLibelle();
            string valeurActuelleThe = theRepository.GetLibelle();
            string valeurActuelleEau = eauRepository.GetLibelle();
            string valeurActuelleChocolat = chocolatRepository.GetLibelle();
            string valeurActuelleLait = laitRepository.GetLibelle();

            //Assertion
            Assert.AreEqual(valeurAttendueBase, valeurActuelleBase);
            Assert.AreEqual(valeurAttendueCafe, valeurActuelleCafe);
            Assert.AreEqual(valeurAttendueSucre, valeurActuelleSucre);
            Assert.AreEqual(valeurAttendueCreme, valeurActuelleCreme);
            Assert.AreEqual(valeurAttendueThe, valeurActuelleThe);
            Assert.AreEqual(valeurAttendueEau, valeurActuelleEau);
            Assert.AreEqual(valeurAttendueChocolat, valeurActuelleChocolat);
            Assert.AreEqual(valeurAttendueLait, valeurActuelleLait);
        }

        [TestMethod]
        public void GetPrixProduit_SurPlusieursClasses_Retourne_LePrixExactCorrespondantAuProduit()
        {
            //Arrange
            double prixAttenduBase = 0.0;
            double prixAttenduCafe = 1.0;
            double prixAttenduSucre = 0.1;
            double prixAttenduCreme = 0.5;
            double prixAttenduThe = 2.0;
            double prixAttenduEau = 0.2;
            double prixAttenduChocolat = 1;
            double prixAttenduLait = 0.4;

            IGenericRepository genericRepository = new GenericRepository<ProduitBase>();
            ICafeRepository cafeRepository = new CafeRepository();
            ISucreRepository sucreRepository = new SucreRepository();
            ICremeRepository cremeRepository = new CremeRepository();
            ITheRepository theRepository = new TheRepository();
            IEauRepository eauRepository = new EauRepository();
            IChocolatRepository chocolatRepository = new ChocolatRepository();
            ILaitRepository laitRepository = new LaitRepository();

            //Action
            double prixActuelBase = genericRepository.GetPrix();
            double prixActuelCafe = cafeRepository.GetPrix();
            double prixActuelSucre = sucreRepository.GetPrix();
            double prixActuelCreme = cremeRepository.GetPrix();
            double prixActuelThe = theRepository.GetPrix();
            double prixActuelEau = eauRepository.GetPrix();
            double prixActuelChocolat = chocolatRepository.GetPrix();
            double prixActuelLait = laitRepository.GetPrix();

            //Assertion
            Assert.AreEqual(prixAttenduBase, prixActuelBase);
            Assert.AreEqual(prixAttenduCafe, prixActuelCafe);
            Assert.AreEqual(prixAttenduSucre, prixActuelSucre);
            Assert.AreEqual(prixAttenduCreme, prixActuelCreme);
            Assert.AreEqual(prixAttenduThe, prixActuelThe);
            Assert.AreEqual(prixAttenduEau, prixActuelEau);
            Assert.AreEqual(prixAttenduChocolat, prixActuelChocolat);
            Assert.AreEqual(prixAttenduLait, prixActuelLait);
        }

    }
}
