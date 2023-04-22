using FirstPhoneShop.DataContext;
using FirstPhoneShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstPhoneShop.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly PhoneShopContext db;

        public ClientRepository(PhoneShopContext Db)
        {
            db=Db;
        }

        public List<Client> RetourneClients()
        {
            var clients = db.Clients.ToList();
            return clients;
        }

        public Client RetourneUnClientParSonNom(int id)
        {
            var client = db.Clients.FirstOrDefault(x => x.Id == id);
            return client;
        }
    }
}
