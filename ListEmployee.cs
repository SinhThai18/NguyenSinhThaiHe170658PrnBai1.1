using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenSinhThaiHe170658Bai1
{
    internal class ListEmployee
    {
        List<Employee> employees = new List<Employee>();
        // list employee co ca parttime va fulltime

        public void addPartTime()
        {
            Boolean inputValid = false;
            Console.Write("Enter name: ");
            String name = Console.ReadLine();
            int workingHours = 0;
            int paymentPerHours = 0;

            // nhap chu hoac so am se day den exception va cho phep nhap lai
            while (!inputValid)
            {
                try
                {
                    Console.WriteLine("Enter working hours: ");
                    workingHours = int.Parse(Console.ReadLine());
                    if(workingHours < 0)
                    {
                        throw new FormatException();
                    }
                    inputValid = true;
                }
                catch(FormatException)
                {
                    Console.Write("Input error.Enter again: ");
                }
            }

            inputValid = false;

            while (!inputValid)
            {
                try
                {
                    Console.WriteLine("Enter payment per hours: ");
                    paymentPerHours = int.Parse(Console.ReadLine());
                    if (paymentPerHours < 0)
                    {
                        throw new FormatException();
                    }
                    inputValid = true;
                }
                catch (FormatException)
                {
                    Console.Write("Input error.Enter again: ");
                }
            }
            employees.Add(new PartTimeEmployee(name, paymentPerHours, workingHours));
        }

        public void addFullTime()
        {
            Boolean inputValid = false;
            Console.Write("Enter name: ");
            String name = Console.ReadLine();
            int paymentPerHours = 0;

            // nhap chu hoac so am se day den exception va cho phep nhap lai

            while (!inputValid)
            {
                try
                {
                    Console.WriteLine("Enter payment per hours: ");
                    paymentPerHours = int.Parse(Console.ReadLine());
                    if (paymentPerHours < 0)
                    {
                        throw new FormatException();
                    }
                    inputValid = true;
                }
                catch (FormatException)
                {
                    Console.Write("Input error.Enter again: ");
                }
            }
            employees.Add(new FullTimeEmployee(name, paymentPerHours));
        }

        public void viewListEmployee()
        {
            if(employees.Count == 0)
            {
                Console.WriteLine("null ");
                return;
            }
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        //tim nhan vien luong cao nhat 
        //b1 kiem tra la loai nhan vien nao
        //b2 duyet list employee loai nhan vien do va gan emplyee co salary lon nhat cho highestSalaryEmployee
        public void partTimeHighestSalary()
        {
            PartTimeEmployee highestSalaryEmployee = null;
            foreach (var employee in employees)
            {
                if(employee is PartTimeEmployee ptEmployee)
                {
                    if(highestSalaryEmployee==null || 
                        ptEmployee.calculateSalary() > highestSalaryEmployee.calculateSalary())
                    {
                        highestSalaryEmployee = ptEmployee;
                        
                    }
                }
            }
            Console.WriteLine(highestSalaryEmployee);
        }

        public void fullTimeHighestSalary()
        {
            FullTimeEmployee highestSalaryEmployee = null;
            foreach (var employee in employees)
            {
                if (employee is FullTimeEmployee ftEmployee)
                {
                    if (highestSalaryEmployee == null ||
                        ftEmployee.calculateSalary() > highestSalaryEmployee.calculateSalary())
                    {
                        highestSalaryEmployee = ftEmployee;
                        
                    }
                }
            }
            Console.WriteLine(highestSalaryEmployee);
        }

        public void FindEmployeeByName()
        {
            Console.WriteLine("Enter name:");
            String name = Console.ReadLine();

            //so sanh ten khong phan biet chu hoa chu thuong
            foreach(var employee in employees)
            {
                if (employee.name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(employee);
                }
            }
        }


    }
}
