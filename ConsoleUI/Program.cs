// Create a customer
using DemoLibrary;
using DemoLibrary.ConcreteStrategies;
using DemoLibrary.Contexts;

var customer = new Customer(
    name: "John Doe",
    joinDate: DateTime.Now.AddYears(-2),
    loyaltyPoints: 1000,
    isVipMember: true
);

// Create order processor
var orderProcessor = new OrderProcessor();
decimal orderTotal = 100.00m;

// Process order with different discount strategies

// 1. Using VIP member discount
orderProcessor.SetDiscountStrategy(new VipMemberDiscountStrategy());
decimal vipPrice = orderProcessor.ProcessOrder(orderTotal, customer);
Console.WriteLine($"Price after VIP discount: ${vipPrice}"); // Shows $85.00 (15% off)

// 2. Using loyalty points discount
orderProcessor.SetDiscountStrategy(new LoyaltyPointsDiscountStrategy());
decimal loyaltyPrice = orderProcessor.ProcessOrder(orderTotal, customer);
Console.WriteLine($"Price after loyalty points discount: ${loyaltyPrice}"); // Shows $90.00 (10% off)

// 3. Using seasonal discount (e.g., holiday sale)
var holidaySale = new SeasonalDiscountStrategy(
    discountPercentage: 0.25m,
    startDate: DateTime.Now.AddDays(-1),
    endDate: DateTime.Now.AddDays(5)
);
orderProcessor.SetDiscountStrategy(holidaySale);
decimal seasonalPrice = orderProcessor.ProcessOrder(orderTotal, customer);
Console.WriteLine($"Price after seasonal discount: ${seasonalPrice}"); // Shows $75.00 (25% off)