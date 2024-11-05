using Indkapsling_C_;

namespace Indkapsling_CSharp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Owner owner = new Owner(123456, "Marius", "Fogelgren");

            Account account = new Account(20.1, 123456, owner);
            Console.WriteLine($"Hej {owner.FullName}, din konto er oprettet.");

            double depositAmount = 1000.0;
            string depositMessage = account.AddBalance(depositAmount);
            Console.WriteLine(depositMessage);

            double withdrawAmount = 500.0;
            string withdrawMessage = account.RemoveBalance(withdrawAmount);
            Console.WriteLine(withdrawMessage);

        }
    }
}