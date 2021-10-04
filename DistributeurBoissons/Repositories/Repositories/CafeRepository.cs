using DistributeurBoissons.Modeles.Produits;
using DistributeurBoissons.Repositories.Common;
using DistributeurBoissons.Repositories.Interfaces;

namespace DistributeurBoissons.Repositories.Repositories
{
    public class CafeRepository : GenericRepository<Cafe>, ICafeRepository
    {
        public CafeRepository()
        {
            LibelleProduit = "Cafe";
            PrixProduit = 1.0;
        }
    }
}
