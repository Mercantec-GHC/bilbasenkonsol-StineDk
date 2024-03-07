using Class_Domain_Models;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

namespace BilbasenKonsol
{
    internal class Program
    {
        //Eksempel med rigtige biler, lavet af ChatGPT ud fra jeres standart klasse
        private static List<Car> Gasoline_DieselCars = new List<Car>()
        {
            new Car("Ford", "Mustang", 1963, "Red", 430, "Benzin"),
            new Car("Toyota", "Camry", 2020, "Blue", 200, "Benzin"),
            new Car("Chevrolet", "Corvette", 2022, "Silver", 650, "Benzin"),
            new Car("Audi", "RS6", 2022, "Black", 591, "Benzin"),
            new Car("Honda", "Accord Hybrid", 2019, "Silver", 212, "Benzin and Electric"),
            new Car("BMW", "X7", 2017, "Red", 355, "Benzin"),
            new Car("Mercedes-Benz", "AMG GLE 63", 2018, "Gray", 577, "Benzin"),
            new Car("Audi", "Q3", 2020, "Black", 184, "Diesel"),
            new Car("Nissan", "Maxima", 2022, "Blue", 300, "Benzin"),
            new Car("Volkswagen", "Atlas Cross Sport", 2021, "White", 276, "Benzin"),
            new Car("Toyota", "4Runner", 2015, "Silver", 270, "Diesel"),
            new Car("Chevrolet", "Traverse", 2018, "Red", 310, "Benzin"),
            new Car("Honda", "HR-V", 2019, "Gray", 141, "Benzin"),
            new Car("BMW", "X6", 2016, "Black", 445, "Benzin"),
            new Car("Mercedes-Benz", "GLB Class", 2023, "Blue", 221, "Benzin"),
            new Car("Honda", "Civic", 2005, "Black", 140, "Benzin"),
            new Car("BMW", "3 Series", 2018, "White", 248, "Benzin"),
            new Car("Mercedes-Benz", "E-Class", 2015, "Gray", 302, "Benzin"),
            new Car("Audi", "A4", 2019, "Blue", 188, "Benzin"),
            new Car("Nissan", "Altima", 2017, "Silver", 179, "Benzin"),
            new Car("Volkswagen", "Golf", 2016, "Red", 170, "Benzin"),
            new Car("Hyundai", "Elantra", 2014, "Green", 147, "Benzin"),
            new Car("Ford", "F-150", 2019, "Black", 395, "Diesel"),
            new Car("Toyota", "RAV4", 2021, "Gray", 203, "Diesel"),
            new Car("Chevrolet", "Silverado", 2016, "Blue", 285, "Benzin"),
            new Car("Honda", "Accord", 2013, "White", 185, "Benzin"),
            new Car("BMW", "5 Series", 2023, "Black", 300, "Benzin"),
            new Car("Mercedes-Benz", "CLS-Class", 2017, "Silver", 362, "Benzin"),
            new Car("Audi", "A6", 2020, "Blue", 248, "Benzin"),
            new Car("Nissan", "Sentra", 2018, "Red", 149, "Benzin"),
            new Car("Volkswagen", "Jetta", 2015, "Gray", 150, "Benzin"),
            new Car("Hyundai", "Sonata", 2012, "Black", 138, "Benzin"),
            new Car("Ford", "Escape", 2019, "Blue", 181, "Benzin"),
            new Car("Toyota", "Corolla", 2022, "White", 169, "Benzin"),
            new Car("Chevrolet", "Equinox", 2017, "Silver", 170, "Benzin"),
            new Car("Honda", "Fit", 2014, "Red", 130, "Benzin"),
            new Car("BMW", "7 Series", 2016, "Black", 320, "Benzin"),
            new Car("Mercedes-Benz", "GLC Class", 2021, "Blue", 255, "Benzin"),
            new Car("Audi", "Q5", 2019, "Gray", 248, "Benzin"),
            new Car("Nissan", "Rogue", 2018, "Black", 170, "Benzin"),
            new Car("Volkswagen", "Tiguan", 2015, "White", 200, "Diesel"),
            new Car("Hyundai", "Tucson", 2013, "Silver", 182, "Benzin"),
            new Car("Ford", "Explorer", 2020, "Red", 290, "Benzin"),
            new Car("Toyota", "Highlander", 2017, "Blue", 295, "Benzin"),
            new Car("Chevrolet", "Tahoe", 2014, "Black", 355, "Benzin"),
            new Car("Honda", "Pilot", 2011, "Gray", 250, "Benzin"),
            new Car("BMW", "X3", 2018, "Silver", 248, "Benzin"),
            new Car("Mercedes-Benz", "GLE Class", 2019, "Blue", 362, "Benzin"),
            new Car("Audi", "Q7", 2016, "White", 333, "Diesel"),
            new Car("Nissan", "Pathfinder", 2013, "Red", 260, "Diesel"),
            new Car("Volkswagen", "Atlas", 2022, "Gray", 276, "Benzin"),
            new Car("Hyundai", "Santa Fe", 2018, "Black", 235, "Benzin"),
            new Car("Ford", "Edge", 2015, "Blue", 245, "Benzin"),
            new Car("Toyota", "Sienna", 2012, "Silver", 266, "Benzin"),
            new Car("Chevrolet", "Suburban", 2019, "White", 355, "Benzin"),
            new Car("Honda", "Odyssey", 2016, "Gray", 280, "Benzin"),
            new Car("BMW", "X5", 2013, "Black", 300, "Benzin"),
            new Car("Mercedes-Benz", "GLS Class", 2020, "Blue", 362, "Benzin"),
            new Car("Audi", "A8", 2017, "Red", 450, "Benzin"),
            new Car("Nissan", "Armada", 2014, "Gray", 390, "Benzin"),
            new Car("Volkswagen", "Passat", 2011, "Silver", 170, "Benzin"),
            new Car("Hyundai", "Veloster", 2018, "Blue", 147, "Benzin"),
            new Car("Ford", "Ranger", 2015, "Red", 270, "Diesel"),
            new Car("Toyota", "Tacoma", 2012, "Black", 278, "Benzin"),
            new Car("Chevrolet", "Colorado", 2019, "Gray", 308, "Benzin"),
            new Car("Honda", "Ridgeline", 2016, "White", 280, "Benzin"),
            new Car("BMW", "M3", 2020, "Black", 473, "Benzin"),
            new Car("Mercedes-Benz", "AMG GLA 45", 2017, "Gray", 375, "Benzin"),
            new Car("Audi", "S4", 2014, "Blue", 333, "Benzin"),
            new Car("Nissan", "Frontier", 2011, "Silver", 261, "Benzin"),
            new Car("Volkswagen", "Arteon", 2018, "Red", 268, "Benzin"),
            new Car("Hyundai", "Santa Cruz", 2022, "Gray", 275, "Benzin"),
            new Car("Ford", "Mustang Shelby GT500", 2023, "Blue", 760, "Benzin"),
            new Car("Toyota", "Supra", 2021, "White", 382, "Benzin"),
            new Car("Chevrolet", "Camaro", 2020, "Black", 455, "Benzin"),
            new Car("Honda", "S2000", 2019, "Red", 237, "Benzin"),
            new Car("BMW", "Z4", 2016, "Silver", 382, "Benzin"),
            new Car("Mercedes-Benz", "SL Class", 2013, "Gray", 577, "Benzin"),
            new Car("Audi", "R8", 2017, "Blue", 602, "Benzin"),
            new Car("Nissan", "GT-R", 2022, "Black", 565, "Benzin"),
            new Car("Volkswagen", "Golf GTI", 2018, "Red", 228, "Benzin"),
            new Car("Hyundai", "Genesis Coupe", 2015, "Gray", 348, "Benzin"),
            new Car("Ford", "GT", 2019, "Blue", 647, "Benzin"),
            new Car("Toyota", "86", 2016, "White", 205, "Benzin"),
            new Car("Chevrolet", "Volt", 2020, "Black", 149, "Benzin"),
            new Car("Ford", "Mustang", 1985, "Blue", 210, "Benzin"),
            new Car("Toyota", "Supra", 1988, "Red", 230, "Benzin"),
            new Car("Chevrolet", "Camaro", 1992, "Black", 275, "Benzin"),
            new Car("Honda", "NSX", 1991, "Silver", 270, "Benzin"),
            new Car("BMW", "M3", 1987, "White", 215, "Benzin"),
            new Car("Mercedes-Benz", "190E", 1993, "Gray", 147, "Benzin")
        };
        public static List<Car> ElectricCars = new List<Car>()
        {
            new Car("Honda", "Clarity Electric", 2018, "Silver", 161, "Electric"),
            new Car("BMW", "i3", 2019, "Blue", 168, "Electric"),
            new Car("Mercedes-Benz", "EQC", 2022, "Gray", 402, "Electric"),
            new Car("Audi", "E-Tron", 2021, "Red", 355, "Electric"),
            new Car("Nissan", "Leaf", 2017, "Black", 147, "Electric"),
            new Car("Volkswagen", "ID.4", 2020, "White", 201, "Electric"),
            new Car("Hyundai", "Kona Electric", 2019, "Gray", 201, "Electric"),
            new Car("Ford", "Mustang Mach-E", 2023, "Blue", 480, "Electric"),
            new Car("Toyota", "RAV4 EV", 2014, "Red", 154, "Electric"),
            new Car("Chevrolet", "Bolt EV", 2021, "Black", 200, "Electric")
        };
        public static void Main()
        {
            Label:
            Console.Clear();
            Console.WriteLine("Do you want\n1. Electric\n2. Gasoline or Diesel");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    SearchMenu(ElectricCars);
                    break;
                case "2":
                    SearchMenu(Gasoline_DieselCars);
                    break;
            }
        }   
        public static void SearchMenu(List<Car> list)
        {
            Console.WriteLine("Which menu do you want to use?\n1. Show all cars with the same brand as the first car in the database.\n2. Show all cars with 200 or more HK.\n3. Show all red cars.");
            Console.WriteLine("4. Show amount of cars with the same brand as the first car in the database.\n5. Show cars from 1980 - 1999.");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    FirstBrandInDatabase(list);
                    Console.WriteLine("Press Enter to continue.");
                    Console.Read();
                    break;
                case "2":
                    MoreThen200HK(list);
                    Console.WriteLine("Press Enter to continue.");
                    Console.Read();
                    break;
                case "3":
                    RedCars(list);
                    Console.WriteLine("Press Enter to continue.");
                    Console.Read();
                    break;
                case "4":
                    AmountOfCarsWithTheFirstBrandInTheDatabase(list);
                    Console.WriteLine("Press Enter to continue.");
                    Console.Read();
                    break;
                case "5":
                    CarsFrom80_99(list);
                    Console.WriteLine("Press Enter to continue.");
                    Console.Read();
                    break;
                default:
                    Main();
                    break;
            }
        }
        public static void FirstBrandInDatabase(List<Car> list)
        {
            Console.WriteLine($"\nCars matching the Brand 'Ford':");
            foreach (Car car in list)
            {
                if (car.Brand == "Ford")
                {
                    Console.WriteLine($"Brand: {car.Brand}. Model: {car.Model}. Year: {car.Year}. Color: {car.Color}. HorsePower: {car.HorsePower}. Number of cylinders: {car.FuelType}.\n");
                }
            }
        }
        public static void MoreThen200HK(List<Car> list)
        {
            Console.WriteLine("\nCars with more then 200 HK:");
            foreach (Car car in list)
            {
                if (car.HorsePower >= 200)
                {
                    Console.WriteLine($"Brand: {car.Brand}. Model: {car.Model}. Year: {car.Year}. Color: {car.Color}. HorsePower: {car.HorsePower}. Number of cylinders: {car.FuelType}.\n");
                }
            }
        }
        public static void RedCars(List<Car> list)
        {
            Console.WriteLine("\nCars that are red:");
            foreach (Car car in list)
            {
                if (car.Color == "Red")
                {
                    Console.WriteLine($"Brand: {car.Brand}. Model: {car.Model}. Year: {car.Year}. Color: {car.Color}. HorsePower: {car.HorsePower}. Number of cylinders: {car.FuelType}.\n");
                }
            }
        }
        public static void AmountOfCarsWithTheFirstBrandInTheDatabase(List<Car> list)
        {
            int carAmount = 0;
            foreach (Car car in list)
            {
                if (car.Brand == "Ford")
                {
                    carAmount++;
                }
            }
            Console.WriteLine($"Amount of cars of the brand 'Ford': {carAmount}.\n");
        }
        public static void CarsFrom80_99(List<Car> list)
        {
            Console.WriteLine("Cars from 1980 - 1999.");
            foreach (Car car in list)
            {
                if (car.Year >= 1980 && car.Year <= 1999)
                {
                    Console.WriteLine($"Brand: {car.Brand}. Model: {car.Model}. Year: {car.Year}. Color: {car.Color}. HorsePower: {car.HorsePower}. Number of cylinders: {car.FuelType}.\n");
                }
            }
        }
    }
}
