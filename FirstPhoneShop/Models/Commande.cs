using Microsoft.VisualBasic;
using System;

namespace FirstPhoneShop.Models
{
    public class Commande
    { 
        public int Id { get; set; }
      //  public int ProduitId { get; set; }
        public int ClientId { get; set; }
        public int Quantite { get; set; }
        public DateTime DateAchat { get;set;}
       // public Produit Produit { get; set; }
        public Client Client { get; set; }

    }
}
