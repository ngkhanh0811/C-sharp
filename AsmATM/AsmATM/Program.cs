using System;

public class ATM
{
    static double surplus1 = 200000;
    static void Login(string username, string password)
    {
        Console.WriteLine("Enter your username: ");
        username = Console.ReadLine();
        Console.WriteLine("Enter your password: ");
        password = Console.ReadLine();
        if(username == "khanh4gi" && password == "123456")
        {
            Console.WriteLine("Login successful!");
        }
        else
        {
            Console.WriteLine("Login failed, recheck your account or password!");
        }
    }

    static void Transfer(double amount1, string id1)
    {
        Console.WriteLine("Enter the account number which you want to transfer money:");
        id1 = Console.ReadLine();
        Console.WriteLine("Enter amount: ");
        amount1 = Convert.ToDouble(Console.ReadLine());

        if (amount1 < surplus1)
        {
            surplus1 -= amount1;
            Console.WriteLine("Successful!");
            Console.WriteLine("The remaining balance is: " + surplus1);
        }
        else
        {
            Console.WriteLine("Insufficient balance, please check again");
        }
    }

    static void Check()
    {
        Console.WriteLine("Current balance: " + surplus1); 
    }

    static void Withdraw(double amount2)
    {
        Console.WriteLine("Enter the amount you want to withdraw: ");
        amount2 = Convert.ToInt32(Console.ReadLine());
        if(amount2 < surplus1)
        {
            Console.WriteLine("Successful!");
            Console.WriteLine("The remaining balance is: {0}", surplus1 -= amount2);
        }
        else
        {
            Console.WriteLine("Insufficient balance, please check again!");
        }
    }

    static void Main(string[] args)
    {
        int select;
        double amount1 = 0;
        string username;
        string password;
        string id1 = "";
        double amount2 = 0;
        Console.WriteLine("Enter your username: ");
        username = Console.ReadLine();
        Console.WriteLine("Enter your password: ");
        password = Console.ReadLine();
        if (username == "khanh4gi" && password == "123456")
        {
            Console.WriteLine("Login successful!");
        do
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Withdraw");
            Console.WriteLine("2. Transfer");
            Console.WriteLine("3. Check");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Please enter options");
            select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:Withdraw(amount2);
                    break;
                case 2: Transfer(amount1, id1);
                    break;
                case 3: Check();
                    break;
                    default: Console.WriteLine("Successful!");
                    break;
            }
        } while (select < 4 && select > 0);
    }
        else
        {
            Console.WriteLine("Login failed, recheck your account or password!");
        }
    }  
}