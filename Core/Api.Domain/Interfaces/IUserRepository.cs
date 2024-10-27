using Api.Domain.Entities;

namespace Api.Domain.Interfaces;

public interface IUserRepository : IBaseRepository<User>
{
    public Task<User?> Get(string email, CancellationToken cancellationToken);
}
