using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearning
{
    internal class RecordLearning
    {
        public static void Run()
        {
            Console.WriteLine("\nRecordLearning started...");
            var t1 = new TaskItem(1, "Learn C#", false);
            var t2 = new TaskItem(1, "Learn C#", false);

            Console.WriteLine("\n");
            Console.WriteLine(t1 == t2);

            var user = new User { Name = "Can", Age = 30 };
            var user1 = user with { Age = 18 };

            Console.WriteLine("\n");
            Console.WriteLine("User = " + user);
            Console.WriteLine("User1 = " + user1);
            Console.WriteLine(user.Name);
            Console.WriteLine(user.Age);

            var product = new Product("Laptop", 65999);
            var order = new Order(23, product, 35);

            Console.WriteLine("\n");
            Console.WriteLine(order);
            Console.WriteLine(order.Id);
            Console.WriteLine(order.Product);
            Console.WriteLine(order.Product.Name);
            Console.WriteLine(order.Product.Price);
            Console.WriteLine(order.Quantity);

            var person = new Person("Can");
            var employee = new Employee("Murat" ,5000);
            Console.WriteLine("\n");
            Console.WriteLine(person.Name);
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Salary);

            var student = new Student("Can",15);
            var (name, age) = student;
            Console.WriteLine("\n");
            Console.WriteLine(name);
            Console.WriteLine(age);
        }
    }

    public record TaskItem(int Id, string Title, bool IsCompleted);

    public record User
    {
        public string Name { get; init; }
        public int Age { get; init; }
    }

    public record Product(string Name, decimal Price);

    public record Order(int Id, Product Product, int Quantity);

    public record Person(string Name);
    public record Employee(string Name, int Salary) : Person(Name);
    public record Student(string Name, int Age);
}
