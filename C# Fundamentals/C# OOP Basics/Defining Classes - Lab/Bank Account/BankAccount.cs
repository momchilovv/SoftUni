public class BankAccount
{
    public int Id { get; set; }
    public decimal Balance { get; set; }

    public void Deposit(decimal ammount)
    {
        this.Balance += ammount;
    }
    public void Withdraw(decimal ammount)
    {
        this.Balance -= ammount;
    }
    public override string ToString()
    {
        return $"Account ID{this.Id}, balance {this.Balance:f2}";
    }
}