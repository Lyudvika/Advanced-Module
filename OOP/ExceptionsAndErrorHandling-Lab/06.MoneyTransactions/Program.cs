namespace MoneyTransactions;

public class Program
{
    private const string EndCommand = "End";
    static void Main(string[] args)
    {
        string[] bankInfo = Console.ReadLine()
            .Split(new char[] {'-', ','}, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<int, double> bankAccount = new Dictionary<int, double>();

        for (int i = 0; i < bankInfo.Length; i+=2)
            bankAccount.Add(int.Parse(bankInfo[i]), double.Parse(bankInfo[i+1]));

        string command;
        while ((command = Console.ReadLine()) != EndCommand)
        {
            string[] cmdArg = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string cmdType = cmdArg[0];

            try
            {
                switch (cmdType)
                {
                    case "Deposit":
                        DepositIntoBankAccount(int.Parse(cmdArg[1]), double.Parse(cmdArg[2]), bankAccount);
                        break;
                    case "Withdraw":
                        WithdrawFromBankAccount(int.Parse(cmdArg[1]), double.Parse(cmdArg[2]), bankAccount);
                        break;
                    default:
                        throw new ArgumentException("Invalid command!");
                }
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Enter another command");
            }
        }
    }

    private static void DepositIntoBankAccount(int accountNumber, double sum, Dictionary<int, double> bankAccount)
    {
        CheckIfKeyIsValid(accountNumber, bankAccount);

        bankAccount[accountNumber] += sum;

        PrintBankAccount(accountNumber, bankAccount);
    }
    private static void WithdrawFromBankAccount(int accountNumber, double sum, Dictionary<int, double> bankAccount)
    {
        CheckIfKeyIsValid(accountNumber, bankAccount);

        if (bankAccount[accountNumber] < sum)
            throw new InvalidOperationException("Insufficient balance!");

        bankAccount[accountNumber] -= sum;

        PrintBankAccount(accountNumber, bankAccount);
    }

    private static void CheckIfKeyIsValid(int accountNumber, Dictionary<int, double> bankAccount)
    {
        if (!bankAccount.ContainsKey(accountNumber))
            throw new KeyNotFoundException("Invalid account!");
    }

    private static void PrintBankAccount(int accountNumber, Dictionary<int, double> bankAccount)
    {
        foreach (var account in bankAccount.Where(k => k.Key == accountNumber))
            Console.WriteLine($"Account {account.Key} has new balance: {account.Value:f2}");
    }
}