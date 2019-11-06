using System;

namespace SPSA.RetoCliente.BusinessEntities
{
    public class Client
    {
        public string Names { get; set; }
        public string LastNames { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime ProbableDeathDay { get; set; }
        public int Age { get; set; }
    }
}