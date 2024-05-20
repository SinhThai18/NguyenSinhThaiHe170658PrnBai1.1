using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenSinhThaiHe170658Bai1
{
    internal class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, int paymentPerHour) : base(name, paymentPerHour)
        {
        }

        public override int calculateSalary()
        {
            return paymentPerHour * 8;
        }

        public override string ToString()
        {
            return base.ToString() + $",salary={calculateSalary()}";
        }
    }
}
