using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary2
{
    public partial class UserControl1: UserControl
    {
        private string _priority_low = "Low"; // Green
        private string _priority_regular = "Regular"; // Orange
        private string _priority_high = "High"; // Red

        private int _dayDifference { get; set; }

        // public properties to add to db in test app
        public string EVENT_NAME { get; set; }
        public string PRIORITY { get; set; }
        public string DESCRIPTION { get; set; }
        public string DATE { get; set; }
        public string TIME { get; set; }


        //public DataSet DataSet { get; set; }
        //public DefaultBindingPropertyAttribute DefaultBindingProperty { get; set; }
        //public BindingSource BindingSource { get; set; }

        public string UserName { get; set; }
        private List<CurrentEvent> CurrentEvents { get; set; }


        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            CurrentEvents = new List<CurrentEvent>();

            _dayDifference = 0;
            Previous_button.Enabled = false;
            // add columns starting from today
            AddColumnsForWeek(0);

            // add rows names
            AddRowsForWeek();

            // Add priorities to choose from
            Priority_comboBox.Items.Add(_priority_low);
            Priority_comboBox.Items.Add(_priority_regular);
            Priority_comboBox.Items.Add(_priority_high);
        }

        private void AddColumnsForWeek(int x) // x - number of days to start count from (today + x days)
        {
            // add columns names
            Week_dataGridView.Columns.Add("Time", "Time [hh:mm:ss]");
            Week_dataGridView.Columns[0].ReadOnly = true;
            for (int i = 0; i < 7; i++)
            {
                string day = DateTime.Today.AddDays(i+x).ToShortDateString();
                Week_dataGridView.Columns.Add(day, day);
            }
        }

        public void AddRowsForWeek()
        {
            // add rows names
            var endTime = DateTime.Now.Date.TimeOfDay;
            TimeSpan ts = new TimeSpan(0, 30, 0);
            for (int i = 0; i < 48; i++)
            {
                Week_dataGridView.Rows.Add(endTime.ToString());
                endTime = endTime.Add(ts);
                //endTime = DateTime.Now.AddMinutes(i * 30);
            }
        }
        private void Week_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;
            if (column > 0 && row >= 0)
            {
                Date_textBox.Text = Week_dataGridView.Columns[column].Name;
                Time_textBox.Text = Week_dataGridView.Rows[row].Cells[0].Value.ToString();

                // check if event on this day exists
                CurrentEvent currEvent = FindEventByDateTime(Date_textBox.Text, Time_textBox.Text);
                if (currEvent == null)
                {
                    // clear data
                    EventName_textBox.Clear();
                    richTextBox1.Clear();
                    Priority_comboBox.SelectedIndex = -1;
                }
                else
                {
                    // Read existing event
                    EventName_textBox.Text = currEvent.EventName;
                    for (int i = 0; i < Priority_comboBox.Items.Count; i++)
                    {
                        if (Priority_comboBox.Items[i].ToString() == currEvent.Priority)
                        {
                            Priority_comboBox.SelectedIndex = i;
                        }
                    }
                    richTextBox1.Text = currEvent.Description;
                }
            }
        }

        /// /// /// 
        //To create the event
        public event EventHandler TriedAddInvalid;

        protected virtual void TriedToAddInvalidEvent(EventArgs e)
        {
            EventHandler handler = TriedAddInvalid;
            handler?.Invoke(this, e);
        }
        /// /// /// 
        /// /// /// 
        //To create the event
        public event EventHandler TriedAddValid;

        protected virtual void TriedToAddValidEvent(EventArgs e)
        {
            EventHandler handler = TriedAddValid;
            handler?.Invoke(this, e);
        }
        /// /// /// 


        private void Add_button_Click(object sender, EventArgs e)
        {
            string eventName = EventName_textBox.Text;
            string priority = Priority_comboBox.Text;
            string description = richTextBox1.Text;
            string date = Date_textBox.Text;
            string time = Time_textBox.Text;

            if (eventName.Trim().Length == 0 || priority.Trim().Length == 0 || description.Trim().Length == 0 || date.Trim().Length == 0 || time.Trim().Length == 0)
            {
                // invalid Data - send a event
                TriedToAddInvalidEvent(e);
                return;
            }
            else
            {
                // add or update the event
                CurrentEvent currentEvent = FindEventByDateTime(date, time);
                if (currentEvent != null)
                {
                    CurrentEvents.Remove(currentEvent);
                    // throw event on deleting event !!!!!!!!!
                }
                AddEventToCurrentEvents(eventName, description, priority, date, time, UserName);
                // find selected row index
                int rowIndex = FindRowIndexByTime(time);
                // find selected column index
                int columnIndex = FindColumnIndexByDate(date);
                // change back color
                ChangeCellColorByPriority(priority, rowIndex, columnIndex);

                // Update cell content
                Week_dataGridView.Rows[rowIndex].Cells[columnIndex].Value = eventName;

                // Update public properties to enable creating instance in test app
                EVENT_NAME = eventName;
                PRIORITY = priority;
                DESCRIPTION = description;
                DATE = date;
                TIME = time;

                UpdateDb(e);
                TriedToAddValidEvent(e);
                
            }
        }

        public void AddEventToCurrentEvents(string eventName, string description, string priority, string date, string time, string username)
        {
            CurrentEvent newEvent = new CurrentEvent();
            newEvent.EventName = eventName;
            newEvent.Description = description;
            newEvent.Priority = priority;
            newEvent.Date = date;
            newEvent.Time = time;

            CurrentEvents.Add(newEvent);
            FillWeekWithCurrentEvents();
        }

        private CurrentEvent FindEventByDateTime(string date, string time)
        {
            foreach (CurrentEvent currentEvent in CurrentEvents)
            {
                if (currentEvent.Date == date && currentEvent.Time == time)
                {
                    return currentEvent;
                }
            }
            return null;
        }

        private void FillWeekWithCurrentEvents()
        {
            foreach (var currentEvent in CurrentEvents)
            {
                DateTime eventDate = Convert.ToDateTime(currentEvent.Date);
                DateTime weekStart = Convert.ToDateTime(Week_dataGridView.Columns[1].Name);
                DateTime weekEnd = Convert.ToDateTime(Week_dataGridView.Columns[7].Name);
                if (eventDate <= weekEnd && eventDate >= weekStart)
                {
                    FillCellWithData(currentEvent.Date, currentEvent.Time, currentEvent.EventName, currentEvent.Priority);
                }
            }
        }

        private int FindRowIndexByTime(string time)
        {
            // find selected row index
            for (int row = 0; row < Week_dataGridView.RowCount; row++)
            {
                if (Week_dataGridView.Rows[row].Cells[0].Value.ToString() == time)
                {
                    return row;
                }
            }
            return -1;
        }

        private int FindColumnIndexByDate(string date)
        {
            // find selected column index
            for (int column = 0; column < Week_dataGridView.ColumnCount; column++)
            {
                if (Week_dataGridView.Columns[column].Name == date)
                {
                    return column;
                }
            }
            return -1;
        }

        private void ChangeCellColorByPriority(string priority, int row, int col)
        {
            // change back color
            if (priority == _priority_low)
            {
                Week_dataGridView.Rows[row].Cells[col].Style.BackColor = Color.Green;
            }
            else if (priority == _priority_regular)
            {
                Week_dataGridView.Rows[row].Cells[col].Style.BackColor = Color.Orange;
            }
            else
            {
                Week_dataGridView.Rows[row].Cells[col].Style.BackColor = Color.Red;
            }
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            Week_dataGridView.Rows.Clear();
            Week_dataGridView.Columns.Clear();
            AddColumnsForWeek(_dayDifference + 7);
            AddRowsForWeek();
            _dayDifference += 7;
            Previous_button.Enabled = true;
            FillWeekWithCurrentEvents();
        }

        private void Previous_button_Click(object sender, EventArgs e)
        {
            Week_dataGridView.Rows.Clear();
            Week_dataGridView.Columns.Clear();
            AddColumnsForWeek(_dayDifference - 7);
            AddRowsForWeek();
            _dayDifference -= 7;
            if (_dayDifference == 0)
            {
                Previous_button.Enabled = false;
            }
            FillWeekWithCurrentEvents();
        }

        private void FillCellWithData(string date, string time, string eventName, string priority)
        {
            int row = FindRowIndexByTime(time);
            int col = FindColumnIndexByDate(date);
            ChangeCellColorByPriority(priority, row, col);
            Week_dataGridView.Rows[row].Cells[col].Value = eventName;
        }

        /// /// /// 
        //To create the event
        public event EventHandler EventDeleted;

        protected virtual void DeletedEvent(EventArgs e)
        {
            EventHandler handler = EventDeleted;
            handler?.Invoke(this, e);
        }
        /// /// /// 
        /// 
        /// /// /// 
        //To create the event
        public event EventHandler DeleteEvent;

        protected virtual void ClearDB(EventArgs e)
        {
            EventHandler handler = DeleteEvent;
            handler?.Invoke(this, e);
        }
        /// /// ///
        /// /// /// /// 
        //To create the event
        public event EventHandler FillDb;

        protected virtual void FillDB(EventArgs e)
        {
            EventHandler handler = FillDb;
            handler?.Invoke(this, e);
        }
        /// /// ///

        private void Delete_button_Click(object sender, EventArgs e)
        {
            int row = FindRowIndexByTime(Time_textBox.Text);
            int col = FindColumnIndexByDate(Date_textBox.Text);

            if (row >= 0 && col > 0)
            {
                Week_dataGridView.Rows[row].Cells[col].Value = "";
                Week_dataGridView.Rows[row].Cells[col].Style.BackColor = Color.White;
                EventName_textBox.Clear();
                Priority_comboBox.SelectedIndex = -1;
                richTextBox1.Clear();
                for (int i = 0; i < CurrentEvents.Count; i++)
                {
                    if (CurrentEvents[i].Date == Date_textBox.Text && CurrentEvents[i].Time == Time_textBox.Text)
                    {
                        CurrentEvents.RemoveAt(i);
                        UpdateDb(e);
                        TriedToAddValidEvent(e);
                        return;
                    }
                }
            }
        }

        private void UpdateDb(EventArgs e)
        {
            ClearDB(e);
            foreach (var ev in CurrentEvents)
            {
                EVENT_NAME = ev.EventName;
                PRIORITY = ev.Priority;
                DESCRIPTION = ev.Description;
                DATE = ev.Date;
                TIME = ev.Time;
                FillDB(e);
            }
            //FillWeekWithCurrentEvents();
        }
    }
}
