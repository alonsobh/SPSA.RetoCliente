using Microsoft.Practices.Unity.Configuration;
using System.Configuration;
using Unity;

namespace SPSA.RetoCliente.UnityContainer
{
    public abstract class UnityFactory
    {
        protected UnityFactory() => CreateUnityContainer();
        private void CreateUnityContainer()
        {
            container = new Unity.UnityContainer();
            var section = GetSection();
            section.Configure(container);
        }

        public UnityConfigurationSection GetSection()
        {
            var configSection = ConfigurationManager.GetSection(SectionName);
            return (UnityConfigurationSection)configSection;
        }

        public void ReloadSection(UnityConfigurationSection section)
            => section.Configure(container);

        protected abstract string SectionName { get; }
        protected T Create<T>() => container.Resolve<T>();
        private IUnityContainer container;
    }
}