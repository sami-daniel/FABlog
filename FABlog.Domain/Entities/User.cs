namespace FABlog.Domain.Entities;

/// <summary>
/// User entity.
/// </summary>
public class User
{
    /// <summary>
    /// The User ID.
    /// </summary>
    public required Guid UserID { get; set; }
    
    /// <summary>
    /// The user name.
    /// </summary>
    public required string UserName { get; set; }
    
    /// <summary>
    /// The user email.
    /// </summary>
    public required string UserEmail { get; set; }

    /// <summary>
    /// The user password.
    /// </summary>
    public required string UserPassword { get; set; }
}
