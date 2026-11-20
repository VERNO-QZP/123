using System;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", 180, 4);
            car.Print();
            car.Move();

            Console.WriteLine();

            Bike bike = new Bike("Stels", 25, true);
            bike.Print();
            bike.Move();

            Console.WriteLine();

            Car badCar = new Car("", -5, 0);
            badCar.Print();
            badCar.Move();
        }
    }

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

        public virtual void Print()
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
            base.Move();
            Console.WriteLine("Велосипед крутит педали");
        }
    }
}
