namespace DomainDrivenDesign.Domain.Shared;

public sealed record Name
{
    public string Value { get; init; }
    public Name(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentNullException("The name cannot be empty");
        }

        if (value.Length < 3)
        {
            throw new ArgumentException("The name cannot be less than 3 characters!");
        }

        Value = value;
    }
}