

using System;

namespace HR
{
    public class Employee : Person  //Employee Inherited from Person Class
    {
        //Default Ctor
        public Employee() : base()  //Member initilization list
        {
        }
        //Parameterised Ctor
        public Employee(string fname, string lname, DateTime bdate, int id, string dept,
                                 float bsalary, int dayWorked) : base(fname, lname, bdate)
        {

        }
        //AutoProperty
        public int ID { get; set; }
        public string Department { get; set; }
        public float BasicSalary { get; set; }
        public int WorkingDays { get; set; }

        public virtual float CalculateSalary()
        {
            float salary = BasicSalary + (100 * WorkingDays);
            return salary;
        }

        public override string ToString()
        {
            return base.ToString() + this.ID + " " + this.Department + " " + this.WorkingDays + " " + this.BasicSalary;
        }

    }
}




