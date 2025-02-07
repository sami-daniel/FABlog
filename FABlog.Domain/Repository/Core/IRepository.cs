using FABlog.Domain.Utils;

namespace FABlog.Domain.Repository.Core;

public interface IRepository<T> where T : class
{
    /// <summary>
    /// Retrives an entity from Data Source.
    /// </summary>
    /// <param name="entityID">The entity ID.</param>
    /// <returns>The entity</returns>
    Result<T> GetEntity(Guid entityID);
    Task<Result<T>> GetEntityAsync(Guid entityID);

    void Delete(Guid entityID);
    void Update(Guid entityID, T newlyEntityData);
}
