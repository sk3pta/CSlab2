/*Создайте класс Vehicle.
В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска).
Создайте 3 производных класса Plane, Саг и Ship.
Для класса Plane должна быть определена высота и количество пассажиров.
Для класса Ship — количество пассажиров и порт приписки.
Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
*/
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Task2
{
    
    public abstract  class Vehicle
    {
        protected double length;
        protected double width;

        protected double price;

        protected int maxSpeed;
        protected int productionYear;

        public Vehicle(double length, double width, double price, int maxSpeed, int productionYear)
        {
            this.length = length;
            this.width = width;
            this.price = price;
            this.maxSpeed = maxSpeed;
            this.productionYear = productionYear;
        }

        public virtual void Info()
        {
            Console.WriteLine(
                             $"Length : {this.length}\n"
                            + $"Width  : {this.width}\n"
                            + $"Price  : {this.price}\n"
                            + $"Max.Speed : {this.maxSpeed}\n"
                            + $"ProductionYear : {this.productionYear}");

        }

    }

    public class Plane : Vehicle
    {
        private double height;
        private int capacity;

        public Plane(double length,double  width,double  price, int maxSpeed, int productionYear, double height, int capacity) : base(length, width, price,maxSpeed,productionYear)
        {
            this.height = height;
            this.capacity = capacity;
        }

        public override void Info()
        {
            Console.Write($"\nType : {typeof(Plane)}");
            base.Info();
            Console.WriteLine($"Heigth : {this.height}" +
                              $"Capacity : {this.capacity}");

        }

    }

    public class Ship : Vehicle
    {
        private double capacity;
        private int portId;



        public Ship(double length, double width, double price, int maxSpeed, int productionYear, int capacity, int portId) : base(length, width, price, maxSpeed, productionYear)
        {
            this.capacity = capacity;
            this.portId = portId;
        }

        public override void Info()
        {
            Console.WriteLine($"\nType : {typeof(Ship)}");
            base.Info();
            
            Console.WriteLine($"Capacity : {this.capacity}\n" + 
                              $"PortID : {this.portId}");
        }

    }


    public class Car : Vehicle
    {

        public Car(double length, double width, double price, int maxSpeed, int productionYear) : base(length, width, price, maxSpeed, productionYear) { }
        public override void Info()
        {
            Console.WriteLine($"\nType : {typeof(Car)}");
            base.Info();
        }
    }




   










    public sealed class Program
    {
        public static void Main(string[] args)
        {


            Vehicle supra = new Car(3,2,150000,15,1456);
            Vehicle Titanoc = new Ship(130, 50, 10000000, 25, 2020, 740, 12444423);
            Titanoc.Info();
            supra.Info();


        }
    }
}