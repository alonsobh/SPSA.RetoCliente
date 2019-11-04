using Microsoft.Practices.Unity.Configuration;
using System.Configuration;
using System.IO;
using System.Xml;

namespace SPSA.RetoCliente.Test
{
    public class UnityCustomSection : UnityConfigurationSection
    {
        public string Serialize()
            => SerializeSection(null, UnityConfigurationSection.SectionName,
                ConfigurationSaveMode.Full);
        public void LoadConfigurationFile(string fileName)
            => Deserialize(File.ReadAllText(fileName));

        private void Deserialize(string xml)
        {
            var sr = new StringReader(xml);
            var reader = XmlReader.Create(sr);
            base.DeserializeSection(reader);
        }
    }
}