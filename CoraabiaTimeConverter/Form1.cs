using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoraabiaTimeConverter
{

    public partial class Form1 : Form
    {
        public static CoraabiaDate coraabian = new CoraabiaDate(DateTime.Now);
        public static DateTime human = DateTime.Now;
        public int corDayType = CoraabiaDate.DayTypeLight;
        //private Timer timer;

        public Form1()
        {
            InitializeComponent();
            /*timer = new Timer();
            timer.Interval = 1;
            timer.Tick += new EventHandler(TimerOnTick);
            timer.Start();*/
        }

        protected void TimerOnTick(object sender, EventArgs e)
        {
            actualizeCoraab();
            actualizeHuman();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            human = DateTime.Now;
            coraabian.setDate(human);
            actualizeHuman();
            actualizeCoraab();
        }

        private void actualizeHuman() 
        {
            day.Text = human.Day.ToString();
            month.Text = human.Month.ToString();
            year.Text = human.Year.ToString();
            hour.Text = human.Hour.ToString();
        }

        private void actualizeCoraab()
        {
            
            dayType.Text = coraabian.DayTypeText();
            corEra.Text = coraabian.Era.ToString();
            corYear.Text = coraabian.Year.ToString();
            corHour.Text = coraabian.Hour.ToString();
            gul.Text = "(Gul " + coraabian.Gul.ToString() + ")";
        }

        private void changeDayType_Click(object sender, EventArgs e)
        {
            if (coraabian.DayType == CoraabiaDate.DayTypeLight)
            {
                coraabian.DayType = CoraabiaDate.DayTypeHaze;
            }
            else
            {
                coraabian.DayType = CoraabiaDate.DayTypeLight;
            }
            actualizeCoraab();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            validateHuman();
            int y = Convert.ToInt32(year.Text);
            int m = Convert.ToInt32(month.Text);
            int d = Convert.ToInt32(day.Text);
            int h = Convert.ToInt32(hour.Text);
            human = new DateTime(y, m, d, h, 0, 0);
            coraabian = new CoraabiaDate(human);
            //actualizeHuman();
            actualizeCoraab();
            /*debug.Text = coraabian.ToString();
            debug.Text += coraabian.mess;*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            validateCoraab();
            int y = Convert.ToInt32(corYear.Text);
            int er = Convert.ToInt32(corEra.Text);
            int dt = CoraabiaDate.DayTypeLight;
            if (dayType.Text.Equals("Den světla"))
            {
                dt = CoraabiaDate.DayTypeLight;
            } else {
                dt = CoraabiaDate.DayTypeHaze;
            }
            int h = Convert.ToInt32(corHour.Text);
            coraabian = new CoraabiaDate(y,er,dt,h);
            human = coraabian.getDate();
            actualizeHuman();
            //actualizeCoraab();
            /*debug.Text = coraabian.ToString();
            debug.Text += coraabian.mess;*/
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            human = DateTime.Now;
            coraabian.setDate(human);
            actualizeCoraab();
            actualizeHuman();
        }

        private bool validateInput(TextBox input, int from, int to) {
            int num;
            bool canConvert = int.TryParse(input.Text, out num);
            if (canConvert) {
                if ((num >= from) && (num <= to))
                {
                    return true;
                }
            }
            input.Text = from.ToString();
            return false;
        }

        private void validateHuman()
        {
            validateInput(day, 1, DateTime.DaysInMonth(human.Year, human.Month));
            validateInput(month, 1, 12);
            validateInput(year, 1899, 9999);
            validateInput(hour, 0, 23);
        }

        private void validateCoraab()
        {
            validateInput(corYear, 3530, 56360);
            validateInput(corEra, 1, 8);
            if (coraabian.DayType == CoraabiaDate.DayTypeHaze)
            {
                validateInput(corHour, 0, 95);
            }
            else
            {
                validateInput(corHour, 0, 71);
            }
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void notifyIcon1_DoubleClick(object sender,
                                     System.EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void restore_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
        /*
        private void day_Validating(object sender, CancelEventArgs e)
        {
            if (!validateInput(day, 1, DateTime.DaysInMonth(human.Year, human.Month))) {
                e.Cancel = true;
            }
        }

        private void month_Validating(object sender, CancelEventArgs e)
        {
            if (!validateInput(month, 1, 12))
            {
                e.Cancel = true;
            } 
        }

        private void year_Validating(object sender, CancelEventArgs e)
        {
            if (!validateInput(year, 1900, 9999))
            {
                e.Cancel = true;
            } 
        }

        private void hour_Validating(object sender, CancelEventArgs e)
        {
            if (!validateInput(hour, 0, 23))
            {
                e.Cancel = true;
            } 
        }

        private void corEra_Validating(object sender, CancelEventArgs e)
        {
            if (!validateInput(corEra, 1, 8))
            {
                e.Cancel = true;
            } 
        }

        private void corHour_Validating(object sender, CancelEventArgs e)
        {
            if (coraabian.DayType == CoraabiaDate.DayTypeHaze)
            {
                validateInput(corHour, 0, 95);
                e.Cancel = true;
            }
            else
            {
                validateInput(corHour, 0, 71);
                e.Cancel = true;
            }
        }

        private void corYear_Validating(object sender, CancelEventArgs e)
        {
            if (!validateInput(corYear, 3530, 56360))
            {
                e.Cancel = true;
            }
        }*/

    }
}
