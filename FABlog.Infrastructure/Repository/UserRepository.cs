using FABlog.Domain.Entities;
using FABlog.Domain.Repository.Core;
using FABlog.Domain.Repository.Specialized;
using FABlog.Domain.Utils;

namespace FABlog.Infrastructure.Repository;

internal class UserRepository : Repository<User>, IUserRepository
{
    public override void Delete(Guid entityID)
    {
        throw new NotImplementedException();
    }

    public override Result<User> GetEntity(Guid entityID)
    {
        throw new NotImplementedException();
    }

    public override Task<Result<User>> GetEntityAsync(Guid entityID)
    {
        throw new NotImplementedException();
    }

    public override void Update(Guid entityID, User newlyEntityData)
    {
        throw new NotImplementedException();
    }
}
