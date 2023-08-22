using System;
using System.Linq;
namespace Assignment08
{
    public class Employees
    {
        static Assignment8DbEntities db;
        public void Read()
        {
            try
            {
                db = new Assignment8DbEntities();
                foreach (Employee e in db.Employees)
                {
                    Console.WriteLine("ID: " + e.EmployeeId);
                    Console.WriteLine("First Name: " + e.FirstName);
                    Console.WriteLine("Last Name: " + e.LastName);
                    Console.WriteLine("Date of Birth: " + e.BirthDate);
                    Console.WriteLine("Salary: " + e.Salary);
                    Console.WriteLine("");
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
                Employee Employee = new Employee();

                Console.WriteLine("Enter ID: ");
                Employee.EmployeeId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter First Name: ");
                Employee.FirstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name: ");
                Employee.LastName = Console.ReadLine();
                Console.WriteLine("Enter Date of Birth: ");
                Employee.BirthDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter Salary: ");
                Employee.Salary = decimal.Parse(Console.ReadLine());

                db.Employees.Add(Employee);
                db.SaveChanges();

                Console.WriteLine("Employee Record Inserted!!!!");

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
                Employee Employee = new Employee();

                Console.Write("Enter ID to Update the details: ");
                int id = int.Parse(Console.ReadLine());
                Employee = db.Employees.SingleOrDefault(e => e.EmployeeId == id);

                if (Employee == null)
                {
                    Console.WriteLine($"No such ID {id} exist in Assignment8Db");
                }
                else
                {
                    Console.WriteLine("Enter New First Name: ");
                    Employee.FirstName = Console.ReadLine();
                    Console.WriteLine("Enter New Last Name: ");
                    Employee.LastName = Console.ReadLine();
                    Console.WriteLine("Enter New Date of Birth: ");
                    Employee.BirthDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter New Salary: ");
                    Employee.Salary = decimal.Parse(Console.ReadLine());

                    db.SaveChanges();

                    Console.WriteLine("Employee Record Updated!!!!");

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
                Employee Employee = new Employee();

                Console.Write("Enter ID to Update the details: ");
                int id = int.Parse(Console.ReadLine());
                Employee = db.Employees.SingleOrDefault(e => e.EmployeeId == id);

                if (Employee == null)
                {
                    Console.WriteLine($"No such ID {id} exist in Assignment8Db");
                }
                else
                {
                    db.Employees.Remove(Employee);
                    db.SaveChanges();

                    Console.WriteLine("Employee Record Deleted!!!");

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
    

