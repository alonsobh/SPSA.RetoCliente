using SPSA.RetoCliente.BusinessEntities;
using SPSA.RetoCliente.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SPSA.RetoCliente.DataAccess.InMemory
{
    public class DAClientInMemory : IDAClient
    {
        public void Submit(ClientSubmit client)
            => clients.Add(new ClientSubmit { Names = client.Names, LastNames = client.LastNames, BirthDay = client.BirthDay });

        public ClientSubmit[] GetClients()
            => clients.ToArray();

        public DateTime[] GetBirthDates()
            => clients.Select(c => c.BirthDay).ToArray();

        private readonly List<ClientSubmit> clients = new List<ClientSubmit>();
    }
}