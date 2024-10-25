using DemoLibrary.Interfaces;

namespace DemoLibrary.ConcreteStrategies;

/// <summary>
/// Concrete strategy for seasonal holiday discount
/// </summary>
public class SeasonalDiscountStrategy : IDiscountStrategy
{
    private readonly decimal _discountPercentage;
    private readonly DateTime _startDate;
    private readonly DateTime _endDate;

    public SeasonalDiscountStrategy(decimal discountPercentage, DateTime startDate, DateTime endDate)
    {
        _discountPercentage = discountPercentage;
        _startDate = startDate;
        _endDate = endDate;
    }

    public decimal CalculateDiscount(decimal orderTotal, Customer customer)
    {
        // Check if current date is within seasonal discount period
        if (DateTime.Now >= _startDate && DateTime.Now <= _endDate)
        {
            return orderTotal * _discountPercentage;
        }
        return 0;
    }
}
