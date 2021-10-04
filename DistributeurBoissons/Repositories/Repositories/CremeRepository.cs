using DistributeurBoissons.Modeles.Produits;
using DistributeurBoissons.Repositories.Common;
using DistributeurBoissons.Repositories.Interfaces;

namespace DistributeurBoissons.Repositories.Repositories
{
    public class CremeRepository : GenericRepository<Creme>, ICremeRepository
    {
        public CremeRepository()
        {
            LibelleProduit = "Crème";
            PrixProduit = 0.5;
        }
    }
}
