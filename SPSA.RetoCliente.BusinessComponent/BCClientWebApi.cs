using RestSharp;
using SPSA.RetoCliente.BusinessComponent.Interface;
using SPSA.RetoCliente.BusinessEntities;

namespace SPSA.RetoCliente.BusinessComponent
{
    public class BCClientWebApi : IBCClient
    {
        private string url = "http://localhost/SPSA.RetoCliente.WebApi/api/client/";
        public void Submit(ClientSubmit client)
        {
            var restClient = new RestClient(url + "/creacliente");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", Newtonsoft.Json.JsonConvert.SerializeObject(client), ParameterType.RequestBody);
            IRestResponse response = restClient.Execute(request);
        }


        public Client[] GetClients()
        {
            var client = new RestClient(url + "/listclientes");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Client[]>(response.Content);
        }

        public KPIResult GetKPIResult()
        {
            var client = new RestClient(url + "/kpideclientes");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<KPIResult>(response.Content);
        }
    }
}