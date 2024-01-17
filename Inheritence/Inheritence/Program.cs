using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Inheritence
{
    internal class Program
    {
        static Random rng = new Random();
        static void Main(string[] args)
        {
            List<Skoda> skodas = new List<Skoda>();
            List<RangeRover> rangeRovers = new List<RangeRover>();
            List<Honda> hondas = new List<Honda>();

            CreateSkoda(skodas);
            CreateRangers(rangeRovers);
            CreateHondas(hondas);

            Menu(rangeRovers,hondas,skodas);

            Console.ReadLine();

        }

        static string GetFalseVin()
        {
            string Vin = string.Empty;

            int tempInt = 0;
            for (int i = 0; i < 17; i++)
            {
                tempInt = rng.Next(0, 9);
                Vin = Vin + tempInt.ToString();
            }
            return Vin;
        }

        static void Menu(List<RangeRover> Rangers, List<Honda> Hondas, List<Skoda> Skodas)
        {
            Console.Clear();

            DisplayMenu();

           int Choice = IntegerValidation("Please enter your choice");

            switch (Choice)
            {
                case 0:
                    Console.WriteLine("Invalid Choice, please try again");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Menu(Rangers, Hondas, Skodas);
                    break;
                case 1:
                    Console.Clear();
                    DisplayAllCars(Rangers,Hondas,Skodas); //display all cars
                    break;

                case 2:
                    Console.Clear();
                    DisplayAllSkodas(Rangers, Hondas, Skodas);//display all Skodas
                    break;

                case 3:
                    Console.Clear();
                    DisplayAllRangers(Rangers, Hondas, Skodas);//display all rangers
                    break;

                case 4:
                    Console.Clear();
                    DisplayAllHondas(Rangers, Hondas, Skodas);//display all hondas
                    break;

                case 5:
                    Console.Clear();
                    CreateANewCar(Skodas, Rangers, Hondas);//add a car
                    break;

                case 6:
                    Console.Clear();
                    Console.WriteLine("Thank you for using CarLTD");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                    break;

            }


        }

        static void DisplayMenu()
        {
            Console.WriteLine("1.Display all cars");
            Console.WriteLine("2.Display all Skodas");
            Console.WriteLine("3.Display all RangeRovers");
            Console.WriteLine("4.Display all Hondas");
            Console.WriteLine("5.Add a car");
            Console.WriteLine("6.Exit");
        }

        static void DisplayAllCars(List<RangeRover> Rangers, List<Honda> Hondas, List<Skoda> Skodas)
        {
            Console.WriteLine("------------");
            Console.WriteLine("Range Rovers");
            Console.WriteLine("------------");
            for (int i = 0; i < Rangers.Count; i++)
            {
                Console.WriteLine($"Range Rover -- VinNumber:{Rangers[i].VinNumber}, Number Plate:{Rangers[i].NumberPlate}, Number Of doors:{Rangers[i].NumberOfDoors}" +
                    $"Colour:{Rangers[i].Colour}");
            }

            Console.WriteLine("");

            Console.WriteLine("------------");
            Console.WriteLine("   Skoda    ");
            Console.WriteLine("------------");
            for (int i = 0; i < Skodas.Count; i++)
            {
                Console.WriteLine($"Skodas -- VinNumber:{Skodas[i].VinNumber}, Number Plate:{Skodas[i].NumberPlate}, Number Of doors:{Skodas[i].NumberOfDoors}" +
                    $"Colour:{Skodas[i].Colour}");
            }

            Console.WriteLine("");

            Console.WriteLine("------------");
            Console.WriteLine("    Honda   ");
            Console.WriteLine("------------");
            for (int i = 0; i < Hondas.Count; i++)
            {
                Console.WriteLine($"Hondas -- VinNumber:{Hondas[i].VinNumber}, Number Plate:{Hondas[i].NumberPlate}, Number Of doors:{Hondas[i].NumberOfDoors}" +
                    $"Colour:{Hondas[i].Colour}");
            }

            Console.Write("Press enter to exit back to menu...");
            Console.ReadLine();

            Menu(Rangers, Hondas, Skodas);
        }

        static void DisplayAllSkodas(List<RangeRover> Rangers, List<Honda> Hondas, List<Skoda> Skodas)
        {
            Console.WriteLine("------------");
            Console.WriteLine("   Skoda    ");
            Console.WriteLine("------------");
            for (int i = 0; i < Skodas.Count; i++)
            {
                Console.WriteLine($"Skodas -- VinNumber:{Skodas[i].VinNumber}, Number Plate:{Skodas[i].NumberPlate}, Number Of doors:{Skodas[i].NumberOfDoors}" +
                    $"Colour:{Skodas[i].Colour}");
            }

            Console.Write("Press enter to exit back to menu...");
            Console.ReadLine();

            Menu(Rangers, Hondas, Skodas);
        }

        static void DisplayAllRangers(List<RangeRover> Rangers, List<Honda> Hondas, List<Skoda> Skodas)
        {
            Console.WriteLine("------------");
            Console.WriteLine("Range Rovers");
            Console.WriteLine("------------");
            for (int i = 0; i < Rangers.Count; i++)
            {
                Console.WriteLine($"Range Rover -- VinNumber:{Rangers[i].VinNumber}, Number Plate:{Rangers[i].NumberPlate}, Number Of doors:{Rangers[i].NumberOfDoors}" +
                    $"Colour:{Rangers[i].Colour}");
            }
            Console.Write("Press enter to exit back to menu...");
            Console.ReadLine();

            Menu(Rangers, Hondas, Skodas);
        }

        static void DisplayAllHondas(List<RangeRover> Rangers, List<Honda> Hondas, List<Skoda> Skodas)
        {
            Console.WriteLine("------------");
            Console.WriteLine("    Honda   ");
            Console.WriteLine("------------");
            for (int i = 0; i < Hondas.Count; i++)
            {
                Console.WriteLine($"Hondas -- VinNumber:{Hondas[i].VinNumber}, Number Plate:{Hondas[i].NumberPlate}, Number Of doors:{Hondas[i].NumberOfDoors}" +
                    $"Colour:{Hondas[i].Colour}");
            }

            Console.Write("Press enter to exit back to menu...");
            Console.ReadLine();

            Menu(Rangers, Hondas, Skodas);
        }

        static void CreateANewCar(List<Skoda> Skodas, List<RangeRover> Rangers, List<Honda> Hondas)
        {
            Console.WriteLine("1.Skoda");
            Console.WriteLine("2.Ranger");
            Console.WriteLine("3.Honda");

            while (true)
            {
                int Choice = IntegerValidation("Please enter number of car brand yo want to add");
                switch(Choice)
                {
                    case 1:
                        Console.Clear();
                        Skodas = CreateASkoda(Skodas);//SKODA 
                        break;

                    case 2:
                        Console.Clear();
                        Rangers = CreateRanger(Rangers);//RANGERS
                        break;

                    case 3:
                        Console.Clear();
                        Hondas = CreateHonda(Hondas);//HONDAS
                        break;

                    default:
                        Choice = 0;
                        break;
                }
            }
        }

        static List<Skoda> CreateASkoda(List<Skoda> skodas)
        {
            Skoda temp = new Skoda();
            temp.VinNumber = UserCreatedVin();
            temp.Colour = UserColourSelect();
            temp.NumberOfDoors = UserNumberOfDoors();

            skodas.Add(temp);
            return skodas;
        }

        static List<RangeRover> CreateRanger(List<RangeRover> rangers)
        {
            RangeRover temp = new RangeRover();
            temp.VinNumber = UserCreatedVin();
            temp.Colour = UserColourSelect();
            temp.NumberOfDoors = UserNumberOfDoors();
            
            rangers.Add(temp);
            return rangers;
        }

        static List<Honda> CreateHonda(List<Honda> hondas)
        {
            Honda temp = new Honda();
            temp.VinNumber = UserCreatedVin();
            temp.Colour = UserColourSelect();
            temp.NumberOfDoors = UserNumberOfDoors();

            hondas.Add(temp);
            return hondas;
        }

        static string UserCreatedVin()
        {
            Console.Write("Please enter the vin: ");
            return Console.ReadLine();
        }

        static string UserColourSelect()
        {
            Console.Write("Please enter the colour of the car: ");
            return Console.ReadLine();
        }

        static int UserNumberOfDoors()
        {
            return IntegerValidation("Please enter number of doors");
        }

        static List<Skoda> CreateSkoda(List<Skoda> Skodas)
        {
            int NumberOfSkoda = rng.Next(0, 100);

            for (int i = 0; i < NumberOfSkoda;i++)
            {
                Skoda temp = new Skoda();
                Skodas.Add(CreateCar(temp));
            }
            
            return Skodas;
        }

        

        static List<RangeRover> CreateRangers(List<RangeRover> RangeRovers)
        {
            int NumberOfRRs = rng.Next(0, 100);

            for (int i = 0; i < NumberOfRRs; i++)
            {
                RangeRover temp = new RangeRover();
                RangeRovers.Add(CreateCar(temp));
            }

            return RangeRovers;
        }

        static List<Honda> CreateHondas(List<Honda> Hondas)
        {
            int NumberOfHondas = rng.Next(0, 100);

            for (int i = 0; i < NumberOfHondas; i++)
            {
                Honda temp = new Honda();
                Hondas.Add(CreateCar(temp));
            }

            return Hondas;
        }

        static Skoda CreateCar(Skoda skoda)
        {
            skoda.VinNumber = GetFalseVin();
            
            int rn = rng.Next(0, 100);
            if (rn > 50)
            skoda.NumberOfDoors = 2;
            else if (rn <= 100)
                skoda.NumberOfDoors = 4;
            skoda.NumberPlate = GetNumberPlate();

            return skoda;
        }
        
        static RangeRover CreateCar(RangeRover rangeRover)
        {
            rangeRover.VinNumber = GetFalseVin();

            int rn = rng.Next(0, 100);
            if (rn > 50)
                rangeRover.NumberOfDoors = 2;
            else if (rn <= 100)
                rangeRover.NumberOfDoors = 4;

            rangeRover.NumberPlate = GetNumberPlate();

            return rangeRover;
        }

        static Honda CreateCar(Honda honda)
        {
            honda.VinNumber = GetFalseVin();
            honda.NumberPlate = GetNumberPlate();

            int rn = rng.Next(0, 100);
            if (rn > 50)
                honda.NumberOfDoors = 2;
            else if (rn <= 100)
                honda.NumberOfDoors = 4;

            return honda;
        }


        static string GetNumberPlate()
        {
            string NumberPlate = string.Empty;
            string[] alphabetArray = 
                { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", 
                "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", 
                "U", "V", "W", "X", "Y", "Z" };

            bool numbersGiven = false;

            for (int i = 0; i <= 8; i++)
            {
                if (NumberPlate.Length < 3)
                    NumberPlate = NumberPlate + alphabetArray[rng.Next(0, 25)];
                else if (NumberPlate.Length > 2 && NumberPlate.Length < 5 && numbersGiven==false)
                {
                    NumberPlate = NumberPlate + rng.Next(51, 73).ToString();
                    numbersGiven = true;
                }
                //or 02 - 23
                else if (NumberPlate.Length == 5)
                    NumberPlate = NumberPlate + " ";
                else if (NumberPlate.Length > 5)
                    NumberPlate = NumberPlate + alphabetArray[rng.Next(0, 25)];
            }

            return NumberPlate;
        }

        static int IntegerValidation(string Message)
        {
            bool valid = false;


            while (valid != true)
            {
                Console.Write($"{Message}: ");
                string Choice = Console.ReadLine();

                try
                {
                    int intChoice = int.Parse(Choice);
                    return intChoice;
                } catch { }
            }

            return 0;
        }

        static string DetermineColour()
        {
            int Num = rng.Next(0, 5);

            switch (Num)
            {
                case 1:
                    return "Orange";
                    

                case 2:
                    return "Red";
                    

                case 3:
                    return "Purple";
                    

                case 4:
                    return "Blue";

                case 5:
                    return "White";
                    break;

                default:
                    return "Indigo";
                    break;
            }
        }
    }
}
