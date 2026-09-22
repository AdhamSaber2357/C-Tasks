using System;

namespace DEPI
{
    class Program
    {

        static void ModifyPoint(Point p)
        {
            p.X = 99;
        }

        static void ModifyPointRef(ref Point p)
        {
            p.X = 99;
        }

        static void ModifyEmployee(EmployeeClass e)
        {
            e.Name = "Robert";
        }

        static void ReplaceEmployee(EmployeeClass e)
        {
            e = new EmployeeClass { Name = "Replaced", Id = 999 };
        }



        static void Main(string[] args)
        {
            #region Problem1 - Point struct with constructors and ToString
            var pDefault = new Point(); // implicit default
            var p1 = new Point(5); // X=5, Y=0
            var p2 = new Point(3, 4);
            Console.WriteLine("Problem1 outputs:");
            Console.WriteLine(pDefault); // (0, 0)
            Console.WriteLine(p1); // (5, 0)
            Console.WriteLine(p2); // (3, 4)
            #endregion

            #region Problem2 - TypeA access modifiers demonstration
            var a = new TypeA();
            Console.WriteLine("\nProblem2 outputs:");
            Console.WriteLine($"H (public) = {a.H}");
            Console.WriteLine($"G (internal) = {a.G}");
            Console.WriteLine($"F (private via GetF()) = {a.GetF()}");
            #endregion

            #region Problem3 - EmployeeStruct encapsulation
            var emp = new EmployeeStruct(101, "Alice", 5000m);
            Console.WriteLine("\nProblem3 outputs:");
            Console.WriteLine(emp);
            emp.SetName("Alicia");
            Console.WriteLine($"Name after SetName: {emp.GetName()}");
            emp.Salary = 5500m; // using property
            Console.WriteLine($"Salary after update: {emp.Salary}");
            #endregion

            #region Problem4 & Problem5 - Point constructor overloading and ToString formatting
            var pA = new Point(10); // X=10, Y=0
            var pB = new Point(7, 8);
            Console.WriteLine("\nProblem4/5 outputs:");
            Console.WriteLine(pA.ToString());
            Console.WriteLine(pB.ToString());
            #endregion

            #region Problem6 - Value type vs Reference type behavior
            var ps = new Point(1, 2);
            var clsEmp = new EmployeeClass { Name = "Bob", Id = 200 };

            Console.WriteLine("\nProblem6 outputs:");
            Console.WriteLine($"Before ModifyPoint: {ps}");
            ModifyPoint(ps);
            Console.WriteLine($"After ModifyPoint (struct passed by value): {ps}");

            Console.WriteLine($"Before ModifyPointRef: {ps}");
            ModifyPointRef(ref ps);
            Console.WriteLine($"After ModifyPointRef (struct passed by ref): {ps}");

            Console.WriteLine($"Before ModifyEmployee: {clsEmp}");
            ModifyEmployee(clsEmp);
            Console.WriteLine($"After ModifyEmployee (class - property changed): {clsEmp}");

            Console.WriteLine($"Before ReplaceEmployee: {clsEmp}");
            ReplaceEmployee(clsEmp);
            Console.WriteLine($"After ReplaceEmployee (class reference reassigned inside method): {clsEmp}");
            #endregion
        }

      
    }

    


   

}
