using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please input shop Infomation");
        shopInfo info = new shopInfo();
        Console.Write("Starter Money:");
        info.starterMoney = Console.ReadLine();
        Console.Write("Shop Name:");
        info.shopName = Console.ReadLine();
        Console.Write("Shop address:");
        info.shopAddress = Console.ReadLine();




        Console.WriteLine("Welcome Please select menu:");
        Console.WriteLine("1 for ShopInfo");
        Console.WriteLine("2 for ShopOwnerInfo");
        Console.WriteLine("3 for ShopMemberInfo");
        int a = int.Parse(Console.ReadLine());
        if (a == 1)
        {
            printShopInfo(info);
        }

    }


    public class shopInfo
    {
        public string starterMoney;
        public string shopName;
        public string shopAddress;
    }

    public static void printShopInfo(shopInfo shop){
        Console.WriteLine("Starter Money: {0}",shop.starterMoney);
        Console.WriteLine("Shop Name: {0}", shop.shopName);
        Console.WriteLine("Shop Address: {0}", shop.shopAddress);
    }

    public class Owner
    {
        public string ownerName;
        public string ownerSurname;
        public string ownerID;
    }
    
    public class shopMember
    {
        public string name;
        public string surname;
        public int age;
        public int salary;
        bool workMoney;
        bool deliveryMoney;
    }
}