namespace DistributeurBoissons.Modeles.Produits
{
    public abstract class ProduitBase
    {
        private string _libelleProduit = "";
        private double _prixProduit;

        public string LibelleProduit { get => _libelleProduit; protected set => _libelleProduit = value; }
        public double PrixProduit { get => _prixProduit; protected set => _prixProduit = value; }
    }
}
