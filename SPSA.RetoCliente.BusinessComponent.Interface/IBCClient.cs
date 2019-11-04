using SPSA.RetoCliente.BusinessEntities;

namespace SPSA.RetoCliente.BusinessComponent.Interface
{
    public interface IBCClient
    {
        void Submit(ClientSubmit client);
        Client[] GetClients();
        KPIResult GetKPIResult();
    }
}