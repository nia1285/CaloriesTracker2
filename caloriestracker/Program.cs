using caloriestracker;

using System;



namespace caloriestracker

{

    class Program

    {

        public static decimal CaloriesAmount { get; private set; }
        public static decimal amount { get; private set; }

        static void Main(string[] args)

        {

            //instance of a Tracker == Object

            var Tracker = TrackerApp.Createtracker("Username", TypeofMeal.Breakfast, 200);





            Console.WriteLine("Hello");



            while (true)

            {

                Console.WriteLine("0. exit");

                Console.WriteLine("1. create tracker");

                Console.WriteLine("2. addition");

                Console.WriteLine("3. print all tracker");





                var option = Console.ReadLine();

                switch (option)

                {

                    case "0":

                        Console.WriteLine("Thank You");

                        return;

                    case "1":

                        Console.Write("Username:");

                        var username = Console.ReadLine();

                        Console.WriteLine("TypeofMeal: ");

                        //convert enum to array

                        var mealtype = Enum.GetNames(typeof(TypeofMeal));

                        //loop through the array and print out

                        for (var i = 0; i < mealtype.Length; i++)

                        {

                            Console.WriteLine($"{i}. {mealtype[i]}");

                        }

                        var TypeofMeal = Enum.Parse<TypeofMeal>(Console.ReadLine());

                        Console.Write("Initial Caloriesamount: ");

                        var CaloriesAmount = Convert.ToDecimal(Console.ReadLine());

                        var tracker = TrackerApp.Createtracker(username, TypeofMeal, CaloriesAmount);

                        Console.WriteLine($"CT: {Tracker.Username}, CD: {Tracker.CreatedDate}, Meal: {Tracker.TypeofMeal},$CA: {Tracker.CaloriesAmount:1234}");



                        break;

                    case "2":
                        Console.Write("username: ");

                        var trackers = Console.ReadLine();

                        TrackerApp.GetTrackersbyusername("username");

                        foreach (var myTracker in trackers)

                        {

                            Console.WriteLine($"CT: {Tracker.Username}, CD: {Tracker.CreatedDate}," +
                                $" Meal: {Tracker.TypeofMeal},$CA: {Tracker.CaloriesAmount:1234}");

                        }
                        Console.Write("username: ");
                        username = Console.ReadLine();
                        Console.Write("Amount to Add: ");
                        amount = Convert.ToDecimal(Console.ReadLine());
                        TrackerApp.Addition("username, Amount");

                        Console.WriteLine("Calories Amount has been added");


                        break;

                    case "3":

                        Console.Write("username: ");

                        trackers = Console.ReadLine();

                        TrackerApp.GetTrackersbyusername("username");

                        foreach (var myTracker in trackers)

                        {

                            Console.WriteLine($"CT: {Tracker.Username}, CD: {Tracker.CreatedDate}, Meal: {Tracker.TypeofMeal},$CA: {Tracker.CaloriesAmount:1234}");

                        }

                        break;

                    default:

                        Console.Write("Please select from the valid option");

                        break;

                }











            }

        }

    }

}



