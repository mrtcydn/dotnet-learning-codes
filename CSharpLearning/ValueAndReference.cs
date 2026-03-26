using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSharpLearning
{
    internal class ValueAndReference
    {
        public static void Run()
        {
            Box box1 = new Box();
            box1.Value = 10;

            Box box2 = box1; // box2 references the same object as box1
            box2.Value = 20;

            Console.WriteLine("Class type box value : " + box1.Value);


            StructBox sbox1 = new StructBox();
            sbox1.Value = 10;
            StructBox sbox2 = sbox1; // box2 is a copy of box1
            sbox2.Value = 20;

            Console.WriteLine("Struct type box value : " + sbox1.Value);

            VRPerson person1 = new VRPerson();
            person1.Age = 30;

            Change(person1);

            Console.WriteLine("Person Age : " + person1.Age);

            static void Change(VRPerson person)
            {
                person = new VRPerson(); // This creates a new object and assigns it to the local variable 'person'
                person.Age = 55;
            }

            PersonX personX1 = new PersonX();
            personX1.Age = 25;
            
            PersonX personX2 = personX1; // personX2 references the same object as personX1
            personX2.Age = 40;

            Console.WriteLine("PersonX1 Age : " + personX1.Age);
            Console.WriteLine("PersonX2 Age : " + personX2.Age);

            Point point1 = new Point();
            point1.X  = -21;

            Point point2 = point1; // point2 is a copy of point1
            point2.X = 99;

            Console.WriteLine("Point1 X : " + point1.X);
            Console.WriteLine("Point2 X : " + point2.X);
           

            Car clio = new Car();
            clio.Speed = 90;

            IncreaseSpeed(clio); // This passes a reference to the Car object that 'clio' references
            Console.WriteLine("Clio Speed : " + clio.Speed);

            static void IncreaseSpeed(Car car)
            {
                car.Speed = 180; // This modifies the Speed property of the Car object that 'car' references
            }


            VAR_Employee employee = new VAR_Employee();
            employee.Age = 35;

            ModifyEmployeeAge(employee); // This passes a reference to the VAR_Employee object that 'employee' references

            Console.WriteLine("Employee Age : " + employee.Age); 

            static void ModifyEmployeeAge(VAR_Employee employee)
            {
                employee.Age = 50; // This modifies the Age property of the VAR_Employee object that 'employee' references
                employee = new VAR_Employee(); // This creates a new object and assigns it to the local variable 'employee'
                employee.Age = 60; // This modifies the Age property of the new VAR_Employee object that 'employee' now references
            }
        }
    }

    public class Box
    {
        public int Value;
    }

    public struct StructBox
    {
        public int Value;
    }

    public class VRPerson
    {
        public int Age;
    }

    public class PersonX
    {
        public string Name;
        public int Age;
    }

    public struct Point
    { 
       public int X; 
       public int Y;
    }

    public class Car
    {
        public float Speed;
    }

    public class VAR_Employee
    {
        public int Age;
    }
}
