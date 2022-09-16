using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("***Please input shop Infomation***");
        shopInfo info = new shopInfo();
        Console.Write("Starter Money:");
        info.starterMoney = Console.ReadLine();
        Console.Write("Shop Name:");
        info.shopName = Console.ReadLine();
        Console.Write("Shop address:");
        info.shopAddress = Console.ReadLine();

        Console.WriteLine("***Please input shop CO-Owner***");
        Owner[] owner = Inputowner();

        Console.WriteLine("Welcome Please select menu:");
        Console.WriteLine("1 for ShopInfo");
        Console.WriteLine("2 for ShopOwnerInfo");
        Console.WriteLine("3 for ShopMemberInfo");
        int a = int.Parse(Console.ReadLine());
        if (a == 1){printShopInfo(info);}
        else if(a== 2){printOwnerInfo(owner);}

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

        public string PrintOwnerInformation()
        {
            return "Name: " + this.ownerName + "\nSurname: " + this.ownerSurname + "\nID: " + this.ownerID;
            
        }
    }

    public static Owner[] Inputowner()
    {
        Owner[] owners = new Owner[3];

        for (int i = 0; i < owners.Length; i++)
        {
            Console.WriteLine("***Input Owner Number: {0}***", i + 1);

            Owner owner = new Owner();
            Console.Write("Owner name:");
            owner.ownerName = Console.ReadLine();
            Console.Write("Owner surname:");
            owner.ownerSurname = Console.ReadLine();
            Console.Write("Owner ID:");
            owner.ownerID = Console.ReadLine();

            owners[i] = owner;

            Console.WriteLine();
        }

        return owners;
    }
    public static void printOwnerInfo(Owner[] owners)
    {
       for(int i = 0;i < owners.Length; i++)
        {
            Console.WriteLine("***Owner {0} Information***",i);
            Console.WriteLine(owners[i].PrintOwnerInformation());
            Console.WriteLine("***************************");
        }
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