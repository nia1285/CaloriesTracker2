using System;
using System.Collections.Generic;
using System.Text;

namespace caloriestracker
    
{
    enum DaysofWeek
    {
     Monday,
     Tuesday,
     Wednesday,
     Thursday,
     Friday,
     Saturday,
     Sunday

    }
    enum TypeofMeal {Breakfast,Lunch,Dinner}

    /// <summary>
    /// this is a tracker where user can enter the type
    /// of food and calories intake daily
    /// </summary>
    class Tracker
    {
        internal object dayOfWeek;
        internal readonly string username;
        #region Properties
        /// <summary>
        /// Name of the user
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// days of the week
        /// </summary>
        public DaysofWeek DayOfWeek { get; set; }
        /// <summary>
        /// Calories amount user enter 
        /// </summary>
        public decimal CaloriesAmount { get; set; }
        /// <summary>
        /// User can enter the type of food they eat
        /// </summary>
        public TypeofMeal Meal { get; set; }
        /// <summary>
        /// Total calories amount user enter for the day
        /// </summary>
        public decimal TotalCalories { get; set; }
        /// <summary>
        /// the date user enters calories
        /// </summary>
        public DateTime CreatedDate { get; set; }
        public TypeofMeal TypeofMeal { get; internal set; }
        public object Typeofmeal { get; internal set; }
        #endregion


        #region Constructor
        public Tracker()   
        {
            CreatedDate = DateTime.Now;

        }
        #endregion
        #region Methods
        /// <summary>
        /// Add calories amount to the Tracker
        /// </summary>
        /// <param name="amount">Amount to add</param>
        public void Addition(decimal amount)
        {
            TotalCalories = CaloriesAmount + CaloriesAmount;
        }

        
        

        #endregion
    }
}

