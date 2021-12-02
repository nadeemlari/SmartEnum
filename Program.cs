using SmartEnum;

var free1  = Subscriptions.Free;
var free2  = Subscriptions.Free;
var free3 = Subscriptions.FromName("Free");
var free4 = Subscriptions.FromValue(1);

var vip = Subscriptions.Vip;
Console.Write(free1==free2);
Console.WriteLine($"Discount for {vip.Name} was {vip.Discount}");