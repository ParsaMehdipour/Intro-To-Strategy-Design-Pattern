using DemoLibrary.Interfaces;

namespace DemoLibrary.ConcreteStrategies;

/// <summary>
/// Concrete strategy for VIP member discount
/// </summary>
public class VipMemberDiscountStrategy : IDiscountStrategy
{
    public decimal CalculateDiscount(decimal orderTotal, Customer customer)
    {
        // VIP members get flat 15% discount
        return customer.IsVipMember ? orderTotal * 0.15m : 0;
    }
}
