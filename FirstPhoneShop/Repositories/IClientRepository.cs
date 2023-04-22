using FirstPhoneShop.Models;
using System.Collections.Generic;

namespace FirstPhoneShop.Repositories
{
    public interface IClientRepository
    {
        Client RetourneUnClientParSonNom(int id);
        List<Client> RetourneClients();
    }
}