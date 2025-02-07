using FABlog.Domain.Entities;
using FABlog.Domain.Repository.Core;

namespace FABlog.Domain.Repository.Specialized
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
