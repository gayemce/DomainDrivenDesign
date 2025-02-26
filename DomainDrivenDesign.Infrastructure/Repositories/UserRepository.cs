using DomainDrivenDesign.Domain.Users;
using DomainDrivenDesign.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace DomainDrivenDesign.Infrastructure.Repositories;
internal sealed class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<User> CreateAsync(string name, string email, string password, string country, string city, string street, string fullAddress, string postalCode, CancellationToken cancellationToken = default)
    {
        User user = User.CreateUser(name, email, password, country, city, street, fullAddress, postalCode);
        await _context.Users.AddAsync(user, cancellationToken);

        return user;
    }

    public Task<List<User>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return _context.Users.ToListAsync(cancellationToken);
    }
}
