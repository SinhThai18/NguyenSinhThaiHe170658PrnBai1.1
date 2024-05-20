using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenSinhThaiHe170658Bai1
{
    internal class PartTimeEmployee : Employee
    {
        public int workingHours;

        public PartTimeEmployee(string name, int paymentPerHour , 
            int workingHours) : base(name, paymentPerHour)
        {
            this.workingHours = workingHours;
        }

        public override int calculateSalary()
        {
            return paymentPerHour * workingHours;
        }

        public override string ToString()
        {
            return base.ToString() + $",workingHours={workingHours},salary={calculateSalary()}";
        }

    }
}
