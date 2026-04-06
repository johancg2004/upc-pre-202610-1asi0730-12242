using oop_sample.Shared.Domain.Model.ValueObjects;

namespace oop_sample.SCM.Domain.Model.Aggregates;

public class Supplier(string identifier, string name, Address address, string address1)
{
    public string Identifier = identifier ?? throw new ArgumentNullException(nameof(identifier));
    public string Name { get; init; } = name ?? throw new ArgumentNullException(nameof(name));
    public Address Address { get; init; } = address ?? throw new ArgumentNullException(nameof(address));
}