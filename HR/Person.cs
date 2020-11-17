
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    public class Person
    {
        //User defined structure Type
        public struct Point
        {
            public int x;
            public int y;

        }
        //Default Ctor----if nothing is given use default values
        public Person()
        {
            this.FirstName = "";
            this.LastName = "";
            this.Birthdate = DateTime.Now; //as inbuilt function
        }
        //Parameterised Ctor
        public Person(string fname, string lname, DateTime bdate)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Birthdate = bdate;
        }

        //AutoProperty
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected DateTime Birthdate { get; set; }  //DateTime is readymade Structure available in C#

        //Overloading ToString function
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Birthdate;
        }
    }
}
