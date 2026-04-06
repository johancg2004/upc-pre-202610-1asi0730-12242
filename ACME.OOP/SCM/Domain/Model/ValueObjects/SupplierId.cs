namespace oop_sample.SCM.Domain.Model.ValueObjects;

/// <summary>
/// Represents a supplier identifier value object in the Supply Chain Management (SCM) bounded context.
/// </summary>
public record SupplierId
{
    public string Identifier { get; init; }

    /// <summary>
    /// Creates a new instance of <see cref="SupplierId"/>
    /// </summary>
    /// <param name="identifier">The unique identifier for the supplier. It should not be null empty, or whitespace</param>
    /// <exception cref="ArgumentException">Thrown when the provided identifier is null, empty, or consist only of whitespace</exception>
    public SupplierId(string identifier)
    {
        if(string.IsNullOrWhiteSpace(identifier)) 
            throw new ArgumentException("Supplier identifier should not be null or whitespace", nameof(identifier));
        Identifier = identifier;
    }
}