using Microsoft.Practices.Unity.Configuration;
using NUnit.Framework;
using SPSA.RetoCliente.BusinessComponent.Interface;
using SPSA.RetoCliente.BusinessComponent.Interface.Factory;
using SPSA.RetoCliente.BusinessEntities;
using SPSA.RetoCliente.DataAccess.Interface.Factory;
using SPSA.RetoCliente.UnityContainer;
using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Xml;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using TestContext = NUnit.Framework.TestContext;

namespace SPSA.RetoCliente.Test
{
    [TestFixture]
    public abstract class BaseTest
    {
        [Test]
        public void FullTest()
        {
            ReplaceConfig(BusinessComponentsFactory.Current, $"{BusinessComponentUnity}.config");
            ReplaceConfig(DataAccessFactory.Current, $"{DataAccessUnity}.config");
     
            var clientes = BCClient.Value.GetClients(10);
            var i = clientes.Length;
            var newClient = new ClientSubmit
            {
                Names = $"Nombre {i}",
                LastNames = $"Apellidos {i}",
                BirthDay = new DateTime(1950 + i, 1, 1)
            };
            
            BCClient.Value.Submit(newClient);
            var clientesTMP = BCClient.Value.GetClients(10);
            Assert.AreEqual(clientes.Length + 1, clientesTMP.Length);

            var retreivedClient = clientesTMP.Last();
            Assert.AreEqual(newClient.Names, retreivedClient.Names);
            Assert.AreEqual(newClient.LastNames, retreivedClient.LastNames);
            Assert.AreEqual(newClient.BirthDay, retreivedClient.BirthDay);
            Assert.AreNotEqual(0, retreivedClient.Age);

            var kpi = BCClient.Value.GetKPIResult();
            Assert.AreNotEqual(0, kpi.Average);
            if (clientes.Length == 0)
                Assert.AreEqual(0, kpi.StandardDeviation);
            else
                Assert.AreNotEqual(0, kpi.StandardDeviation);
            
            Assert.IsTrue(kpi.Average <= DateTime.Now.Year - 1950 + 1, $"{kpi.Average.ToString()} <= {DateTime.Now.Year - 1950 - 1}");
        }
        protected abstract string BusinessComponentUnity { get; }
        protected abstract string DataAccessUnity { get; }
        private void ReplaceConfig(UnityFactory unityFactory, string newConfigName)
        {
            //Console.WriteLine($"Assembly.GetExecutingAssembly().CodeBase {Assembly.GetExecutingAssembly().CodeBase}");
            //Console.WriteLine($"Environment.CurrentDirectory {Environment.CurrentDirectory}");
            //Console.WriteLine($"TestContext.CurrentContext.TestDirectory {TestContext.CurrentContext.TestDirectory}");
            //Console.WriteLine($"TestContext.CurrentContext.WorkDirectory  {TestContext.CurrentContext.WorkDirectory }");


            var path = Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory);
            var newFile = Path.Combine(path, "Debug", newConfigName);
            var config = new UnityCustomSection();
            config.LoadConfigurationFile(newFile);
            unityFactory.ReloadSection(config);
        }

        BusinessComponentClass<IBCClient> BCClient => _bcClient ?? (_bcClient = new BusinessComponentClass<IBCClient>());
        BusinessComponentClass<IBCClient> _bcClient;
    }
}