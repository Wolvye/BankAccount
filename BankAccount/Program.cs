using System.Threading.Channels;

namespace BankAccount
{
    internal class Program
    {
        private static void Main(string[] args)
        {
          //Uebung: Bankaccount erstellen.
          
            BankAccount account = new BankAccount("123-456", "John Doe", 1000);
            {
                while (true)
                {
                    Console.WriteLine("Bitte wählen Sie eine Aktion aus");
                    Console.WriteLine("1. Kontostand anzeigen");
                    Console.WriteLine("2. Einzahlung tätigen");
                    Console.WriteLine("3. Auszahlung");
                    Console.WriteLine("4. Beenden");

                    string input = Console.ReadLine();
                    if (input == "1")
                    {
                        account.PrintBalance();
                    }
                    else if (input == "2")
                    {
                        Console.WriteLine("Gib den Betrg ein, den du einzahlen willst: ");
                        float depositAmount = float.Parse(Console.ReadLine());
                        account.MakeDeposit(depositAmount);
                    }
                    else if (input == "3")
                    {
                        Console.WriteLine("Gib den Betrg ein, den du abheben willst: ");
                        float withDrawAmount = float.Parse(Console.ReadLine());
                        account.MakeWithdrawal(withDrawAmount);
                    }
                    else if (input == "4")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe");
                    }
                }
            }
        }
    }
}