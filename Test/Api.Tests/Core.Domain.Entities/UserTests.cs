using Api.Domain.Entities;

namespace Api.Tests.Core.Domain.Entities;

public class UserTests
{
    [Fact]
    public void Should_throw_exception_when_name_is_empty()
        => Assert.Throws<ArgumentException>(() => new User
        {
            Name = "",
            Email = "johndoe@email.com",
            Password = "p@ssw0rd"
        });

    [Fact]
    public void Should_throw_exception_when_email_is_empty()
        => Assert.Throws<ArgumentException>(() => new User
        {
            Name = "John Doe",
            Email = "",
            Password = "p@ssw0rd"
        });

    [Fact]
    public void Should_throw_exception_when_password_is_empty()
        => Assert.Throws<ArgumentException>(() => new User
        {
            Name = "John Doe",
            Email = "johndoe@email.com",
            Password = ""
        });

    [Fact]
    public void Should_throw_exception_when_email_is_not_valid()
        => Assert.Throws<ArgumentException>(() => new User
        {
            Name = "John Doe",
            Email = "invalid_email",
            Password = "p@ssw0rd"
        });

    [Fact]
    public void Shoud_pass_when_email_is_valid()
    {
        var user = new User
        {
            Name = "John Doe",
            Email = "johndoe@email.com",
            Password = "p@ssw0rd"
        };

        Assert.Equal("johndoe@email.com", user.Email);
    }
}
