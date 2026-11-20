using System;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Задание 1: Транспорт
            Console.WriteLine("Задание 1");
            Vehicle vehicle = new Vehicle("Транспорт", 60);
            Car car = new Car("Toyota", 180, 4);
            Bike bike = new Bike("Stels", 25, true);
            vehicle.Move();
            car.Move();
            bike.Move();
            Console.WriteLine();

            // Задание 2: Сотрудники
            Console.WriteLine("Задание 2");
            Employee employee = new Employee("Иван", 30000);
            Manager manager = new Manager("Ольга", 50000, 10000);
            Intern intern = new Intern("Петя", 30000, 15);
            employee.Print();
            manager.Print();
            intern.Print();
            Console.WriteLine();

            // Задание 3: Иерархия животных
            Console.WriteLine("Задание 3");
            Dog dog = new Dog("Шарик", 3, "рыжий");
            Cat cat = new Cat("Мурка", 2, "");
            dog.MakeSound();
            dog.Info();
            Console.WriteLine();
            cat.MakeSound();
            cat.Info();
            Console.WriteLine();
        }
    }

    // ===== Задание 1 =====

    public class Vehicle
    {
        public string Brand;
        public int MaxSpeed;

        public Vehicle(string brand, int maxSpeed)
        {
            if (brand == "")
            {
                Brand = "Неизвестно";
            }
            else
            {
                Brand = brand;
            }

            if (maxSpeed <= 0)
            {
                MaxSpeed = 100;
            }
            else
            {
                MaxSpeed = maxSpeed;
            }
        }

        public virtual void Move()
        {
            Console.WriteLine("Транспорт едет");
        }

        public void Print()
        {
            Console.WriteLine($"Марка: {Brand}, макс. скорость: {MaxSpeed} км/ч");
        }
    }

    public class Car : Vehicle
    {
        public int Doors;

        public Car(string brand, int maxSpeed, int doors) : base(brand, maxSpeed)
        {
            if (doors <= 0)
            {
                Doors = 4;
            }
            else
            {
                Doors = doors;
            }
        }

        public override void Move()
        {
            base.Move();
            Console.WriteLine("Машина едет по дороге");
        }
    }

    public class Bike : Vehicle
    {
        public bool HasBasket;

        public Bike(string brand, int maxSpeed, bool hasBasket) : base(brand, maxSpeed)
        {
            HasBasket = hasBasket;
        }

        public override void Move()
        {
            Console.WriteLine("Велосипед крутит педали");
        }
    }

    // ===== Задание 2 =====

    public class Employee
    {
        public string Name;
        public decimal BaseSalary;

        public Employee(string name, decimal baseSalary)
        {
            if (name == "")
            {
                Name = "Сотрудник";
            }
            else
            {
                Name = name;
            }

            if (baseSalary <= 0)
            {
                BaseSalary = 30000;
            }
            else
            {
                BaseSalary = baseSalary;
            }
        }

        public virtual decimal CalculateSalary()
        {
            return BaseSalary;
        }

        public void Print()
        {
            Console.WriteLine($"{Name}: {CalculateSalary()} ₽");
        }
    }

    public class Manager : Employee
    {
        public decimal Bonus;

        public Manager(string name, decimal baseSalary, decimal bonus) : base(name, baseSalary)
        {
            if (bonus < 0)
            {
                Bonus = 0;
            }
            else
            {
                Bonus = bonus;
            }
        }

        public override decimal CalculateSalary()
        {
            return base.CalculateSalary() + Bonus;
        }
    }

    public class Intern : Employee
    {
        public int WorkedDays;

        public Intern(string name, decimal baseSalary, int workedDays) : base(name, baseSalary)
        {
            if (workedDays < 0)
            {
                WorkedDays = 0;
            }
            else
            {
                WorkedDays = workedDays;
            }
        }

        public override decimal CalculateSalary()
        {
            return BaseSalary * WorkedDays / 30;
        }
    }

    // ===== Задание 3 =====

    public class Animal
    {
        public string Name;
        public int Age;

        public Animal(string name, int age)
        {
            if (name == "")
            {
                Name = "Зверь";
            }
            else
            {
                Name = name;
            }

            if (age < 0)
            {
                Age = 0;
            }
            else
            {
                Age = age;
            }
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("...");
        }

        // Write, а не WriteLine: наследники дописывают текст в ту же строку
        public virtual void Info()
        {
            Console.Write($"Имя: {Name}, возраст: {Age} лет");
        }
    }

    public class Mammal : Animal
    {
        public string FurColor;

        public Mammal(string name, int age, string furColor) : base(name, age)
        {
            if (furColor == "")
            {
                FurColor = "серый";
            }
            else
            {
                FurColor = furColor;
            }
        }

        public override void Info()
        {
            base.Info();
            Console.Write($", шерсть: {FurColor}");
        }
    }

    public class Dog : Mammal
    {
        public Dog(string name, int age, string furColor) : base(name, age, furColor)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Гав!");
        }
    }

    public class Cat : Mammal
    {
        public Cat(string name, int age, string furColor) : base(name, age, furColor)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Мяу!");
        }

        public override void Info()
        {
            base.Info();
            Console.Write(" (кот)");
        }
    }
}
