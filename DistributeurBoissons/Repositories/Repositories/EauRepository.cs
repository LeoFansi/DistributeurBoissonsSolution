using DistributeurBoissons.Modeles.Produits;
using DistributeurBoissons.Repositories.Common;
using DistributeurBoissons.Repositories.Interfaces;

namespace DistributeurBoissons.Repositories.Repositories
{
    public class EauRepository : GenericRepository<Eau>, IEauRepository
    {
        public EauRepository()
        {
            LibelleProduit = "Eau";
            PrixProduit = 0.2;
        }
    }
}
