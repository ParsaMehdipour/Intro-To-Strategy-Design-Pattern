namespace DemoLibrary.Interfaces;

/// <summary>
/// The Strategy interface declares operations common to all supported
/// versions of some algorithm.
///
/// The Context uses this interface to call the algorithm defined by Concrete
/// Strategies.
/// </summary>
public interface IDiscountStrategy
{
    decimal CalculateDiscount(decimal orderTotal, Customer customer);
}
