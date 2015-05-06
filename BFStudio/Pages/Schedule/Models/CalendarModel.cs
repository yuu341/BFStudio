using BFStudio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BFStudio.Pages.Schedule.Models
{
    public class CalendarModel
    {
        public DateTime SelectedDate
        {
            get
            {
                return _SelectedDate;
            }
            set
            {
                _SelectedDate = value;
                InitMonthCalendar(value);
            }
        }
        private DateTime _SelectedDate;

        private void InitMonthCalendar(DateTime date)
        {
            for (int h = 0; h < 5; h++)
            {
                for (int w = 0; w < 7; w++)
                {
                    
                }
            }
        }


        public List<DBA_PLAN> Plans
        {
            set
            {
                _Plans = value;
            }
        }
        private List<DBA_PLAN> _Plans;

        public static CalendarModel CreateInstance(DateTime date)
        {
            CalendarModel init = new CalendarModel();

            init.SelectedDate = date;

            return init;
        }

    }

    public class DayPlan
    {
        public string Classes
        {
            get
            {
                string result = "";


                return result;
            }
        }

        public bool ContainMyPlan { get; set; }
        public bool ContainOtherPlan { get; set; }
    }
}