namespace DomainDrivenDesign.Domain.Users;
public interface IUserRepository
{
    Task<User> CreateAsync(string name, string email, string password, string country, string city, string street, string fullAddress, string postalCode, CancellationToken cancellationToken = default);
    Task<List<User>> GetAllAsync(CancellationToken cancellationToken = default);
}
