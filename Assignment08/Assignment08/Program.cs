using System;
namespace Assignment08
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            char choice;
            do
            {
                Console.WriteLine("\nEnter your choice\n1. Employees Table\n2. Products Table\n3. Orders Table");
                int option = int.Parse(Console.ReadLine());
                int opt;
                Employees emp = new Employees();
                Products prod = new Products();
                Orders ord = new Orders();
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nEmployee Table");
                        Console.WriteLine("1. Read\n2. Insert\n3. Update\n4. Delete");
                        opt = int.Parse(Console.ReadLine());
                        switch (opt)
                        {
                            case 1:
                                emp.Read();
                                break;
                            case 2:
                                emp.Insert();
                                break;
                            case 3:
                                emp.Update();
                                break;
                            case 4:
                                emp.Delete();
                                break;
                            default:
                                Console.WriteLine("Try Again!!!");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nProducts Table");
                        Console.WriteLine("1. Read\n2. Insert\n3. Update\n4. Delete");
                        opt = int.Parse(Console.ReadLine());
                        switch (opt)
                        {
                            case 1:
                                prod.Read();
                                break;
                            case 2:
                                prod.Insert();
                                break;
                            case 3:
                                prod.Update();
                                break;
                            case 4:
                                prod.Delete();
                                break;
                            default:
                                Console.WriteLine("Try Again!!!");
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nOrders Table");
                        Console.WriteLine("1. Read\n2. Insert\n3. Update\n4. Delete");
                        opt = int.Parse(Console.ReadLine());
                        switch (opt)
                        {
                            case 1:
                                ord.Read();
                                break;
                            case 2:
                                ord.Insert();
                                break;
                            case 3:
                                ord.Update();
                                break;
                            case 4:
                                ord.Delete();
                                break;
                            default:
                                Console.WriteLine("Try Again!!!");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Try Again!!!");
                        break;
                }
                Console.WriteLine("\nDo you wish to continue.If yes press 'y' or press any key");
                choice = char.Parse(Console.ReadLine().ToLower());
            } while (choice == 'y');

        }

    }
}