using System;
using System.Linq;
namespace Assignment08
{
    public class Products
    {
        static Assignment8DbEntities db;
        public void Read()
        {
            try
            {
                db = new Assignment8DbEntities();
                foreach (Product pro in db.Products)
                {
                    Console.WriteLine("ID: " + pro.ProductId);
                    Console.WriteLine("Product Name: " + pro.ProductName);
                    Console.WriteLine("Description: " + pro.Description);
                    Console.WriteLine("Price: " + pro.Price);
                    Console.WriteLine("Release Date: " + pro.ReleaseDate);
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
                Product Product = new Product();

                Console.WriteLine("Enter ID: ");
                Product.ProductId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Product Name: ");
                Product.ProductName = Console.ReadLine();
                Console.WriteLine("Enter Product Description: ");
                Product.Description = Console.ReadLine();
                Console.WriteLine("Enter Product Price: ");
                Product.Price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter Product Release date: ");
                Product.ReleaseDate = DateTime.Parse(Console.ReadLine());

                db.Products.Add(Product);
                db.SaveChanges();

                Console.WriteLine("Product Record Inserted!!!!");

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
                Product Product = new Product();

                Console.Write("Enter ID to Update the details: ");
                int id = int.Parse(Console.ReadLine());
                Product = db.Products.SingleOrDefault(e => e.ProductId == id);

                if (Product == null)
                {
                    Console.WriteLine($"No such ID {id} exist in Assignment8Db");
                }
                else
                {
                    Console.WriteLine("Enter Product Name: ");
                    Product.ProductName = Console.ReadLine();
                    Console.WriteLine("Enter Product Description: ");
                    Product.Description = Console.ReadLine();
                    Console.WriteLine("Enter Product Price: ");
                    Product.Price = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Product Release date: ");
                    Product.ReleaseDate = DateTime.Parse(Console.ReadLine());

                    db.SaveChanges();

                    Console.WriteLine("Product Record Updated!!!!");

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
                Product Product = new Product();

                Console.Write("Enter ID to Update the details: ");
                int id = int.Parse(Console.ReadLine());
                Product = db.Products.SingleOrDefault(e => e.ProductId == id);

                if (Product == null)
                {
                    Console.WriteLine($"No such ID {id} exist in Assignment8Db");
                }
                else
                {
                    db.Products.Remove(Product);
                    db.SaveChanges();

                    Console.WriteLine("Product Record Deleted!!!!");

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
    

