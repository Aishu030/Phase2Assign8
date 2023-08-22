using System;
using System.Linq;
namespace Assignment08
{
    public class Orders
    {
        static Assignment8DbEntities db;
        public void Read()
        {
            try
            {
                db = new Assignment8DbEntities();
                foreach (Order or in db.Orders)
                {
                    Console.WriteLine("Order ID: " + or.OrderId);
                    Console.WriteLine("Order Date: " + or.OrderDate);
                    Console.WriteLine("Quantity: " + or.Quantity);
                    Console.WriteLine("Discount: " + or.Discount);
                    Console.WriteLine("Shipped : " + or.IsShipped);
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!! " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        public void Insert()
        {
            try
            {
                db = new Assignment8DbEntities();
                Order Order = new Order();

                Console.WriteLine("Enter ID: ");
                Order.OrderId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Order Date: ");
                Order.OrderDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter Order Quantity: ");
                Order.Quantity = short.Parse(Console.ReadLine());
                Console.WriteLine("Enter Order Discount: ");
                Order.Discount = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Order is Shipped or Not: ");
                Order.IsShipped = bool.Parse(Console.ReadLine());

                db.Orders.Add(Order);
                db.SaveChanges();

                Console.WriteLine("Order Record Inserted");

            }
            catch (Exception ex)
            {   
                Console.WriteLine("Error!!! " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        public void Update()
        {
            try
            {
                db = new Assignment8DbEntities();
                Order Order = new Order();

                Console.Write("Enter ID to Update the details: ");
                int id = int.Parse(Console.ReadLine());
                Order = db.Orders.SingleOrDefault(e => e.OrderId == id);

                if (Order == null)
                {
                    Console.WriteLine($"No such ID {id} exist in Assignment8Db");
                }
                else
                {
                    Console.WriteLine("Enter Order Date: ");
                    Order.OrderDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Order Quantity: ");
                    Order.Quantity = short.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Order Discount: ");
                    Order.Discount = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Order is Shipped or Not: ");
                    Order.IsShipped = bool.Parse(Console.ReadLine());

                    db.SaveChanges();

                    Console.WriteLine("Order Record Updated");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!! " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }

        }

        public void Delete()
        {
            try
            {
                db = new Assignment8DbEntities();
                Order Order = new Order();

                Console.Write("Enter ID to Update the details: ");
                int id = int.Parse(Console.ReadLine());
                Order = db.Orders.SingleOrDefault(e => e.OrderId == id);

                if (Order == null)
                {
                    Console.WriteLine($"No such ID {id} exist in Assignment8Db");
                }
                else
                {
                    db.Orders.Remove(Order);
                    db.SaveChanges();

                    Console.WriteLine("Order Record Deleted!!!");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!! " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
    
