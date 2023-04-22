namespace FirstPhoneShop.Models
{
    public class Produit
    {
       public int Id { get; set; } 
        public string Nom { get; set; }
        public string Modele { get; set; }
        public int Prix { get; set; }
        public int CategorieId { get; set; }
        public Categorie Categorie { get; set; }
     
    }
}
