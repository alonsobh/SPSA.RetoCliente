using System;
using RestSharp;
using SPSA.RetoCliente.BusinessComponent.Interface;
using SPSA.RetoCliente.BusinessEntities;

namespace SPSA.RetoCliente.BusinessComponent
{
    public class BCClientAWSApi : BCClientWebApi
    {
        protected  override string url => "http://spsaretoclientewebapi.sa-east-1.elasticbeanstalk.com/api/client";
    }
}