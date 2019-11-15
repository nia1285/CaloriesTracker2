using System;
using System.Collections.Generic;
using System.Text;

namespace caloriestracker
{
    enum TypeOfMeal
        {Breakfast, Lunch, Dinner }
    class Transaction
    {
        public string Username { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public TypeOfMeal Meal { get; set; }
        public decimal TotalCaloriesAmount { get; set; }
        public virtual Tracker Tracker { get; set; }

    }
}
