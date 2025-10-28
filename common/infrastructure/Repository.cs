namespace webapi.common.infrastructure;
public interface IAdd<in T>
{
    Task AddAsync(T entity, CancellationToken cancellationToken = default);
}

public interface IGet<T, in TId>
{
    Task<T?> GetAsync(TId id, CancellationToken cancellationToken = default);
}

public interface IUpdate<in T, in TId> : IGet<T, TId>
{
    Task UpdateAsync(T entity, CancellationToken cancellationToken = default);
}

public interface IRemove<T, in TId> : IGet<T, TId>
{
    Task RemoveAsync(TId id, CancellationToken cancellationToken = default);
}