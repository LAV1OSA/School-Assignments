class Account
{
    private int _id;
    private double _balance;
    private DateTime _dateCrated;
    private double _anualInterestRate;

    public Account()
    {
        _id = 0;
        _balance = 0;
        _dateCrated = DateTime.Now;
        _anualInterestRate = .05;
    }
    public Account(int id, Person owner, double initialBalace)
    {
        _id = id;
        _balance = initialBalace;
        Owner = owner;
        _dateCrated = DateTime.Now;
        _anualInterestRate = .05;
    }
    public Account(int id, 
                   Person owner, 
                   double initialBalace, 
                   double annualInterestRate) 
                 : this(id, owner, initialBalace)
    {
        _anualInterestRate = annualInterestRate;
    }
    public Person? Owner { get; private set; }
    public int Id { get; private set; }
    public double Balance { get; private set; }
    public DateTime DateCreated { get; private set; }
    public double AnualInterestRate { get => _anualInterestRate ; set => _anualInterestRate = value; }
    public enum AccountType { Savings, Check }
    public AccountType Type { get; set; }

    public void Withdraw(double amount)
    {
        if (amount > _balance)
            throw new InvalidOperationException("You don't have enough money");
        _balance -= amount;
    }
    public void Deposit(double amount)
    {
        if (amount < 0)
            throw new InvalidOperationException("You can't deposit a negative amount");
        _balance += amount;
    }
    public void Transfer(double amount, Account accountFrom, Account accountTo)
    {
        if (amount > accountFrom._balance)
            throw new InvalidOperationException("You don't have enough money");
        else if (amount < 0)
            throw new InvalidOperationException("You can't deposit a negative amount");
        else
        {
            accountFrom._balance -= amount;
            accountTo._balance += amount;
        }
    }
}
public class Person
{
    private string _lastName;
    private string _firstName;
    private DateTime _birthDate;
    private int _age;
    private double _annualIncome;
    public Person(string firstName, string lastName, DateTime birthDate, double annualIncome)
    {
        _firstName = firstName;
        _lastName = lastName;
        BirthDate = birthDate;
        _annualIncome = annualIncome;
    }

    public string LastName { get => _lastName; set => _lastName = value; }
    public string FirstName { get => _firstName; set => _firstName = value; }
    public int Age { get; private set; }
    public DateTime BirthDate 
    { 
        get => _birthDate; 
        
        set
        {
            _birthDate = value;
            Age = (int)((DateTime.Now - _birthDate).Days/(365.25f));
        }
    }
    public double AnnualIncome { get => _annualIncome; set => _annualIncome = value; }
}