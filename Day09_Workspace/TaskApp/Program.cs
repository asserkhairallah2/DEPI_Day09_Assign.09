using System;

namespace TaskApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. Enums and TryParse Testing
            Console.WriteLine("=== 1. Enums & TryParse ===");
            foreach (var day in Enum.GetValues(typeof(Weekdays)))
            {
                Console.WriteLine($"Day: {day}, Value: {(int)day}");
            }

            string inputGrade = "A";
            if (Enum.TryParse(inputGrade, out Grades parsedGrade))
            {
                Console.WriteLine($"Parsed Grade successfully: {parsedGrade} with value {(short)parsedGrade}");
            }
            #endregion

            #region 2. Utility & ComplexNumber Overloading Testing
            Console.WriteLine("\n=== 2. Utility & Operator Overloading ===");
            Console.WriteLine($"Perimeter of Rectangle (10, 5): {Utility.CalculateRectanglePerimeter(10, 5)}");
            Console.WriteLine($"Celsius 25 to Fahrenheit: {Utility.CelsiusToFahrenheit(25)}");

            ComplexNumber c1 = new ComplexNumber(2, 3);
            ComplexNumber c2 = new ComplexNumber(1, 4);
            ComplexNumber c3 = c1 * c2; // Multiplication Overloading
            Console.WriteLine($"Complex Multiplication Result: {c3}");
            #endregion

            #region 3. Rectangle & Non-Generic Swap Testing
            Console.WriteLine("\n=== 3. Rectangle Swap ===");
            Rectangle rect1 = new Rectangle(10, 20);
            Rectangle rect2 = new Rectangle(30, 40);
            Console.WriteLine($"Before Swap -> Rect1: {rect1}, Rect2: {rect2}");
            Rectangle.Swap(ref rect1, ref rect2);
            Console.WriteLine($"After Swap  -> Rect1: {rect1}, Rect2: {rect2}");
            #endregion

            #region 4. Generics, Helper2, and Employee Search Testing
            Console.WriteLine("\n=== 4. Generics & Employee Search ===");
            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] reversed = ArrayHelper.ReverseArray(numbers);
            Console.WriteLine($"Reversed Array: {string.Join(", ", reversed)}");

            // Employee and Department Search using Helper2
            Department deptIT = new Department(1, "IT");
            Department deptHR = new Department(2, "HR");

            Employee[] employees = {
                new Employee(101, "Asser", deptIT),
                new Employee(102, "Ali", deptHR),
                new Employee(103, "Omar", deptIT)
            };

            Employee targetEmp = new Employee(102, "Ali", deptHR);
            int empIndex = Helper2<Employee>.SearchArray(employees, targetEmp);
            Console.WriteLine($"Employee Found at Index: {empIndex}");

            // Replace Array Test
            string[] colors = { "Red", "Blue", "Green", "Blue" };
            Helper2<string>.ReplaceArray(colors, "Blue", "Yellow");
            Console.WriteLine($"After ReplaceArray: {string.Join(", ", colors)}");
            #endregion

            #region 5. Person & Sealed Property Testing
            Console.WriteLine("\n=== 5. Person & Sealed Property ===");
            Person p1 = new Person(1, "Asser", deptIT);
            Person p2 = new Person(2, "Mohamed", deptHR);
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            ChildClass child = new ChildClass();
            child.Salary = 7500.0;
            child.DisplaySalary();
            #endregion

            #region 6. Circle Comparison & Gender Memory & Stack Testing
            Console.WriteLine("\n=== 6. Circle, Gender Memory & Stack ===");
            
            // Circle Struct vs Class comparison demo
            CircleStruct cs1 = new CircleStruct(5.0, "Red");
            CircleStruct cs2 = new CircleStruct(5.0, "Red");
            Console.WriteLine($"CircleStruct Equals: {cs1.Equals(cs2)}");
            Console.WriteLine($"CircleStruct == operator: {cs1 == cs2}");

            CircleClass cc1 = new CircleClass(5.0, "Red");
            CircleClass cc2 = new CircleClass(5.0, "Red");
            Console.WriteLine($"CircleClass Equals (Reference check by default): {cc1.Equals(cc2)}");
            Console.WriteLine($"CircleClass == operator (Reference check): {cc1 == cc2}");

            // Gender Enum Memory Demonstration
            Console.WriteLine($"Gender Enum underlying type size (byte): {sizeof(Gender)} byte");
            Console.WriteLine($"Default Enum underlying type size (int): {sizeof(int)} bytes");

            // Stack Test
            MyStack<int> intStack = new MyStack<int>(3);
            intStack.Push(100);
            intStack.Push(200);
            Console.WriteLine($"Stack Peek: {intStack.Peek()}");
            Console.WriteLine($"Stack Pop: {intStack.Pop()}");
            #endregion
        }
    }
}