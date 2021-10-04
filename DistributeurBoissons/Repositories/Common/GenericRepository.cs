using DistributeurBoissons.Repositories.Interfaces;
using DistributeurBoissons.Modeles;
using System;
using System.Collections.Generic;
using System.Text;
using DistributeurBoissons.Modeles.Produits;

namespace DistributeurBoissons.Repositories.Common
{
    public class GenericRepository<TEntity> : ProduitBase, IGenericRepository where TEntity : ProduitBase
    {

        public virtual string GetLibelle()
        {
            return LibelleProduit;
        }

        public virtual double GetPrix()
        {
            return PrixProduit;
        }

        public virtual string GetTEntityClassName()
        {
            return typeof(TEntity).Name;
        }
    }
}
