using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("***Please input shop Infomation***");
        shopInfo info = new shopInfo();
        info.inputShopName();   
        info.inputShopAddress();

        Console.WriteLine("***Please input shop CO-Owner***");
        Owner[] owner = Inputowner();

        Console.WriteLine("***Please input shop Member***");
        shopMember[] member = InputMember();

        Console.WriteLine("Welcome Please select menu:");
        Console.WriteLine("1 for ShopInfo");
        Console.WriteLine("2 for ShopOwnerInfo");
        Console.WriteLine("3 for ShopMemberInfo");
        int a = int.Parse(Console.ReadLine());
        if (a == 1){info.printShopInfo();}
        else if(a== 2){printOwnerInfo(owner);}
        else if(a==3){printMemberInfo(member);}

    }
    public static Owner[] Inputowner()
    {
        Owner[] owners = new Owner[3];

        for (int i = 0; i < owners.Length; i++)
        {
            Console.WriteLine("***Input Owner Number: {0}***", i + 1);

            Owner owner = new Owner();
            owner.inputOwnerName();
            owner.inputOwnerSurname();
            owner.inputOwnerID();
            owners[i] = owner;

            Console.WriteLine();
        }

        return owners;
    }
    public static void printOwnerInfo(Owner[] owners)
    {
       for(int i = 0;i < owners.Length; i++)
        {
            Console.WriteLine("***Owner {0} Information***",i+1);
            Console.WriteLine(owners[i].PrintOwnerInformation());
            Console.WriteLine("***************************");
        }
    }

    public static shopMember[] InputMember()
    {
        shopMember[] members = new shopMember[5];

        for (int i = 0; i < members.Length; i++)
        {
            Console.WriteLine("***Input Member Number: {0}***", i + 1);

            shopMember member = new shopMember();
            member.inputType();
            member.inputMemberName();
            member.inputMemberSurname();
            member.inputMemberAge();
            members[i] = member;

            Console.WriteLine();
        }

        return members;
    }

    public static void printMemberInfo(shopMember[] members)
    {
        for (int i = 0; i < members.Length; i++)
        {
            Console.WriteLine("***Member {0} Information***", i + 1);
            members[i].PrintMemberInformation();
            Console.WriteLine("***************************");
        }
    }
}