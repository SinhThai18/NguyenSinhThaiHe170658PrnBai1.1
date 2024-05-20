using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenSinhThaiHe170658Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            ListEmployee employees = new ListEmployee();

            while (true)
            {
                Console.WriteLine("1. Add FullTimeEmployee");
                Console.WriteLine("2. Add PartTimeEmployee");
                Console.WriteLine("3. Find FullTimeEmployee with Highest Salary");
                Console.WriteLine("4. Find PartTimeEmployee with Highest Salary");
                Console.WriteLine("5. Find Employee by Name");
                Console.WriteLine("6. View All Employees");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        employees.addFullTime();
                        break;
                    case 2:
                        employees.addPartTime();
                        break;
                    case 3:
                        employees.fullTimeHighestSalary();
                        break;
                    case 4:
                        employees.partTimeHighestSalary();
                        break;
                    case 5:
                        employees.FindEmployeeByName();
                        break;
                    case 6:
                        employees.viewListEmployee();
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
    }
   

