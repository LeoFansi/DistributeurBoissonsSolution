using DistributeurBoissons.Repositories.Interfaces;
using DistributeurBoissons.Repositories.Repositories;
using System.Collections.Generic;

namespace DistributeurBoissons.Builder
{
    public class TheBuilder : AbstractBuillder
    {
        public override void AjouterProduit()
        {
            IDictionary<IGenericRepository, int> listeProduits = new Dictionary<IGenericRepository, int>
            {
                { new TheRepository(), 1 },
                { new EauRepository(), 2 }
            };
            RecupererBoisson().ListeProduits = listeProduits;
        }

        public override void SetNomBoisson()
        {
            RecupererBoisson().NomBoisson = "Thé";
        }
    }
}
