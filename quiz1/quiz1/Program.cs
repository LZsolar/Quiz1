/*
 * ***********************************************
 * 64120501023 พรชนก จรัสไกรสร                     *
 * ***********************************************
*/
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

        Console.WriteLine("***Please input shop Income***");
        IncomeOutcome money = new IncomeOutcome();
        money.income = InputIncome();
        money.outcome = outcome(member);

        while (true)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("Welcome Please select menu:");
            Console.WriteLine("1 for ShopInfo");
            Console.WriteLine("2 for ShopOwnerInfo");
            Console.WriteLine("3 for ShopMemberInfo");
            Console.WriteLine("4 for ShopIncomeOutcome");
            Console.WriteLine("Other for Quit");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("***********************************************");

            if (a == 1) { info.printShopInfo(); }
            else if (a == 2) { printOwnerInfo(owner); }
            else if (a == 3) { printMemberInfo(member); }
            else if (a == 4) { printIncome(money); }
            else { break; }
        }
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

    public static int InputIncome() { 
       
        int inc = 0;
        for(int i = 1; i <= 4; i++)
        {
            Console.Write("Week {0} shop income:", i);
            inc+= 127*int.Parse(Console.ReadLine());
            Console.Write("Week {0} delivery income:", i);
            inc += 357 * int.Parse(Console.ReadLine());
        }
        
        return inc;
    }

    public static int outcome(shopMember[] member)
    {
        int outcome = 0;
        for(int i = 0; i < member.Length; i++)
        {
            outcome += member[i].salary;
        }
        return outcome;
    }

    public static void printIncome(IncomeOutcome inc)
    {
        Console.WriteLine("All shop income = {0}", inc.income);
        Console.WriteLine("All shop outcome = {0}", inc.outcome);
        Console.WriteLine("Shop Profit = {0}", inc.income-inc.outcome);
    }
}