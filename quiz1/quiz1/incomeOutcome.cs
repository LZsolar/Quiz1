public class IncomeOutcome
{
    public int income;
    public int outcome;

    public void printIncome()
    {
        Console.WriteLine("All shop income = {0}", this.income);
        Console.WriteLine("All shop outcome = {0}", this.outcome);
        Console.WriteLine("Shop Profit = {0}", this.income - this.outcome);
    }
}