namespace FirstPhoneShop.Models
{
    public class LigneCommande
    {
        public int CommandeId { get; set; }
        public int ProduitId { get;set; }
        public Produit produit { get; set; }
        public Commande commande { get; set; }
        public string PrixTotal { get; set; }
    }
}
