using DemoLibrary.Interfaces;

namespace DemoLibrary.ConcreteStrategies;

/// <summary>
/// Concrete strategy for calculating loyalty points based discount
/// </summary>
public class LoyaltyPointsDiscountStrategy : IDiscountStrategy
{
    public decimal CalculateDiscount(decimal orderTotal, Customer customer)
    {
        // 1 point = 0.1% discount, max 20% discount
        decimal discountPercentage = Math.Min(customer.LoyaltyPoints * 0.001m, 0.20m);
        return orderTotal * discountPercentage;
    }
}