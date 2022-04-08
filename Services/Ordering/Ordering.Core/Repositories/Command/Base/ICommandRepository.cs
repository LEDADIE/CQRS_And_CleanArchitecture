using Ordering.Core.Entities.Base;

namespace Ordering.Core.Repositories.Command.Base;

public interface ICommandRepository<T> where T : class
{
    Task<T> AddAsync(T entity);

    Task DeleteAsync(T entity);

    Task UpdateAsync(T entity);
}