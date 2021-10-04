using DistributeurBoissons.Repositories.Interfaces;
using DistributeurBoissons.Repositories.Repositories;
using System.Collections.Generic;

namespace DistributeurBoissons.Builder
{
    public class ExpressoBuilder : AbstractBuillder
    {
        public override void AjouterProduit()
        {
            IDictionary<IGenericRepository, int> listeProduits = new Dictionary<IGenericRepository, int>
            {
                { new CafeRepository(), 1 },
                { new EauRepository(), 1 }
            };
            RecupererBoisson().ListeProduits = listeProduits;
        }

        public override void SetNomBoisson()
        {
            RecupererBoisson().NomBoisson = "Expresso";
        }
    }
}
