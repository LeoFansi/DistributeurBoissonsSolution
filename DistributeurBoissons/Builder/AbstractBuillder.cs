using DistributeurBoissons.Modeles;
using DistributeurBoissons.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace DistributeurBoissons.Builder
{
    public abstract class AbstractBuillder : IBoissonBuilder
    {
        protected Boisson boisson;
        public static double MargeCalcul { get; set; } = 0.3;

        public void CreerBoisson()
        {
            boisson = new Boisson
            {
                ListeProduits = new Dictionary<IGenericRepository, int>()
            };
        }

        public Boisson RecupererBoisson()
        {
            return boisson;
        }

        public double RecupererPrixBoisson()
        {
            foreach (KeyValuePair<IGenericRepository, int> kvp in boisson.ListeProduits)
            {
                RecupererBoisson().PrixBoisson += kvp.Value * kvp.Key.GetPrix();
            }

            RecupererBoisson().PrixBoisson += MargeCalcul * boisson.PrixBoisson;
            RecupererBoisson().PrixBoisson = Math.Round(RecupererBoisson().PrixBoisson, 2);

            return RecupererBoisson().PrixBoisson ;
        }

        public abstract void AjouterProduit();

        public abstract void SetNomBoisson();
        
    }
}
