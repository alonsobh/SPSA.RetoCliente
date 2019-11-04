using SPSA.RetoCliente.UnityContainer;

namespace SPSA.RetoCliente.BusinessComponent.Interface.Factory
{
    public class BusinessComponentsFactory : UnityFactory
    {
        internal static T CreateBusinessComponentComponent<T>() => Current.Create<T>();

        public static BusinessComponentsFactory Current
        {
            get
            {
                EnsureCurrentInstance();
                return instance;
            }
        }
        private static void EnsureCurrentInstance()
        {
            if (instance != null)
                return;
            lock (syncObject)
            {
                if (instance == null)
                    instance = new BusinessComponentsFactory();
            }
        }

        protected override string SectionName => "unityBusinessComponent";

        //-- Singleton behavior attributes
        private static readonly object syncObject = new object();
        private static volatile BusinessComponentsFactory instance;
    }
}
