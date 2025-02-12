namespace DomainDrivenDesign.Domain.Users;

public sealed record Email
{
    public string Value { get; init; }
    public Email(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentNullException("Email cannot be empty");
        }

        if (value.Length < 3)
        {
            throw new ArgumentException("Email cannot be smaller than 3 characters!");
        }

        if(!value.Contains("@"))
        {
            throw new ArgumentException("Enter a valid email address!");
        }

        Value = value;
    }
}
