// Счет в банке представляет собой структуру с полями:
// номер счета, код счета, фамилия владельца, сумма на счете, дата открытия счета, годовой процент начисления.
// Реализовать поиск по номеру счета, по коду счета и по владельцу.

Menu();

void Menu()
{
    var bankAccounts = CreateDbBankAccounts();
    var accounts = bankAccounts.ToArray();
    PrintMenu();
    var input = Console.ReadLine();
    switch (input)
    {
        case "1": PrintAccount(SearchIndexByNumber(accounts), accounts);
            break;
        case "2": PrintAccount(SearchIndexByCode(accounts), accounts);
            break;
        case "3": PrintAccount(SearchIndexByName(accounts), accounts);
            break;
        default: Console.WriteLine("Введите верное значение");
            break;
    }
}

void PrintMenu()
{
    Console.WriteLine("Введите номер пункта меню:");
    Console.WriteLine("1 - поиска по номеру счета");
    Console.WriteLine("2 - Поиск по коду счета");
    Console.WriteLine("3 - поиск по имени владельца счета");
}

void PrintAccount(int index, BankAccount[] accounts)
{
    Console.WriteLine(
        index != -1
            ? $"Данный аккаунт имеет номер счета {accounts[index].Number} с кодом {accounts[index].Code} на имя {accounts[index].LastName}"
            : "Аккаунта с такими данными не существует");
}

int SearchIndexByNumber(IEnumerable<BankAccount> accounts)
{
    Console.WriteLine("Для поиска введите номер счета:");
    var number = int.Parse(Console.ReadLine());
    var index = -1;
    var bankAccounts = accounts.ToArray();
    for (var item = 0; item < bankAccounts.Length; item++)
    {
        if (bankAccounts[item].Number == number)
        {
            index = item;
            break;
        }
    }

    return index;
}

int SearchIndexByCode(IEnumerable<BankAccount> accounts)
{
    Console.WriteLine("Для поиска введите код счета:");
    var code = int.Parse(Console.ReadLine());
    var index = -1;
    var bankAccounts = accounts.ToArray();
    for (var item = 0; item < bankAccounts.Length; item++)
    {
        if (bankAccounts[item].Code == code)
        {
            index = item;
            break;
        }
    }

    return index;
}

int SearchIndexByName(IEnumerable<BankAccount> accounts)
{
    Console.WriteLine("Для поиска введите имя владельца счета с заглавной буквы:");
    var name = Console.ReadLine();
    var index = -1;
    var bankAccounts = accounts.ToArray();
    for (var item = 0; item < bankAccounts.Length; item++)
    {
        if (bankAccounts[item].LastName == name)
        {
            index = item;
            break;
        }
    }

    return index;
}

IEnumerable<BankAccount> CreateDbBankAccounts()
{
    var accounts = new BankAccount[]
    {
        new BankAccount("Kit", 2123, 45654, 333.0, new DateTime(2015, 7, 20), 15 ),
        new BankAccount("Fet", 4564, 43454, 23425.0, new DateTime(2013, 3, 31), 6 ),
        new BankAccount("Tessa", 2563, 453654, 5111.0, new DateTime(2022, 1, 11), 2 ),
        new BankAccount("Kitya", 9948, 456754, 775.0, new DateTime(2021, 5, 22), 22 )
    };
    return accounts;
}

internal class BankAccount
{
    private int _number;
    private int _code;
    private string _lastName;
    private double _amount;
    private DateTime _openingDate;
    private byte _loanInterest;
    
    public int Number => _number;
    public int Code => _code;
    public string LastName => _lastName;

    public BankAccount(string lastName, int code, int number, double amount, DateTime openingDate, byte loanInterest)
    {
        _lastName = lastName;
        _number = number;
        _code = code;
        _amount = amount;
        _openingDate = openingDate;
        _loanInterest = loanInterest;
    }
}