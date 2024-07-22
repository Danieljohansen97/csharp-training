using System;
using System.Numerics;
using System.Collections.Generic;
using System.Threading;

namespace MyFirstProgram
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============");
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            Thread thread1 = new Thread(() => TimerUp("Timer #1"));
            Thread thread2 = new Thread(() => TimerDown("Timer #2"));
            

            Console.WriteLine("=============");

            Messages.Hello();
            Console.WriteLine("Connected: " + GetCurrentTime());

            bool running = true;

            var actions = new[]
            {
                "animals",
                "autoprops",
                "calculator",
                "cars",
                "classes",
                "countdown",
                "countup",
                "day",
                "domultiply",
                "enums",
                "generics",
                "gettersetter",
                "interfaces",
                "lists",
                "listofobjects",
                "multidimensionalarray",
                "name",
                "nested",
                "numberguesser",
                "rps",
                "sing",
                "threads",
                "quit"
            }; 

            while (running)
            {
                PrintActions(actions);
                String chosenAction = Console.ReadLine();

                switch (chosenAction)
                {
                    case "animals":
                        CreateAnimals();
                        break;
                    case "autoprops":
                        AutoProps();
                        break;
                    case "calculator":
                        Calculator();
                        break;
                    case "cars":
                        Cars();
                        break;
                    case "checkout":
                        CheckOut(10, 20, 30, 40);
                        break;
                    case "classes":
                        CreateObjects();
                        break;
                    case "countdown":
                        CountDown();
                        break;
                    case "countup":
                        CountUp();
                        break;
                    case "day":
                        TodayFunction();
                        break;
                    case "domultiply":
                        DoMultiply();
                        break;
                    case "enums":
                        Enums();
                        break;
                    case "generics":
                        Generics();
                        break;
                    case "gettersetter":
                        GetterSetter();
                        break;
                    case "interfaces":
                        Interfaces();
                        break;
                    case "lists":
                        Lists();
                        break;
                    case "listofobjects":
                        ListOfObjects();
                        break;
                    case "multidimensionalarray":
                        MultiDimensionalArray();
                        break;
                    case "name":
                        NameFunction();
                        break;
                    case "nested":
                        Nested();
                        break;
                    case "numberguesser":
                        NumberGuesser();
                        break;
                    case "rps":
                        RockPaperScissors();
                        break;
                    case "sing":
                        singHappyBirthday();
                        singHappyBirthday();
                        singHappyBirthday();
                        break;
                    case "threads":
                        thread1.Start();
                        thread2.Start();
                        break;
                    case "quit":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Please choose one of the available actions!");
                        break;
                }
            }
            Messages.Bye();
            Console.WriteLine("Disconnected: " + GetCurrentTime());
        }
        public static void TimerUp(String name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Timer #1 : {i} sec");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 completed!");
        }
        public static void TimerDown(String name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"Timer #2 : {i} sec");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 completed!");
        }
        public static void displayElements<Thing>(Thing[] array)
        {
            foreach (Thing element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
        static void Generics()
        {
            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            String[] stringArray = { "1", "2", "3" };

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);
        }
        static double Volume(PlanetRadius radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }
        static void Enums()
        {
            Console.WriteLine(Planets.Pluto + " is a planet");
            Console.WriteLine(Planets.Pluto + " is planet #" + (int)Planets.Pluto);
            Console.WriteLine(Planets.Mercury + " is a planet");
            Console.WriteLine(Planets.Mercury + " is planet #" + (int)Planets.Mercury);
            
            Console.WriteLine("=====");

            String name = PlanetRadius.Earth.ToString();
            Console.WriteLine("Planet: " + name);

            int radius = (int)PlanetRadius.Earth;
            Console.WriteLine("Radius: " + radius + "km");
            
            double volume = Volume(PlanetRadius.Earth);
            Console.WriteLine("Volume: " + volume + "sqkm");

            Console.WriteLine("=====");
        }
        static void AutoProps()
        {
            Tank tank = new Tank("Abrahams");

            Console.WriteLine(tank.Model);
        }
        static void GetterSetter()
        {
            Rocket rocket = new Rocket(120);
            Console.WriteLine("Initial rocket speed: " + rocket.Speed);

            rocket.Speed = 500;
            Console.WriteLine("Try setting speed: 500");

            Console.WriteLine("Current rocket speed: " + rocket.Speed);
        }
        static void ListOfObjects()
        {
            List<Player> players = new List<Player>();

            players.Add(new Player("Chad"));
            players.Add(new Player("Brad"));
            players.Add(new Player("Dad"));

            foreach (Player player in players)
            {
                // Requires ToString() override in object to work
                Console.WriteLine(player);
            }
        }
        static void Lists()
        {
            List<String> food = new List<String>();

            food.Add("fries");
            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");

            //food.Remove("fries");
            food.Sort();
            //food.Reverse();
            //food.Clear();
            food.Insert(0, "sushi");
            Console.WriteLine("Size of foodList: " + food.Count);
            Console.WriteLine("Index of pizza: " + food.IndexOf("pizza"));
            Console.WriteLine("Last index of fries: " + food.LastIndexOf("fries"));
            Console.WriteLine("foodList contains sushi?: " + food.Contains("sushi"));

            Console.WriteLine("-- foodList --");
            foreach  (String item in food)
            {
                Console.WriteLine(item);
            }
            // Convert list to array
            Console.WriteLine("-- foodArray --");
            String[] foodArray = food.ToArray();
            foreach (String item in foodArray)
            {
                Console.WriteLine(item);
            }
        }
        static void Interfaces()
        {
            Rabbit rabbit = new();
            Hawk hawk = new();
            Fish fish = new();

            hawk.Hunt();
            rabbit.Flee();
            fish.Flee();
            fish.Hunt();
        }
        static void CreateAnimals()
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();
        }
        public static Car CopyCar(Car car)
        {
            return new Car(car.make, car.model, car.year, car.color);
        }
        public static void ChangeColor(Car car, String color)
        {
            car.color = color;
        }
        static void CreateObjects()
        {
            // Basic class, with public fields and methods
            Human human1 = new Human("Rick", 65);
            Human human2 = new Human("Morty", 16);

            // Array of objects
            Car[] garage = new Car[4];

            Car car1 = new Car("Ford", "Mustang", 2024, "Red");
            Car car2 = new Car("Chevy", "Corvette", 2022, "Yellow");
            Car car3 = new Car("Volkswagen", "Passat", 2017, "White");

            ChangeColor(car1, "Bronze");
            ChangeColor(car2, "Silver");
            ChangeColor(car3, "Golden");

            Car car4 = CopyCar(car3);

            garage[0] = car1;
            garage[1] = car2;
            garage[2] = car3;
            garage[3] = car4;

            // Array of anonymous objects
            Car[] garage2 =
            {
                new Car("Ford", "Mustang", 2024, "Red"),
                new Car("Chevy", "Corvette", 2022, "Yellow"),
                new Car("Volkswagen", "Passat", 2017, "White")
            };

            // Console.WriteLine(garage[0].model);
            // Console.WriteLine(garage[1].model);
            // Console.WriteLine(garage[2].model);
            Console.WriteLine("=== ToString() ===");
            Console.WriteLine(car4); // This implicitly calls car4.ToString();
            Console.WriteLine("=== END of ToString() ===");
            foreach (Car car in garage)
            {
                Console.WriteLine("Garage 1: " + car.make + car.model + " " + car.color);
            }
            foreach (Car car in garage2)
            {
                Console.WriteLine("Garage 2: " + car.make + car.model);
            }

            Motorcycle motorcycle = new Motorcycle();
            Boat boat = new Boat();

            Pizza pizza = new Pizza("Italian");
            Pizza pizza2 = new Pizza("Italian", "Tomato Sauce");
            Pizza pizza3 = new Pizza("Italian", "Tomato Sauce", "Mozarella");
            Pizza pizza4 = new Pizza("Italian", "Tomato Sauce", "Mozarella", "Pepperoni");

            human1.Eat();
            human1.Sleep();
            human2.Eat();
            human2.Sleep();
            car1.Drive();
            car2.Drive();
            Console.WriteLine(Car.numberOfCars);
            Car.StartRace();
            Console.WriteLine("Car3 speed: " + car3.speed);
            Console.WriteLine("Car3 wheels: " + car3.wheels);
            car3.Go();
            Console.WriteLine("Motorcycle speed: " + motorcycle.speed);
            Console.WriteLine("Motorcycle wheels: " + motorcycle.wheels);
            motorcycle.Go();
            Console.WriteLine("Boat speed: " + boat.speed);
            Console.WriteLine("Boat wheels: " + boat.wheels);
            boat.Go();
            // End of Basic class usage

            // Polymorphism
            Vehicle[] vehicles = { car1, motorcycle, boat };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }
        }
        static void MultiDimensionalArray()
        {
            String[,] parkingLot = 
            {
                {
                    "Mustang", "F-150", "Explorer"
                },
                {
                    "Corvette", "Camaro", "Silverado"
                },
                {
                    "Corolla", "Camry", "Rav4"
                }
            };

            parkingLot[0, 2] = "Fusion";
            parkingLot[2, 0] = "Tacoma";
            /*
            foreach (String car in parkingLot)
            {
                Console.WriteLine(car);
            }
            */
            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static DateTime GetCurrentTime()
        {
            DateTime time = DateTime.Now;
            return time;
        }

        static double CheckOut(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices) 
            { 
                total += price;
            }

            Console.WriteLine("Total: " + total);
            return total;
        }
        static void DoMultiply()
        {
            double x;
            double y;
            double result;

            Console.WriteLine("Enter number 1: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);
            Console.WriteLine($"{x} * {y} = " + result);
        }
        static double Multiply(double x, double y)
        {
            return x * y;
        }
        static void Calculator()
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                try
                {
                    Console.Clear();
                    Console.WriteLine("==================");
                    Console.WriteLine("Calculator Program");
                    Console.WriteLine("==================");

                    Console.Write("Enter first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter an operator: ");
                    Console.WriteLine("\t+ : Add");
                    Console.WriteLine("\t- : Subtract");
                    Console.WriteLine("\t* : Multiply");
                    Console.WriteLine("\t/ : Divide");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please enter valid numbers!");
                } 
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Result: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid operator");
                        break;
                }
                Console.WriteLine("Would you like to continue? (Y = Yes, N = No): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye!");
        }
        static void RockPaperScissors()
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "SCISSORS")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                }
                Console.WriteLine("Would you like to play again (Y/N)?");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks for playing!");
        }
        static void Cars()
        {
            Console.Clear();
            String[] cars = { "Volkswagen", "BMW", "Audi", "Mercedes", "Corvette" };

            //String[] cars = new string[3];

            //cars[0] = "Tesla";
            //cars[1] = "Audi";
            //cars[2] = "BMW";

            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}


            // foreach loop = a simpler way to iterate over an array, but it's less flexible.
            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }
        }
        static void NumberGuesser()
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low!");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks for playing! ... I guess");
        }
        static void Nested()
        {
            Console.Write("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("What symbol?: ");
            char symbol = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        static void CountDown()
        {
            Console.WriteLine("What do you want me to count down from?");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for (int i = number; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Happy New Year!");
        }
        static void CountUp()
        {
            try
            {
                Console.WriteLine("How much do you want me to count up to?");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter only numbers please");
            }

        }
        static void NameFunction() 
        {
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Hello " + name);
        }   
        static void TodayFunction()
        {
            Console.WriteLine("What day is it today?");
            String day = Console.ReadLine();
            Console.Clear();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("It's Monday!");
                    break;
                case "Tuesday":
                    Console.WriteLine("It's Tuesday!");
                    break;
                case "Wednesday":
                    Console.WriteLine("It's Wednesday!");
                    break;
                case "Thursday":
                    Console.WriteLine("It's Thursday!");
                    break;
                case "Friday":
                    Console.WriteLine("It's Friday!");
                    break;
                case "Saturday":
                    Console.WriteLine("It's Saturday!");
                    break;
                case "Sunday":
                    Console.WriteLine("It's Sunday!");
                    break;
                default:
                    Console.WriteLine(day + " is not a day");
                    break;
            }

        }
        static void PrintActions(String[] actions)
        {
            Console.WriteLine("Available actions: ");

            Console.WriteLine("==========");
            foreach (var action in actions)
            {
                Console.WriteLine("- " + action);
            }
            Console.WriteLine("==========");
            Console.Write("Action: ");
        }
        static void singHappyBirthday()
        {
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine("Happy Birthday dear YOU!");
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine();
        }
    }
}