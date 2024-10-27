using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Api.Persistence.Repositories;

public class UserRepository(AppDbContext context) : BaseRepository<User>(context), IUserRepository
{
    public async Task<User?> Get(string email, CancellationToken cancellationToken)
        => await Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
}
