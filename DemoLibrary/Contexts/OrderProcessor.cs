using DemoLibrary.Interfaces;

namespace DemoLibrary.Contexts;

/// <summary>
/// The Context defines the interface of interest to clients.
/// </summary>
public class OrderProcessor
{
    // The Context maintains a reference to one of the Strategy objects. The
    // Context does not know the concrete class of a strategy. It should
    // work with all strategies via the Strategy interface.
    private IDiscountStrategy _discountStrategy;

    // Set the discount strategy at runtime
    public void SetDiscountStrategy(IDiscountStrategy strategy)
    {
        _discountStrategy = strategy;
    }

    // Process the order using the selected discount strategy
    public decimal ProcessOrder(decimal orderTotal, Customer customer)
    {
        if (_discountStrategy == null)
        {
            return orderTotal; // No discount applied
        }

        decimal discount = _discountStrategy.CalculateDiscount(orderTotal, customer);
        return orderTotal - discount;
    }
}