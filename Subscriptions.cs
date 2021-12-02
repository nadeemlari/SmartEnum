using Ardalis.SmartEnum;

namespace SmartEnum;

public sealed class Subscriptions: SmartEnum<Subscriptions>
{
    public double Discount { get; }
    public static readonly Subscriptions Free = new("Free", 1,0);
    public static readonly Subscriptions Premium = new("Premium", 2,.25);
    public static readonly Subscriptions Vip = new("VIP", 3,.5);
    public Subscriptions(string name, int value ,double discount) : base(name, value)
    {
        Discount = discount;
    }
}