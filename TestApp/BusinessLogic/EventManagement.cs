using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestApp.Data.Models;
using TestApp.Data;

namespace TestApp.BusinessLogic
{
    public static class EventManagement
    {
        public static bool EventExists(string date, string time)
        {
            var dbContext = new TestApp.Data.AppContext();
            if (dbContext.Events.Find(date, time) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<Event> GetAllEventsForUserName(string username)
        {
            var dbContext = new TestApp.Data.AppContext();
            var events = (from e in dbContext.Events
                          where e.UserName == username
                          select e).ToList();
            return events;
        }

        public static void AddEventToDB(string eventName, string description, string priority, string date, string time, string userName)
        {
            var dbContext = new TestApp.Data.AppContext();
            Event ev = new Event();
            ev.EventName = eventName;
            ev.Description = description;
            ev.Priority = priority;
            ev.Date = date;
            ev.Time = time;
            ev .UserName = userName;
            dbContext.Events.Add(ev);
            dbContext.SaveChanges();
        }

        //public static bool 
    }
}
