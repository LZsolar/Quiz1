public class shopMember
{
    public string name;
    public string surname;
    public string age;
    public int salary;
    bool isDelivery;

    public void inputType()
    {
        Console.Write("Position for member 1 for Shopkeeper 2 for Delively: ");
        int a = int.Parse(Console.ReadLine());
        if (a == 1) { this.isDelivery = false; this.salary = 15000; }
        else { this.isDelivery = true; this.salary = 12500; }
    }
    public void inputMemberName()
    {
        Console.Write("Name: ");
        this.name = Console.ReadLine();
    }
    public void inputMemberSurname()
    {
        Console.Write("Surname: ");
        this.surname = Console.ReadLine();
    }
    public void inputMemberAge()
    {
        Console.Write("Age: ");
        this.age = Console.ReadLine();
    }
    public void PrintMemberInformation()
    {
        if (!this.isDelivery) {
            Console.WriteLine("Position: ShopKeeper");
        }
        else
        {
            Console.WriteLine("Position: Delivery");
        }
        
        Console.WriteLine("Name: {0}", this.name);
        Console.WriteLine("Surname: {0}", this.surname);
        Console.WriteLine("Age: {0}", this.age);
        Console.WriteLine("Salary: {0}", this.salary);
    }
}