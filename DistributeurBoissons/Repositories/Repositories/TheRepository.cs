using DistributeurBoissons.Modeles.Produits;
using DistributeurBoissons.Repositories.Common;
using DistributeurBoissons.Repositories.Interfaces;

namespace DistributeurBoissons.Repositories.Repositories
{
    public class TheRepository : GenericRepository<The>, ITheRepository
    {
        public TheRepository()
        {
            LibelleProduit = "Thé";
            PrixProduit = 2.0;
        }
    }
}
