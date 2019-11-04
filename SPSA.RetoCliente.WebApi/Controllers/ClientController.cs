using System.Collections.Generic;
using System.Web.Http;
using SPSA.RetoCliente.BusinessComponent.Interface;
using SPSA.RetoCliente.BusinessComponent.Interface.Factory;
using SPSA.RetoCliente.BusinessEntities;

namespace SPSA.RetoCliente.WebApi.Controllers
{
    [RoutePrefix("api/client")]
    public class ClientController : ApiController
    {
        public ClientController()
        {

        }
        [System.Web.Http.HttpPost, System.Web.Http.Route("creacliente")]
        public void CreaCliente([FromBody]ClientSubmit clienteDto)
            => BCClient.Value.Submit(clienteDto);


        [System.Web.Http.HttpGet, System.Web.Http.Route("listclientes")]
        public IEnumerable<SPSA.RetoCliente.BusinessEntities.Client> ListClientes()
            => BCClient.Value.GetClients();

        [System.Web.Http.HttpGet, System.Web.Http.Route("kpideclientes")]
        public KPIResult KpiDeClientes()
            => BCClient.Value.GetKPIResult();
        private readonly BusinessComponentClass<IBCClient> BCClient = new BusinessComponentClass<IBCClient>();
    }
}