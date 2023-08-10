namespace DLWMS.ConsoleApp.Predavanja.P3.Repository;

public interface IRepository<T>
{
    T GetById(int id);
    void Save(T Entity);
    void Delete(T Entity);
}