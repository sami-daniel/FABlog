using FABlog.Domain.Utils;

namespace FABlog.Domain.Repository.Core
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        public virtual void Delete(Guid entityID)
        {
            throw new NotImplementedException();
        }

        public virtual Result<T> GetEntity(Guid entityID)
        {
            throw new NotImplementedException();
        }

        public virtual Task<Result<T>> GetEntityAsync(Guid entityID)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(Guid entityID, T newlyEntityData)
        {
            throw new NotImplementedException();
        }
    }
}
