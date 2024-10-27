namespace Api.Application.UseCases.CreateUser;

public sealed record CreateUserResponse
{
    public int Id;
    public string? Name { get; set; }
    public string? Email { get; set; }
}
