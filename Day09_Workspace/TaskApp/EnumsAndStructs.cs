using System;

namespace TaskApp
{
    #region Person and Inheritance (Part 01)
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Department Department { get; set; } // Virtual property as required

        public Person(int id, string name, Department department)
        {
            Id = id;
            Name = name;
            Department = department;
        }

        public override string ToString() => $"ID: {Id}, Name: {Name}, Department: {Department}";
    }

    public class ParentClass
    {
        private double _salary;
        public virtual double Salary
        {
            get => _salary;
            set => _salary = value;
        }
    }

    public class ChildClass : ParentClass
    {
        // Sealed property to prevent further overriding in derived classes
        public sealed override double Salary
        {
            get => base.Salary;
            set => base.Salary = value;
        }

        public void DisplaySalary()
        {
            Console.WriteLine($"Child Sealed Salary: {Salary}");
        }
    }
    #endregion
    #region Enums Definitions
    public enum Weekdays
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }

    public enum Grades : short
    {
        F = -1,
        D = 50,
        C = 65,
        B = 75,
        A = 85
    }

    public enum Gender : byte
    {
        Male = 1,
        Female = 2
    }
    #endregion

    #region Circle Comparison (Struct vs Class)
    public struct CircleStruct
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public CircleStruct(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }

        // Operator Overloading for Struct == and !=
        public static bool operator ==(CircleStruct c1, CircleStruct c2)
        {
            return c1.Radius == c2.Radius && c1.Color == c2.Color;
        }

        public static bool operator !=(CircleStruct c1, CircleStruct c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            return obj is CircleStruct other && this == other;
        }

        public override int GetHashCode() => HashCode.Combine(Radius, Color);
    }

    public class CircleClass
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public CircleClass(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }
    }
    #endregion

    #region Rectangle Struct & Non-Generic Swap
    public struct Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public static void Swap(ref Rectangle r1, ref Rectangle r2)
        {
            Rectangle temp = r1;
            r1 = r2;
            r2 = temp;
        }

        public override string ToString() => $"Length: {Length}, Width: {Width}";
    }
    #endregion

    #region ComplexNumber with Multiplication Operator Overloading
    public class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Operator Overloading for Multiplication (*)
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            double realResult = (c1.Real * c2.Real) - (c1.Imaginary * c2.Imaginary);
            double imagResult = (c1.Real * c2.Imaginary) + (c1.Imaginary * c2.Real);
            return new ComplexNumber(realResult, imagResult);
        }

        public override string ToString() => $"{Real} + {Imaginary}i";
    }
    #endregion

    #region Department and Employee Classes
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override bool Equals(object obj)
        {
            if (obj is Department dept)
            {
                return Id == dept.Id && Name == dept.Name;
            }
            return false;
        }

        public override int GetHashCode() => HashCode.Combine(Id, Name);
        public override string ToString() => Name;
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }

        public Employee(int id, string name, Department department)
        {
            Id = id;
            Name = name;
            Department = department;
        }

        public override bool Equals(object obj)
        {
            if (obj is Employee emp)
            {
                return Id == emp.Id && Name == emp.Name;
            }
            return false;
        }

        public override int GetHashCode() => HashCode.Combine(Id, Name);
        public override string ToString() => $"ID: {Id}, Name: {Name}, Dept: {Department}";
    }
    #endregion
}