using DistributeurBoissons.Modeles.Produits;
using DistributeurBoissons.Repositories.Common;
using DistributeurBoissons.Repositories.Interfaces;

namespace DistributeurBoissons.Repositories.Repositories
{
    public class ChocolatRepository : GenericRepository<Chocolat>, IChocolatRepository
    {
        public ChocolatRepository()
        {
            LibelleProduit = "Chocolat";
            PrixProduit = 1.0;
        }
    }
}
