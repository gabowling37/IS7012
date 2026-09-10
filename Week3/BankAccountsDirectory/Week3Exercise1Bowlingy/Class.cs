namespace Week3Exercise1Bowlingy
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public DateTime CreatedDate { get; set; }
        public int AccountHolderId { get; set; }
	    public AccountHolder AccountHolder { get; set; }
    }

    public class AccountHolder
    {
        public int AccountHolderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<BankAccount> BankAccounts { get; set; }
    }
}
