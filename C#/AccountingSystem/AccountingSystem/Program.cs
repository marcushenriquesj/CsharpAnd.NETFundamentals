namespace AccoutingSystem
{
    public class prgoram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Accounting System 1.0 \nPlease write your first name:");
            string Username = Console.ReadLine();
            Console.WriteLine("What is your last name {0}", Username);
            string LastName = Console.ReadLine();

            Checking checking = new Checking(0, 100);
            Premium premium = new Premium(0, 200);

            checking.PrintInfo();
            premium.PrintInfo();

            checking.Deposit(2000);
            premium.Deposit(6000);

            checking.PrintInfo();
            premium.PrintInfo();

            premium.Transfer(checking, 2000);

            checking.PrintInfo();
            premium.PrintInfo();

            decimal checkingInterest = checking.CalculateInterest(.03m);
            decimal premiumInterest = premium.CalculateInterest(.03m);

            Console.WriteLine($"Checking interest: {checkingInterest}");
            Console.WriteLine($"Premium interest: {premiumInterest}");

            checking.Deposit(checkingInterest);
            premium.Deposit(premiumInterest);

            checking.PrintInfo();
            premium.PrintInfo();

        }
    }

    public class Account
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }

        public Account(decimal startingBalance, int id)
        {
            Balance = startingBalance;
            Id = id;
        }

        public void Deposit(decimal ammount)
        {
            Balance += ammount;
        }

        public virtual decimal CalculateInterest(decimal interest)
        {
            return Balance * interest;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Checking account {Id}: Balance {Balance}");
        }

       
    }

    public class Premium : Account
    {
        public Premium(decimal startingBalance, int id) : base(startingBalance, id)
        {
        }

        public override decimal CalculateInterest(decimal interest)
        {
            return Balance * (interest + 0.01m);
        }

        public void Transfer(Checking c, decimal ammount)
        {
            this.Balance -= ammount;
            c.Deposit(ammount);
        }
    }

    public class Checking : Account
    {
        public Checking(decimal startingBalance, int id) : base(startingBalance, id)
        {
        }

        public override decimal CalculateInterest(decimal interest)
        {
            return Balance * interest;
        }

        public void Transfer(Premium p, decimal ammount)
        {
            this.Balance -= ammount;
            p.Deposit(ammount);
        }
    }
}
