using DistributeurBoissons.Modeles;

namespace DistributeurBoissons.Builder
{
    public class Distributeur
    {
        public Boisson FabriquerBoisson(AbstractBuillder fabriqueDeBoisson)
        {
            fabriqueDeBoisson.CreerBoisson();

            fabriqueDeBoisson.SetNomBoisson();
            fabriqueDeBoisson.AjouterProduit();
            fabriqueDeBoisson.RecupererPrixBoisson();
            return fabriqueDeBoisson.RecupererBoisson();
        }
    }
}
