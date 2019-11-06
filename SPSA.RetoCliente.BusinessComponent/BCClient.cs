using MoreLinq;
using SPSA.RetoCliente.BusinessComponent.Interface;
using SPSA.RetoCliente.BusinessEntities;
using SPSA.RetoCliente.DataAccess.Interface;
using SPSA.RetoCliente.DataAccess.Interface.Factory;
using System;
using System.Linq;

namespace SPSA.RetoCliente.BusinessComponent
{
    public class BCClient : IBCClient
    {
        public void Submit(ClientSubmit client)
        {
            if (string.IsNullOrEmpty(client.Names?.Trim()))
                throw new Exception("Nombre es necesario");
            if (string.IsNullOrEmpty(client.LastNames?.Trim()))
                throw new Exception("Apellido es necesario");
            if (client.BirthDay > DateTime.Now)
                throw new Exception("Fecha Nacimiento no puede ser mayor a la fecha actual");
            DACliente.Value.Submit(client);
        }

        public Client[] GetClients(int edadMuerte)
        {
            var results = DACliente.Value.GetClients()
                .Select(s => new Client { Names = s.Names, LastNames = s.LastNames, BirthDay = s.BirthDay, ProbableDeathDay = s.BirthDay.AddYears(edadMuerte) })
                .ToArray();
            var now = DateTime.Now;
            results.ForEach(r =>
                r.Age = CalculateAge(now, r.BirthDay));
            return results;
        }

        private int CalculateAge(DateTime now, DateTime birthDate)
            => (int)((now - birthDate).TotalDays / 365);

        public KPIResult GetKPIResult()
        {
            var now = DateTime.Now;
            var edades = DACliente.Value.GetBirthDates().Select(b => CalculateAge(now, b));
            if (!edades.Any())
                return new KPIResult();

            var avg = edades.Average();
            var sdList = edades.Select(e => e - avg);
            sdList = sdList.Select(e => e * e);
            double sd = sdList.Sum() / sdList.Count();
            return new KPIResult { Average = avg, StandardDeviation = sd };
        }
        private readonly DataAccessClass<IDAClient> DACliente = new DataAccessClass<IDAClient>();
    }
}