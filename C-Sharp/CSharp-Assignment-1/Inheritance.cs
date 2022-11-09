namespace C_Sharp
{
    class Bank
    {
        public String Name = "Union Bank";
        public String City = "Pune";

        public int bankid;
        public int citycode;


        public Bank()
        {
            bankid = 101;
            citycode = 063;
        }


        public void Display()
        {
            Console.WriteLine("Bank name = {0}", Name);
            Console.WriteLine("City name = {0}", City);
        }

        public void Run()
        {
            int P = 20000, R = 8, T = 1;
            int SI;
            String FirstName = "Ajinkya";
            String LastName = "Sonawane";
            String city = "Dhule";

            Customer customer = new Customer();
            customer.Display();
            customer.Savings();
            customer.Current();
            customer.Details(FirstName, LastName);
            customer.Details(FirstName, LastName, city);
            SI = customer.Intrest(P, R, T);
            Console.WriteLine("Simple Intrest = {0}", SI);
            Console.WriteLine("Bankid = {0}", customer.bankid);
            Console.WriteLine("Cityid = {0}", customer.citycode);
        }

        
    }

    class Account : Bank
    {
        public int[] AccountNumber = { 1111, 2222, 3333, 4444, 5555 };
        public int[] BalanceSaving = { 20000, 10000, 5000, 7000, 4000 };
        public int[] BalanceCurrent = { 200, 8000, 100, 2000, 3000 };

        public void Savings()
        {
            Console.WriteLine("Balance Details(Savings) :");
            for (int i = 0; i < AccountNumber.Length; i++)
            {
                Console.WriteLine("Account number {0} have {1} balance.", AccountNumber[i], BalanceSaving[i]);
            }
        }

        public void Current()
        {
            Console.WriteLine("Balance Details(Current) :");
            for (int i = 0; i < AccountNumber.Length; i++)
            {
                Console.WriteLine("Account number {0} have {1} balance.", AccountNumber[i], BalanceCurrent[i]);
            }
        }
    }

    class Customer : Account
    {
        public int[] CustomerId = { 112, 234, 545, 234, 33 };





        public int Intrest(int P, int R, int T)
        {
            return (P * R * T) / 100;

        }

        public void Display()
        {
            Console.WriteLine("Customers Details :");
            for (int i = 0; i < CustomerId.Length; i++)
            {
                Console.WriteLine("CustomerID {0} have AccountNumber {1} .", CustomerId[i], AccountNumber[i]);
            }
        }

        public void Details(String FirstName, String LastName)
        {
            Console.WriteLine("First Name {0} Last Name {1}", FirstName, LastName);
        }

        public void Details(String FirstName, String LastName, String city)
        {
            Console.WriteLine("First Name = {0} Last Name = {1}  City = {2}", FirstName, LastName, city);
        }


    }


}
