using SPSA.RetoCliente.UnityContainer;

namespace SPSA.RetoCliente.DataAccess.Interface.Factory
{
    public class DataAccessFactory : UnityFactory
    {
        internal static T CreateDataAccess<T>() => Current.Create<T>();
        public static DataAccessFactory Current
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
                    instance = new DataAccessFactory();
            }
        }
        
        protected override string SectionName  => "unityDataAccess";

        //-- Singleton behavior attributes
        private static readonly object syncObject = new object();
        private static volatile DataAccessFactory instance;
    }
}
