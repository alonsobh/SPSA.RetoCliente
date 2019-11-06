using RestSharp;
using SPSA.RetoCliente.BusinessComponent.Interface;
using SPSA.RetoCliente.BusinessEntities;
using System;

namespace SPSA.RetoCliente.BusinessComponent
{
    public class BCClientWebApi : IBCClient
    {
        public void Submit(ClientSubmit client)
        {
            var restClient = new RestClient(url + "/creacliente");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", Newtonsoft.Json.JsonConvert.SerializeObject(client), ParameterType.RequestBody);
            IRestResponse response = restClient.Execute(request);
            var result = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseResult>(response.Content);
            if (!result.IsCompleted)
                throw new Exception(result.ErrorMessage);
        }


        public Client[] GetClients(int edadMuerte)
        {
            var client = new RestClient(url + $"/listclientes/{edadMuerte}");
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
        protected virtual string url { get; } = "http://localhost/SPSA.RetoCliente.WebApi/api/client";
    }
}