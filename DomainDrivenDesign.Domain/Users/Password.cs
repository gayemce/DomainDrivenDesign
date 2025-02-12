namespace DomainDrivenDesign.Domain.Users;

public sealed record Password
{
    public string Value { get; init; }
    public Password(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentNullException("Password cannot be empty");
        }

        if (value.Length < 6)
        {
            throw new ArgumentException("Password cannot be smaller than 6 characters!");
        }

        Value = value;
    }
}
