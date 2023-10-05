namespace StocksApp.Models
{
    public class Account
    {
        private int id { get; set; }
        private int AccountNumber { get; set; }
        private float InitialBalance;
        private float CurrentBalance;


        public Account()
        {
            InitialBalance = 0;
            CurrentBalance = InitialBalance;
        }

        public void creditAccount(float amount)
        {
            CurrentBalance += amount;
        }

        public void debitAccount(float amount)
        {
            CurrentBalance -= amount;
        }

        public void WithdrawBalance()
        {
            CurrentBalance -= CurrentBalance;
        }

    }
}
