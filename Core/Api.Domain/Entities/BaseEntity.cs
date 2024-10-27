namespace Api.Domain.Entities;

public abstract class BaseEntity
{
    public int Id { get; }
    public DateTimeOffset DateCrated { get; set; }
    public DateTimeOffset DateUpdated { get; set; }
}
