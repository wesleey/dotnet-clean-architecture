using Api.Domain.ValueObjects;

namespace Api.Tests.Core.Domain.ValueObjects;

public class EmailTests
{
    [Fact]
    public void Should_throw_exception_when_email_is_empty()
        => Assert.Throws<ArgumentException>(() => new Email(""));

    [Fact]
    public void Should_throw_exception_when_email_is_not_valid()
        => Assert.Throws<ArgumentException>(() => new Email("invalid_email"));

    [Fact]
    public void Shoud_pass_when_email_is_valid()
    {
        var email = new Email("johndoe@email.com");
        Assert.Equal("johndoe@email.com", email.Address);
    }
}
