namespace DLWMS.ConsoleApp.Predavanja.P3.Repository;

public class Repository<T> : IRepository<T>
{
    public T GetById(int id)
    {
        return default;
    }

    public void Save(T Entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(T Entity)
    {
        throw new NotImplementedException();
    }
}