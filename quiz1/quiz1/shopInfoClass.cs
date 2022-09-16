public class shopInfo
{
    private int starterMoney = 1000000;
    public string shopName;
    public string shopAddress;

    public void printShopInfo()
    {
        Console.WriteLine("Starter Money: {0}", this.starterMoney);
        Console.WriteLine("Shop Name: {0}", this.shopName);
        Console.WriteLine("Shop Address: {0}", this.shopAddress);
    }
    public void inputShopName()
    {
        Console.Write("Shop Name: ");
        this.shopName = Console.ReadLine();
    }
    public void inputShopAddress()
    {
        Console.Write("Shop address: ");
        this.shopAddress = Console.ReadLine();
    }
}