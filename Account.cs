using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indkapsling_C_
{
    internal class Owner
    {
        public int KundeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Owner(int kundeID, string firstName, string lastName)
        {
            KundeID = kundeID;
            FirstName = firstName;
            LastName = lastName;
        }

        public string FullName => $"{FirstName} {LastName}";
    }

    internal class Account
    {
        public double Balance { get; private set; }
        public int ID { get; set; }
        public Owner AccountOwner { get; set; }

        public Account(double initialBalance, int id, Owner owner)
        {
            Balance = initialBalance;
            ID = 123456;
            AccountOwner = owner;
        }

        private string UpdateMessege()
        {
            return $"Din konto er blevet opdateret. Der står nu kr. {Balance}.";
        }

        public string AddBalance(double amount)
        {
            Balance += amount;
            return UpdateMessege();
        }

        public string RemoveBalance(double amount)
        {
            Balance -= amount;
            return UpdateMessege();
        }
        private string UpdateMessage()
        {
            return $"Yoru account has been updated. There is now. {Balance:F2}";
        }
    }
}

