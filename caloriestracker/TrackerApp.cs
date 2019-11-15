using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace caloriestracker
{
    static class TrackerApp
    {
        private static List<Tracker> Trackers = new List<Tracker>();
        private static List<Transaction> Transactions = new List<Transaction>();

        public static Tracker Createtracker(string username,
            TypeofMeal Meal, decimal CaloriesAmount)
        {
            var Tracker = new Tracker
            {
                Username = username,
                TypeofMeal = Meal,


            };
            if (CaloriesAmount > 0)
            {
                Tracker.Addition(CaloriesAmount);
            }
            Trackers.Add(Tracker);
                return Tracker;
        }



        public static IEnumerable<Tracker>
            GetTrackersbyusername(string username)
        {
            return Trackers.Where(a => a.username == username);
        }
        public static void Addition(string username, decimal amount)
        {

            var Tracker = Trackers.SingleOrDefault(a => a.username == username);

            if (Tracker == null)

            {
                //Throw exception
                return;
            }

            Tracker.Addition(amount);

            var Transaction = new Transaction
            {
                Username = Tracker.username,
                TransactionDate = DateTime.Now,
                Meal = TypeOfMeal.Breakfast,
                TotalCaloriesAmount = Tracker.CaloriesAmount

            };
            Transactions.Add(Transaction);
        }
    
        
    }
}
