using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{
    internal class Program
    {

    }
    public class Vehicle
    {
        public string Brand;
        public int MaxSpeed;
        public Vehicle(string brand, int maxSpeed)
        {
            if (Brand == "")
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
            Console.WriteLine("транспорт едет");
        }
        public virtual void Print()
        {
            Console.WriteLine($"Марка: {Brand}, макс.скорость: {MaxSpeed} км / ч");
        }
    }
    public class Car : Vehicle
    {
        public int Doors;
        public Car(string brand, int maxSpeed, int doors) : base(brand, maxSpeed)
        {
            if (Doors <= 0)
            {
                doors = 4;
            }
            else
            {
                Doors = doors;
            }
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine("машина едет по дороге");

        }
        public class Bike : Vehicle
        {
            public bool HasBasket;
            public Bike(string brand, int maxSpeed, bool hasBasket) : base(brand, maxSpeed, hasBasket)
            {
                if (Doors <= 0)
                {
                    doors = 4;
                }
                else
                {
                    Doors = doors;
                }
            }
            public override void Move()
            {
                base.Move();
                Console.WriteLine("машина едет по дороге");

            }

        }
    }
