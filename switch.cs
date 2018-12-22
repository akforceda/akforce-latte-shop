using System;
class Coffee
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Akshay's Latteria ");
        int TotalBill = 0;

    start:

        Console.WriteLine("***********Menu**********");
        Console.WriteLine("1 ----Tea----10rs");
        Console.WriteLine("2 ----Coffee----25rs");
        Console.WriteLine("3 ----Cappuccino-----60rs");
        Console.WriteLine("4 ----Bournvita----15rs");
        Console.WriteLine("Please enter your choice");

        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                TotalBill += 10;
                break;

            case 2:
                TotalBill += 25;
                break;

            case 3:
                TotalBill += 60;
                break;

            case 4:
                TotalBill += 15;
                break;

            default:
                Console.WriteLine("Invalid selection");
                break;
        }

    start1:

        Console.WriteLine("Do you want to buy more? YES or No?");
        string decision = Console.ReadLine();

        switch (decision.ToUpper())
        {
            case "YES": goto start;
            case "NO":
                Console.WriteLine("Printing you bill");
                break;

            default:
                Console.WriteLine("Invalid selection");
                goto start1;
        }
        Console.WriteLine("Here is your bill");
        Console.WriteLine("Total Amount payable is {0} rs", TotalBill);
        Console.WriteLine("Thankyou :-)");
    }
}