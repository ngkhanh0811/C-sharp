using System;
class author
{
    static void Main(string[] args)
    {
        Array objAuthorID = Array.CreateInstance(typeof(int), 3);

        Array objAuthorNames = Array.CreateInstance(typeof(string), 3);
        Array objAddress = Array.CreateInstance(typeof(string), 3);
        Array objState = Array.CreateInstance(typeof(string), 3);

        string input = "";
        int i = 0;
        do
        {
            Console.WriteLine("Enter the ID of author: ");
            input = Console.ReadLine();
            objAuthorID.SetValue(Convert.ToInt32(input), i);
            Console.WriteLine("Enter the name of author: ");
            input = Console.ReadLine();
            objAuthorNames.SetValue((input), i);
            Console.WriteLine("Enter the address of author: ");
            input = Console.ReadLine();
            objAddress.SetValue((input), i);
            Console.WriteLine("Enter the name of state of author: ");
            input = Console.ReadLine();
            objState.SetValue((input), i);
            Console.WriteLine("Enter 0 to exit, 1 to continue.");
            i = Convert.ToInt32(Console.ReadLine());
        } while (i == 1);

        Console.WriteLine("Details of the author:\n ");
        Console.WriteLine("AuthorID \t Name \t\t Address \t\t\t State");
        for (i = 0; i <= objAuthorID.GetUpperBound(0); i++)
        {
            Console.Write(objAuthorID.GetValue(i) + "\t\t");
            Console.Write(objAuthorNames.GetValue(i) + "\t");
            Console.Write(objAddress.GetValue(i) + "\t");
            Console.WriteLine(objState.GetValue(i));
        }

        Array.Sort(objAuthorNames);

        Console.WriteLine("\nAuthor names after sorting: \n");
        for (i = 0; i <= objAuthorID.GetUpperBound(0); i++)
        {
            Console.WriteLine(objAuthorNames.GetValue(i) + "\t");
        }
    }
}