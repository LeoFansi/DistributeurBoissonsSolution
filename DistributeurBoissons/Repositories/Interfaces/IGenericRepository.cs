using System;
using System.Collections.Generic;
using System.Text;

namespace DistributeurBoissons.Repositories.Interfaces
{
    public interface IGenericRepository
    {
        /// <summary>
        /// Méthode permettant de récupérer la valeur du libelle .
        /// </summary>
        /// <returns>A string</returns>
        string GetLibelle();

        /// <summary>
        /// Méthode permettant de récupérer le prix.
        /// </summary>
        /// <returns>A double</returns>
        double GetPrix();

        /// <summary>
        /// Méthode permettant de récupérer le nom réel de la classe TEntity.
        /// </summary>
        /// <returns>A string</returns>
        string GetTEntityClassName();

    }
}

