namespace CargoTransportationSystem
{
    public abstract class Client
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public Client(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
    }

    public class IndividualClient : Client
    {
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public string PassportDate { get; set; }
        public string PassportIssuedBy { get; set; }

        public IndividualClient(string name, string phone, string passportSeries, string passportNumber, string passportDate, string passportIssuedBy)
            : base(name, phone)
        {
            PassportSeries = passportSeries;
            PassportNumber = passportNumber;
            PassportDate = passportDate;
            PassportIssuedBy = passportIssuedBy;
        }
    }

    public class CorporateClient : Client
    {
        public string DirectorName { get; set; }
        public string LegalAddress { get; set; }
        public string BankName { get; set; }
        public string BankAccount { get; set; }
        public string Inn { get; set; }

        public CorporateClient(string name, string phone, string directorName, string legalAddress, string bankName, string bankAccount, string inn)
            : base(name, phone)
        {
            DirectorName = directorName;
            LegalAddress = legalAddress;
            BankName = bankName;
            BankAccount = bankAccount;
            Inn = inn;
        }
    }
}
