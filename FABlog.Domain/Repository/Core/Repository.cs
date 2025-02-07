using FABlog.Domain.Utils;

namespace FABlog.Domain.Repository.Core
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        public abstract void Delete(Guid entityID);

        public abstract Result<T> GetEntity(Guid entityID);

        public abstract Task<Result<T>> GetEntityAsync(Guid entityID);

        public abstract void Update(Guid entityID, T newlyEntityData);
    }
}
