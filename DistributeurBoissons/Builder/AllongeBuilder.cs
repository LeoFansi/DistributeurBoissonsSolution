using DistributeurBoissons.Repositories.Interfaces;
using DistributeurBoissons.Repositories.Repositories;
using System.Collections.Generic;

namespace DistributeurBoissons.Builder
{
    public class AllongeBuilder : AbstractBuillder
    {
        public override void AjouterProduit()
        {
            IDictionary<IGenericRepository, int> listeProduits = new Dictionary<IGenericRepository, int>
            {
                { new CafeRepository(), 1 },
                { new EauRepository(), 2 }
            };
            RecupererBoisson().ListeProduits = listeProduits;
        }

        public override void SetNomBoisson()
        {
            RecupererBoisson().NomBoisson = "Allongé";
        }
    }
}
