namespace Composite
{
    public class Program
    {
        static void Main()
        {
            SingleGift phone = new SingleGift("Phone", 256);
            phone.CalculateTotalPrice();
            Console.WriteLine();

            CompositeGift rootbox = new CompositeGift("RootBox", 0);
            SingleGift truckToy = new SingleGift("TruckToy", 289);
            SingleGift plainToy = new SingleGift("PlainToy", 587);

            rootbox.Add(truckToy);
            rootbox.Add(plainToy);

            CompositeGift childBox = new CompositeGift("CildBox", 0);
            SingleGift soldierToy = new SingleGift("SoldierToy", 200);
            childBox.Add(soldierToy);
            rootbox.Add(childBox);

            Console.WriteLine($"Total price of this composite present is: {rootbox.CalculateTotalPrice()}");
        }
    }
}