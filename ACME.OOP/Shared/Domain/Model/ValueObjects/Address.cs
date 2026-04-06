namespace oop_sample.Shared.Domain.Model.ValueObjects;
/// <summary>
/// Representa an international physical address value objects
/// </summary>
public record Address
{
    public string Street;
    public string Number;
    public string City;
    public string? StateOrRegion;
    public string PostalCode;
    public string Country;
    
    /// <summary>
    /// Creates a new instance of <see cref="Address"/>
    /// </summary>
    /// <param name="street">the address street, which must not be null or blank</param>
    /// <param name="number">the address number, which muts not be null or blank</param>
    /// <param name="city">the address city, which muts not be null or blank</param>
    /// <param name="stateOrRegion">the state or region</param>
    /// <param name="postalCode">the address postal code, which muts not be null or blank</param>
    /// <param name="country">the address country, which muts not be null or blank</param>
    /// <exception cref="ArgumentException">thrown when any required parameter is null or blank</exception>

    public Address(string street, string number, string city, string? stateOrRegion, string postalCode, string country)
    {
        if(string.IsNullOrWhiteSpace(street)) throw new ArgumentException("Street cannot be null or empty");
        if(string.IsNullOrWhiteSpace(number)) throw new ArgumentException("Number cannot be null or empty");
        if(string.IsNullOrWhiteSpace(city)) throw new ArgumentException("City cannot be null or empty");
        if(string.IsNullOrWhiteSpace(city)) throw new ArgumentException("City cannot be null or empty");
        if(string.IsNullOrWhiteSpace(postalCode)) throw new ArgumentException("Postal code cannot be null or empty");
        if(string.IsNullOrWhiteSpace(country)) throw new ArgumentException("Country cannot be null or empty");
        Street = street;
        Number = number;
        City = city;
        StateOrRegion = stateOrRegion;
        PostalCode = postalCode;
        Country = country;
    }
    /// <summary>
    /// Returns the string representation of the address in the format: "Street, number, City, StateOrRegion, postalCode, Country"
    /// </summary>
    /// <returns>String containing the address values</returns>
    public override string ToString() => $"{Street} {Number} {City} {StateOrRegion} {PostalCode} {Country}";
}