namespace oop_sample.Shared.Domain.Model.ValueObjects;
/// <summary>
/// Represents a monetary value with
/// </summary>
public record Money
{
    public decimal Amount { get; init; }
    public string Currency { get; init; }
    
    /// <summary>
    /// Create a new instance of <see cref="Money"/>
    /// </summary>
    /// <param name="amount">The monetary amount</param>
    /// <param name="currency">The currency</param>
    /// <exception cref="ArgumentException">Thrown when the currency is not a valid 3-letter ISO code.</exception>
    public Money(decimal amount, string currency)
    {
        if(string.IsNullOrWhiteSpace(currency) || currency.Length != 3) 
            throw new ArgumentException("Currency must be a 3-letter code", nameof(currency));
        Amount = amount;
        Currency = currency;
    }
    
    /// <summary>
    /// Returns a string representation of the money, combining the amount and currency
    /// </summary>
    /// <returns>A string in the format "Amount Currency"</returns>
    public override string ToString() => $"{Amount} {Currency}";
    
    /// <summary>
    /// Adds two <see cref="Money"/>
    /// </summary>
    /// <param name="other">The other <see cref="Money"/>to add. Must have the same currency</param>
    /// <returns>A new <see cref="Money"/>instance with the combined amount if the currencies match; otherwise, throwns an exception</returns>
    /// <exception cref="InvalidOperationException">Thrown when the currencies do not match</exception>
    public Money Add(Money? other)
    {
        if (other != null && Currency != other.Currency)
            throw new InvalidOperationException("Cannot add money with different currencies");
        return other == null ? this: new(Amount + other.Amount, Currency);
    }
    
    /// <summary>
    /// Multiplies the monetary value by a factor
    /// </summary>
    /// <param name="multiplier">The factor to multiply the amount by</param>
    /// <returns>A new <see cref="Money"/>instance with the multiplied amount</returns>
    public Money Multiply(int multiplier) => new(Amount * multiplier, Currency);
}