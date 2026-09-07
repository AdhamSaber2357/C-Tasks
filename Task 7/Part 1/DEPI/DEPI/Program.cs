using System;

namespace DEPI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Problem - Car class with multiple constructors
            Console.WriteLine("Problem: Car constructors");
            var cDefault = new Car();
            var c1 = new Car(1);
            var c2 = new Car(2, "Toyota");
            var c3 = new Car(3, "Honda", 25000m);
            Console.WriteLine(cDefault);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            #endregion

            #region Problem - Calculator overloaded Sum methods
            Console.WriteLine("\nProblem: Calculator overloads");
            var calc = new Calculator();
            Console.WriteLine($"Sum(2,3) = {calc.Sum(2,3)}");
            Console.WriteLine($"Sum(1,2,3) = {calc.Sum(1,2,3)}");
            Console.WriteLine($"Sum(1.5,2.25) = {calc.Sum(1.5,2.25)}");
            #endregion

            #region Problem - Parent and Child constructor chaining + Product new vs override
            Console.WriteLine("\nProblem: Inheritance, constructor chaining, new vs override, ToString");
            var childOverride = new ChildOverride(3, 4, 5);
            var childNew = new ChildNew(3, 4, 6);

            Console.WriteLine($"Parent part product (base call) = {childOverride.Product()}");
            // Call via base reference to childOverride
            Parent baseRef = childOverride;
            Console.WriteLine($"Called via Parent reference (override): {baseRef.Product()}");

            Parent baseRefNew = childNew;
            Console.WriteLine($"Called via Parent reference (new): {baseRefNew.Product()}");
            Console.WriteLine($"Called via ChildNew instance: {childNew.Product()}");

            // ToString polymorphism
            Console.WriteLine($"Parent ToString on childOverride: {childOverride}");
            Console.WriteLine($"Parent ToString on childNew: {childNew}");
            #endregion
        }
    }

    


    

}
