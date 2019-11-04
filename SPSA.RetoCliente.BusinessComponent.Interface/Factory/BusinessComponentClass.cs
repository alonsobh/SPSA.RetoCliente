namespace SPSA.RetoCliente.BusinessComponent.Interface.Factory
{
    public class BusinessComponentClass<T>
    {
        public T Value => DataAccess;

        protected T DataAccess = BusinessComponentsFactory.CreateBusinessComponentComponent<T>();
    }
}