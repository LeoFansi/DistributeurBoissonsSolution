using DistributeurBoissons.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace DistributeurBoissons.Modeles
{
    public class Boisson
    {
        public double PrixBoisson { get; set; }
        public string NomBoisson { get; set; }
        public IDictionary<IGenericRepository, int> ListeProduits { get; set; }

        public string AfficherBoisson()
        {
            return $"Boisson choisie: {NomBoisson} --- Prix: {PrixBoisson} Euro(s)";
        }
    }
}
