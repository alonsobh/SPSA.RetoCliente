using SPSA.RetoCliente.BusinessEntities;
using SPSA.RetoCliente.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SPSA.RetoCliente.DataAccess.IOFile
{
    public class DAClienteIOFile : IDAClient
    {
        public DAClienteIOFile()
        {
            Console.WriteLine(FilePath);
            if (!File.Exists(FilePath))
            {
                clients = new List<ClientSubmit>();
                SaveToFile();
                return;
            }
            var readText = File.ReadAllText(FilePath);
            clients = Newtonsoft.Json.JsonConvert.DeserializeObject<ClientSubmit[]>(readText).ToList();
        }

        public void Submit(ClientSubmit client)
        {
            clients.Add(new ClientSubmit { Names = client.Names, LastNames = client.LastNames, BirthDay = client.BirthDay });
            SaveToFile();
        }

        private void SaveToFile()
        {
            var text = Newtonsoft.Json.JsonConvert.SerializeObject(clients);
            string fileName = Path.Combine(FolderPath, FilePath);

            if (File.Exists(fileName))
                File.Delete(fileName);
            if (!Directory.Exists(FolderPath))
                Directory.CreateDirectory(FolderPath);
            using (FileStream fs = File.Create(fileName))
            {
                Byte[] title = new UTF8Encoding(true).GetBytes(text);
                fs.Write(title, 0, title.Length);
            }
        }
        public string FolderPath => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Files");
        private string FilePath => Path.Combine(FolderPath, "Clientes.txt");

        public ClientSubmit[] GetClients()
            => clients.ToArray();
        
        public DateTime[] GetBirthDates()
            => clients.Select(c => c.BirthDay).ToArray();

        private List<ClientSubmit> clients;
    }
}