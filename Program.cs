﻿using Class_Domain_Models;
using System.Security.Cryptography.X509Certificates;

namespace BilbasenKonsol
{
    internal class Program
    {
        //Eksempel med rigtige biler, lavet af ChatGPT ud fra jeres standart klasse
        public static List<Gasoline_DieselCars> Gasoline_DieselCars = new List<Gasoline_DieselCars>()
        {
            new Gasoline_DieselCars("Ford", "Mustang", 1963, "Red", 430, 8),
            new Gasoline_DieselCars("Toyota", "Camry", 2020, "Blue", 200, 4),
            new Gasoline_DieselCars("Chevrolet", "Corvette", 2022, "Silver", 650, 8),
            new Gasoline_DieselCars("Audi", "RS6", 2022, "Black", 591, 8),
            new Gasoline_DieselCars("Honda", "Accord Hybrid", 2019, "Silver", 212, 4),
            new Gasoline_DieselCars("BMW", "X7", 2017, "Red", 355, 6),
            new Gasoline_DieselCars("Mercedes-Benz", "AMG GLE 63", 2018, "Gray", 577, 8),
            new Gasoline_DieselCars("Audi", "Q3", 2020, "Black", 184, 4),
            new Gasoline_DieselCars("Nissan", "Maxima", 2022, "Blue", 300, 6),
            new Gasoline_DieselCars("Volkswagen", "Atlas Cross Sport", 2021, "White", 276, 6),
            new Gasoline_DieselCars("Toyota", "4Runner", 2015, "Silver", 270, 6),
            new Gasoline_DieselCars("Chevrolet", "Traverse", 2018, "Red", 310, 6),
            new Gasoline_DieselCars("Honda", "HR-V", 2019, "Gray", 141, 4),
            new Gasoline_DieselCars("BMW", "X6", 2016, "Black", 445, 8),
            new Gasoline_DieselCars("Mercedes-Benz", "GLB Class", 2023, "Blue", 221, 4),
            new Gasoline_DieselCars("Honda", "Civic", 2005, "Black", 140, 4),
            new Gasoline_DieselCars("BMW", "3 Series", 2018, "White", 248, 6),
            new Gasoline_DieselCars("Mercedes-Benz", "E-Class", 2015, "Gray", 302, 6),
            new Gasoline_DieselCars("Audi", "A4", 2019, "Blue", 188, 4),
            new Gasoline_DieselCars("Nissan", "Altima", 2017, "Silver", 179, 4),
            new Gasoline_DieselCars("Volkswagen", "Golf", 2016, "Red", 170, 4),
            new Gasoline_DieselCars("Hyundai", "Elantra", 2014, "Green", 147, 4),
            new Gasoline_DieselCars("Ford", "F-150", 2019, "Black", 395, 6),
            new Gasoline_DieselCars("Toyota", "RAV4", 2021, "Gray", 203, 4),
            new Gasoline_DieselCars("Chevrolet", "Silverado", 2016, "Blue", 285, 8),
            new Gasoline_DieselCars("Honda", "Accord", 2013, "White", 185, 4),
            new Gasoline_DieselCars("BMW", "5 Series", 2023, "Black", 300, 6),
            new Gasoline_DieselCars("Mercedes-Benz", "CLS-Class", 2017, "Silver", 362, 6),
            new Gasoline_DieselCars("Audi", "A6", 2020, "Blue", 248, 6),
            new Gasoline_DieselCars("Nissan", "Sentra", 2018, "Red", 149, 4),
            new Gasoline_DieselCars("Volkswagen", "Jetta", 2015, "Gray", 150, 4),
            new Gasoline_DieselCars("Hyundai", "Sonata", 2012, "Black", 138, 4),
            new Gasoline_DieselCars("Ford", "Escape", 2019, "Blue", 181, 4),
            new Gasoline_DieselCars("Toyota", "Corolla", 2022, "White", 169, 4),
            new Gasoline_DieselCars("Chevrolet", "Equinox", 2017, "Silver", 170, 4),
            new Gasoline_DieselCars("Honda", "Fit", 2014, "Red", 130, 4),
            new Gasoline_DieselCars("BMW", "7 Series", 2016, "Black", 320, 8),
            new Gasoline_DieselCars("Mercedes-Benz", "GLC Class", 2021, "Blue", 255, 4),
            new Gasoline_DieselCars("Audi", "Q5", 2019, "Gray", 248, 4),
            new Gasoline_DieselCars("Nissan", "Rogue", 2018, "Black", 170, 4),
            new Gasoline_DieselCars("Volkswagen", "Tiguan", 2015, "White", 200, 4),
            new Gasoline_DieselCars("Hyundai", "Tucson", 2013, "Silver", 182, 4),
            new Gasoline_DieselCars("Ford", "Explorer", 2020, "Red", 290, 6),
            new Gasoline_DieselCars("Toyota", "Highlander", 2017, "Blue", 295, 6),
            new Gasoline_DieselCars("Chevrolet", "Tahoe", 2014, "Black", 355, 8),
            new Gasoline_DieselCars("Honda", "Pilot", 2011, "Gray", 250, 6),
            new Gasoline_DieselCars("BMW", "X3", 2018, "Silver", 248, 4),
            new Gasoline_DieselCars("Mercedes-Benz", "GLE Class", 2019, "Blue", 362, 6),
            new Gasoline_DieselCars("Audi", "Q7", 2016, "White", 333, 6),
            new Gasoline_DieselCars("Nissan", "Pathfinder", 2013, "Red", 260, 6),
            new Gasoline_DieselCars("Volkswagen", "Atlas", 2022, "Gray", 276, 6),
            new Gasoline_DieselCars("Hyundai", "Santa Fe", 2018, "Black", 235, 4),
            new Gasoline_DieselCars("Ford", "Edge", 2015, "Blue", 245, 6),
            new Gasoline_DieselCars("Toyota", "Sienna", 2012, "Silver", 266, 6),
            new Gasoline_DieselCars("Chevrolet", "Suburban", 2019, "White", 355, 8),
            new Gasoline_DieselCars("Honda", "Odyssey", 2016, "Gray", 280, 6),
            new Gasoline_DieselCars("BMW", "X5", 2013, "Black", 300, 6),
            new Gasoline_DieselCars("Mercedes-Benz", "GLS Class", 2020, "Blue", 362, 6),
            new Gasoline_DieselCars("Audi", "A8", 2017, "Red", 450, 8),
            new Gasoline_DieselCars("Nissan", "Armada", 2014, "Gray", 390, 8),
            new Gasoline_DieselCars("Volkswagen", "Passat", 2011, "Silver", 170, 4),
            new Gasoline_DieselCars("Hyundai", "Veloster", 2018, "Blue", 147, 4),
            new Gasoline_DieselCars("Ford", "Ranger", 2015, "Red", 270, 6),
            new Gasoline_DieselCars("Toyota", "Tacoma", 2012, "Black", 278, 6),
            new Gasoline_DieselCars("Chevrolet", "Colorado", 2019, "Gray", 308, 6),
            new Gasoline_DieselCars("Honda", "Ridgeline", 2016, "White", 280, 6),
            new Gasoline_DieselCars("BMW", "M3", 2020, "Black", 473, 6),
            new Gasoline_DieselCars("Mercedes-Benz", "AMG GLA 45", 2017, "Gray", 375, 4),
            new Gasoline_DieselCars("Audi", "S4", 2014, "Blue", 333, 6),
            new Gasoline_DieselCars("Nissan", "Frontier", 2011, "Silver", 261, 6),
            new Gasoline_DieselCars("Volkswagen", "Arteon", 2018, "Red", 268, 4),
            new Gasoline_DieselCars("Hyundai", "Santa Cruz", 2022, "Gray", 275, 6),
            new Gasoline_DieselCars("Ford", "Mustang Shelby GT500", 2023, "Blue", 760, 8),
            new Gasoline_DieselCars("Toyota", "Supra", 2021, "White", 382, 6),
            new Gasoline_DieselCars("Chevrolet", "Camaro", 2020, "Black", 455, 8),
            new Gasoline_DieselCars("Honda", "S2000", 2019, "Red", 237, 4),
            new Gasoline_DieselCars("BMW", "Z4", 2016, "Silver", 382, 4),
            new Gasoline_DieselCars("Mercedes-Benz", "SL Class", 2013, "Gray", 577, 8),
            new Gasoline_DieselCars("Audi", "R8", 2017, "Blue", 602, 10),
            new Gasoline_DieselCars("Nissan", "GT-R", 2022, "Black", 565, 6),
            new Gasoline_DieselCars("Volkswagen", "Golf GTI", 2018, "Red", 228, 4),
            new Gasoline_DieselCars("Hyundai", "Genesis Coupe", 2015, "Gray", 348, 6),
            new Gasoline_DieselCars("Ford", "GT", 2019, "Blue", 647, 8),
            new Gasoline_DieselCars("Toyota", "86", 2016, "White", 205, 4),
            new Gasoline_DieselCars("Chevrolet", "Volt", 2020, "Black", 149, 4),
            new Gasoline_DieselCars("Ford", "Mustang", 1985, "Blue", 210, 8),
            new Gasoline_DieselCars("Toyota", "Supra", 1988, "Red", 230, 6),
            new Gasoline_DieselCars("Chevrolet", "Camaro", 1992, "Black", 275, 8),
            new Gasoline_DieselCars("Honda", "NSX", 1991, "Silver", 270, 6),
            new Gasoline_DieselCars("BMW", "M3", 1987, "White", 215, 4),
            new Gasoline_DieselCars("Mercedes-Benz", "190E", 1993, "Gray", 147, 4)
        };
        public static List<ElectricCars> ElectricCars = new List<ElectricCars>()
        {
            new ElectricCars("Honda", "Clarity Electric", 2018, "Silver", 161, 0),
            new ElectricCars("BMW", "i3", 2019, "Blue", 168, 0),
            new ElectricCars("Mercedes-Benz", "EQC", 2022, "Gray", 402, 0),
            new ElectricCars("Audi", "E-Tron", 2021, "Red", 355, 0),
            new ElectricCars("Nissan", "Leaf", 2017, "Black", 147, 0),
            new ElectricCars("Volkswagen", "ID.4", 2020, "White", 201, 0),
            new ElectricCars("Hyundai", "Kona Electric", 2019, "Gray", 201, 0),
            new ElectricCars("Ford", "Mustang Mach-E", 2023, "Blue", 480, 0),
            new ElectricCars("Toyota", "RAV4 EV", 2014, "Red", 154, 0),
            new ElectricCars("Chevrolet", "Bolt EV", 2021, "Black", 200, 0)
        };
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("Do you want\n1. Electric\n2. Gasoline or Diesel");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":

                    break;
            }
            Console.WriteLine("Which menu do you want to use?\n1. Show all cars with the same brand as the first car in the database.\n2. Show all cars with 200 or more HK.\n3. Show all red cars.");
            Console.WriteLine("4. Show amount of cars with the same brand as the first car in the database.\n5. Show cars from 1980 - 1999.");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    FirstBrandInDatabase(Gasoline_DieselCars);
                    Console.WriteLine("Press Enter to continue.");
                    Console.Read();
                    break;
                case "2":
                    MoreThen200HK(Gasoline_DieselCars);
                    Console.WriteLine("Press Enter to continue.");
                    Console.Read();
                    break;
                case "3":
                    RedCars(Gasoline_DieselCars);
                    Console.WriteLine("Press Enter to continue.");
                    Console.Read();
                    break;
                case "4":
                    AmountOfCarsWithTheFirstBrandInTheDatabase(Gasoline_DieselCars);
                    Console.WriteLine("Press Enter to continue.");
                    Console.Read();
                    break;
                case "5":
                    CarsFrom80_99(Gasoline_DieselCars);
                    Console.WriteLine("Press Enter to continue.");
                    Console.Read();
                    break;
                default:
                    Main();
                    break;
            }
            Main();
        }   
        public static void FirstBrandInDatabase(List<Gasoline_DieselCars> list)
        {
            Console.WriteLine($"\nCars matching the Brand 'Ford':");
            foreach (Gasoline_DieselCars car in list)
            {
                if (car.Brand == "Ford")
                {
                    Console.WriteLine($"Brand: {car.Brand}. Model: {car.Model}. Year: {car.Year}. Color: {car.Color}. HorsePower: {car.HorsePower}. Number of cylinders: {car.NumberOfCylinders}.\n");
                }
            }
        }
        public static void MoreThen200HK(List<Gasoline_DieselCars> list)
        {
            Console.WriteLine("\nCars with more then 200 HK:");
            foreach (Gasoline_DieselCars car in list)
            {
                if (car.HorsePower >= 200)
                {
                    Console.WriteLine($"Brand: {car.Brand}. Model: {car.Model}. Year: {car.Year}. Color: {car.Color}. HorsePower: {car.HorsePower}. Number of cylinders: {car.NumberOfCylinders}.\n");
                }
            }
        }
        public static void RedCars(List<Gasoline_DieselCars> list)
        {
            Console.WriteLine("\nCars that are red:");
            foreach (Gasoline_DieselCars car in list)
            {
                if (car.Color == "Red")
                {
                    Console.WriteLine($"Brand: {car.Brand}. Model: {car.Model}. Year: {car.Year}. Color: {car.Color}. HorsePower: {car.HorsePower}. Number of cylinders: {car.NumberOfCylinders}.\n");
                }
            }
        }
        public static void AmountOfCarsWithTheFirstBrandInTheDatabase(List<Gasoline_DieselCars> list)
        {
            int carAmount = 0;
            foreach (Gasoline_DieselCars car in list)
            {
                if (car.Brand == "Ford")
                {
                    carAmount++;
                }
            }
            Console.WriteLine($"Amount of cars of the brand 'Ford': {carAmount}.\n");
        }
        public static void CarsFrom80_99(List<Gasoline_DieselCars> list)
        {
            Console.WriteLine("Cars from 1980 - 1999.");
            foreach (Gasoline_DieselCars car in list)
            {
                if (car.Year >= 1980 && car.Year <= 1999)
                {
                    Console.WriteLine($"Brand: {car.Brand}. Model: {car.Model}. Year: {car.Year}. Color: {car.Color}. HorsePower: {car.HorsePower}. Number of cylinders: {car.NumberOfCylinders}.\n");
                }
            }
        }
    }
}
