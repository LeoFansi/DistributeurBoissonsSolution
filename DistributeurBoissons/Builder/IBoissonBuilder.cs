using DistributeurBoissons.Modeles;
using DistributeurBoissons.Modeles.Produits;
using DistributeurBoissons.Repositories.Interfaces;

namespace DistributeurBoissons.Builder
{
    public interface IBoissonBuilder
    {
        double RecupererPrixBoisson();
        void AjouterProduit();
        Boisson RecupererBoisson();
        void SetNomBoisson();

    }
}
