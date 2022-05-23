using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TestApp.Data.Models;
using TestApp.BusinessLogic;

namespace TestApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'controlsAppDBDataSet.Events' . Możesz go przenieść lub usunąć.
            //this.eventsTableAdapter.Fill(this.controlsAppDBDataSet.Events);

            userControl11.UserName = LoggedUser.UserName;

            List<Event> events = EventManagement.GetAllEventsForUserName(LoggedUser.UserName);
            foreach (Event ev in events)
            {
                userControl11.AddEventToCurrentEvents(ev.EventName, ev.Description, ev.Priority, ev.Date, ev.Time, ev.UserName);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void userControl11_TriedAddInvalid(object sender, EventArgs e)
        {
            MessageBox.Show("Invalid input");
        }

        private void userControl11_TriedAddValid(object sender, EventArgs e)
        {
            string eventName = userControl11.EVENT_NAME;
            string description = userControl11.DESCRIPTION;
            string priority = userControl11.PRIORITY;
            string date = userControl11.DATE;
            string time = userControl11.TIME;
            string userName = userControl11.UserName;
            EventManagement.AddEventToDB(eventName, description, priority, date, time, userName);
            MessageBox.Show("Changes saved");
            return;

        }

        //public void FillCeWithData()
    }
}
