using System;
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
        public ResponseResult CreaCliente([FromBody] ClientSubmit clienteDto)
        {
            var response = new ResponseResult();
            response.IsCompleted = true;
            try
            {
                BCClient.Value.Submit(clienteDto);

            }
            catch (Exception ex)
            {
                response.IsCompleted = false;
                response.ErrorMessage = ex.Message;
            }

            return response;
        }

        [System.Web.Http.HttpGet, System.Web.Http.Route("listclientes/{edadMuerte}")]
        public IEnumerable<SPSA.RetoCliente.BusinessEntities.Client> ListClientes(int edadMuerte)
            => BCClient.Value.GetClients( edadMuerte);

        [System.Web.Http.HttpGet, System.Web.Http.Route("kpideclientes")]
        public KPIResult KpiDeClientes()
            => BCClient.Value.GetKPIResult();
        private readonly BusinessComponentClass<IBCClient> BCClient = new BusinessComponentClass<IBCClient>();
    }
}