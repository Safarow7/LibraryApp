namespace Services;

public interface IBaseServise<T>
{
    Guid Create(T entity);

    bool Update(T entity);

    bool Delete(Guid id);

    List<T> Get();

    T? Get(Guid id);
}