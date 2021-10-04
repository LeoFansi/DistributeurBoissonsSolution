using DistributeurBoissons.Repositories.Interfaces;
using DistributeurBoissons.Repositories.Repositories;
using System.Collections.Generic;

namespace DistributeurBoissons.Builder
{
    public class ChocolatBuilder : AbstractBuillder
    {
        public override void AjouterProduit()
        {
            IDictionary<IGenericRepository, int> listeProduits = new Dictionary<IGenericRepository, int>
            {
                { new ChocolatRepository(), 3 },
                { new LaitRepository(), 2 },
                { new EauRepository(), 1 },
                { new SucreRepository(), 1 }
            };
            RecupererBoisson().ListeProduits = listeProduits;
        }

        public override void SetNomBoisson()
        {
            RecupererBoisson().NomBoisson = "Chocolat";
        }
    }
}
