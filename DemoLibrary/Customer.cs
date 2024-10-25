namespace DemoLibrary;

/// <summary>
/// Represents a customer with relevant properties for discount calculation
/// </summary>
public class Customer
{
    public string Name { get; set; }
    public DateTime JoinDate { get; set; }
    public int LoyaltyPoints { get; set; }
    public bool IsVipMember { get; set; }

    public Customer(string name, DateTime joinDate, int loyaltyPoints, bool isVipMember)
    {
        Name = name;
        JoinDate = joinDate;
        LoyaltyPoints = loyaltyPoints;
        IsVipMember = isVipMember;
    }
}
