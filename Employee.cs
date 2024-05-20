using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NguyenSinhThaiHe170658Bai1
{
    internal abstract class Employee : IEmployee
    {
        public String name;
        public int paymentPerHour;

        protected Employee(string name, int paymentPerHour)
        {
            this.name = name;
            this.paymentPerHour = paymentPerHour;
        }

        public abstract int calculateSalary();


        public string getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setPaymentPerHour(int paymentPerHours)
        {
            this.paymentPerHour = paymentPerHours;
        }

        public override String ToString()
        {
            return $"Name: {name}, Payment Per Hour: {paymentPerHour}";
        }
    }
}
