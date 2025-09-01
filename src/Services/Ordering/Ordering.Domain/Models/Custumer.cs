namespace Ordering.Domain.Models;
public class Custumer : Entity<CustomerId>
{
    public string Name { get; private set; } = default!;
    public string Email { get; private set; } = default!;

    public static Custumer Create(CustomerId id, string name, string email)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        ArgumentException.ThrowIfNullOrWhiteSpace(email);

        var custumer = new Custumer
        {
            Id = id,
            Name = name,
            Email = email
        };

        return custumer;
    }
}
