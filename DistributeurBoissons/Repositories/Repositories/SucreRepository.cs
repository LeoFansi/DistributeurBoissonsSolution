using DistributeurBoissons.Modeles.Produits;
using DistributeurBoissons.Repositories.Common;
using DistributeurBoissons.Repositories.Interfaces;

namespace DistributeurBoissons.Repositories.Repositories
{
    public class SucreRepository : GenericRepository<Sucre>, ISucreRepository
    {
        public SucreRepository()
        {
            LibelleProduit = "Sucre";
            PrixProduit = 0.1;
        }
    }
}
