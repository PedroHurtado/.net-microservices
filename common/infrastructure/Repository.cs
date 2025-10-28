namespace webapi.common.infrastructure;

interface IAdd<T>
{
    Task Add(T entity);
}
interface IGet<T, ID>
{
    Task<T> Get(ID id);
}

interface IUpdate<T, ID> : IGet<T, ID>
{
    Task Update(T entity);
}

interface IRemove<T, ID>:IGet<T,ID>
{
    Task Update(T entity);
}