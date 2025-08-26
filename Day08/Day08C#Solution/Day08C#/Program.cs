using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace Day08C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region P1
            IVehicle myCar = new Car();
            IVehicle myBike = new Bike();


            myCar.StartEngine();
            myCar.StopEngine();

            myBike.StartEngine();
            myBike.StopEngine();
            #endregion

            #region P2 

            Shape rectangle = new Rectangle(5, 4);
            Shape circle = new Circle(3);

            rectangle.Display();
            Console.WriteLine("Rectangle Area = " + rectangle.GetArea());

            circle.Display();
            Console.WriteLine("Circle Area = " + circle.GetArea());
            #endregion


            #region P3
            Product[] products =
                  {
            new Product(1, "T-Shirt", 800.0m),
            new Product(2, "Jeans", 500.0m),
            new Product(3, "Jacket", 1000.0m),
            new Product(4, "Cap", 150.0m)
        };

            Console.WriteLine("Before Sorting:");
            foreach (var p in products)
            {
                Console.WriteLine(p);
            }


            Array.Sort(products, (x, y) => x.CompareTo(y));

            Console.WriteLine("\nAfter Sorting :");
            foreach (var p in products)
            {
                Console.WriteLine(p);
            }
            #endregion

            #region P4
            Student s1 = new Student(1, "Mohamed", 90.5);

            Student s2 = s1;

            Student s3 = new Student(s1);

            Console.WriteLine("Before changes:");
            Console.WriteLine("s1 = " + s1);
            Console.WriteLine("s2 = " + s2);
            Console.WriteLine("s3 = " + s3);


            s2.Name = "Ali";
            s2.Grade = 75.0;

            s3.Name = "Sara";
            s3.Grade = 85.0;

            Console.WriteLine("\nAfter changes:");
            Console.WriteLine("s1 = " + s1);
            Console.WriteLine("s2 = " + s2);
            Console.WriteLine("s3 = " + s3);
            #endregion

            #region P5
            Robot r = new Robot();

            r.Walk();

            IWalkable walkableRobot = r;
            walkableRobot.Walk();
            #endregion

            #region P6
            Account acc1 = new Account(1, "Mohamed", 5000);

            Console.WriteLine("Initial Account Details:");
            acc1.Display();

            acc1.Balance = 7000;

            acc1.Balance = -100;

            acc1.AccountHolder = "Ali";

            Console.WriteLine("\nUpdated Account Details:");
            acc1.Display();
            #endregion

            #region P8
            Book book1 = new Book();
            book1.Display();

            Book book2 = new Book("The Silent Patient");
            book2.Display();

            Book book3 = new Book("1984", "George Orwell");
            book3.Display();
            #endregion

            #region IShapeSeries
            static void PrintTenShapes(IShapeSeries series)
            {
                series.ResetSeries();
                for (int i = 0; i < 10; i++)
                {
                    series.GetNextArea();
                    Console.WriteLine($"Shape {i + 1} Area = {series.CurrentShapeArea:F2}");
                }
            }



            Console.WriteLine("Square Series:");
            PrintTenShapes(new SquareSeries());

            Console.WriteLine("\nCircle Series:");
            PrintTenShapes(new CircleSeries());

            #endregion


            #region shapes 
            Shape1[] shapes =
           {
            new Shape1("Square", 25),
            new Shape1("Circle", Math.PI * 3 * 3),
            new Shape1("Rectangle", 20),
            new Shape1("Circle", Math.PI * 5 * 5),
            new Shape1("Square", 9)
        };

            Console.WriteLine("Before Sorting:");
            foreach (var shape in shapes)
                Console.WriteLine(shape);


            Array.Sort(shapes);

            Console.WriteLine("\nAfter Sorting by Area:");
            foreach (var shape in shapes)
                Console.WriteLine(shape);

            #endregion

            #region ShapeHierarchy
            GeometricShape triangle = new Triangle(3, 4);
            GeometricShape rectangle1 = new Rectangle1(5, 7);

            Console.WriteLine("Triangle:");
            Console.WriteLine($"Area = {triangle.CalculateArea()}");
            Console.WriteLine($"Perimeter = {triangle.Perimeter}");

            Console.WriteLine("\nRectangle:");
            Console.WriteLine($"Area = {rectangle1.CalculateArea()}");
            Console.WriteLine($"Perimeter = {rectangle1.Perimeter}");
            #endregion

            #region sort
            int[] arr = { 64, 25, 12, 22, 11 };

            Console.WriteLine("before: " + string.Join(", ", arr));

            SelectionSort(arr);

            Console.WriteLine("after: " + string.Join(", ", arr));


        }
        public static void SelectionSort(int[] numbers)
        {
            int n = numbers.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }


                int temp = numbers[minIndex];
                numbers[minIndex] = numbers[i];
                numbers[i] = temp;
            }
        } 
        #endregion
    }
    }


      
    



