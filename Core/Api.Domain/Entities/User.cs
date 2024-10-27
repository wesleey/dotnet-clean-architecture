using Api.Domain.ValueObjects;

namespace Api.Domain.Entities;

public sealed class User : BaseEntity
{
    private string _name = string.Empty;
    public required string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Name cannot be empty.");
            _name = value;
        }
    }

    private string _email = string.Empty;
    public required string Email
    {
        get => _email;
        set => _email = new Email(value).Address;
    }

    private string _password = string.Empty;
    public required string Password
    {
        get => _password;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Password cannot be empty.");
            _password = value;
        }
    }
}
