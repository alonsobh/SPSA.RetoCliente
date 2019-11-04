using System;
using SPSA.RetoCliente.BusinessEntities;

namespace SPSA.RetoCliente.DataAccess.Interface
{
    public interface IDAClient
    {
        void Submit(ClientSubmit client);

        ClientSubmit[] GetClients();

        DateTime[] GetBirthDates();
    }
}