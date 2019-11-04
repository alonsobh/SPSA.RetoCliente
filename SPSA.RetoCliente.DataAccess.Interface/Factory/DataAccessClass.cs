namespace SPSA.RetoCliente.DataAccess.Interface.Factory
{
    public class DataAccessClass<T>
    {
        public T Value => DataAccess;

        protected T DataAccess = DataAccessFactory.CreateDataAccess<T>();
    }
}