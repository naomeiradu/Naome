using System;

namespace Csharp12
{
    class employee
    {
        public int empId;
        public string empName;
        public string empType;
        public employee(int aId, string aName, string aType)
        {
            empId = aId;
            empName = aName;
            empType = aType;
        }
        public double payment()
        {
            if(empType == "M-E")
            {
                double a,b,c;
                int grossSalary=20000;
                a=(grossSalary*18)/100;
                b=grossSalary-a;
                c=b*3/100;
                return (b-c);


            }
            else if(empType == "T-E")
            {
                double d;
                int grossSalary=7000;
                d=grossSalary*18/100;
                return (grossSalary-d);
            } 
            else{
                double e,f,g;
                int grossSalary=9700;
                e=(grossSalary*18/100);
                f=grossSalary-e;
                g=(f*0.15)/100;
                return (g+f); 
            }           
        }
        static void Main(string[] args)
        {
           
           
            employee employee1 = new employee(1, "fils", "M-E");
            employee employee2 = new employee(2, "huss", "M-E");
            employee employee3 = new employee(3, "knox", "T-E");
            employee employee4 = new employee(4, "nelly", "T-E");
            employee employee5 = new employee(5, "janet", "E-E");
            employee employee6 = new employee(6, "belle", "E-E");
            Console.WriteLine(employee4.payment());
            Console.WriteLine("Hello World!");
        }
    }
}
