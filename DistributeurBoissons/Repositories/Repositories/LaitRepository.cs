using DistributeurBoissons.Modeles.Produits;
using DistributeurBoissons.Repositories.Common;
using DistributeurBoissons.Repositories.Interfaces;

namespace DistributeurBoissons.Repositories.Repositories
{
    public class LaitRepository : GenericRepository<Lait>, ILaitRepository
    {
        public LaitRepository()
        {
            LibelleProduit = "Lait";
            PrixProduit = 0.4;
        }
    }
}
