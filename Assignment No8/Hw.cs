using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_No8
{
    public class Employee2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }
        public float DA { get; set; }
        public float HRA { get; set; }
        public float Pf { get; set; }
        public float gross { get; set; }

        public void Calculation()
        {
            if (salary >= 20000 && salary <= 30000)
            {
                DA = (salary * 20) / 100;
                HRA = (salary * 40) / 100;
                Pf = (salary * 12) / 100;
                gross = salary + DA + HRA + Pf;

                //return ($"{Id} {Name} {DA} {HRA} {Pf} {Gross}");
            }
            else if (salary >= 10000 && salary <= 20000)
            {
                DA = (salary * 45) / 100;
                HRA = (salary * 25) / 100;
                Pf = (salary * 12) / 100;
                gross = salary + DA + HRA + Pf;
            }
            else if (salary < 10000)
            {
                gross = salary - 200;
            }
        }
        public override string ToString()
        {
            return $" {Id} {Name} {HRA} {DA} {Pf} {gross}";
        }

    }
}
