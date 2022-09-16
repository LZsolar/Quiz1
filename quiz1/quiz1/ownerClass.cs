public class Owner
{
    public string ownerName;
    public string ownerSurname;
    public string ownerID;

    public void inputOwnerName()
    {
        Console.Write("Name: ");
        this.ownerName = Console.ReadLine(); 
    }
    public void inputOwnerSurname()
    {
        Console.Write("Surname: ");
        this.ownerSurname = Console.ReadLine();
    }
    public void inputOwnerID()
    {
        Console.Write("ID: ");
        this.ownerID = Console.ReadLine();
    }
    public string PrintOwnerInformation()
    {
        return "Name: " + this.ownerName + "\nSurname: " + this.ownerSurname + "\nID: " + this.ownerID;

    }
}

