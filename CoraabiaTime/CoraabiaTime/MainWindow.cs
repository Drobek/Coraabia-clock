using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoraabiaTime
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void actualizeBtn_Click(object sender, EventArgs e)
        {
            CoraabiaDate coraaTime = new CoraabiaDate();
            DateTime time = DateTime.Now;
            StringBuilder human = new StringBuilder();
            StringBuilder coraab = new StringBuilder();

            coraaTime.setDate(time);
            human.Append(time.Day.ToString());
            human.Append(".");
            human.Append(time.Month.ToString());
            human.Append(". ");
            human.Append(time.Year.ToString());
            human.Append(" (");
            human.Append(time.DayOfWeek.ToString());
            human.Append("");
            human.Append(time.Hour.ToString());
            human.Append(":");
            human.Append(time.Minute.ToString());
            human.Append(":");
            human.Append(time.Second.ToString());
            human.Append(")");
            humanTimeLbl.Text = human.ToString();
            coraabLongLbl.Text = coraaTime.fullString();
            coraabianShortLbl.Text = coraaTime.ToString();
            test.Text = coraaTime.message;

            
        }

        private void humanDatePicker_ValueChanged(object sender, EventArgs e)
        {
            CoraabiaDate coraaTime = new CoraabiaDate();
            DateTime time = humanDatePicker.Value;
            StringBuilder human = new StringBuilder();
            StringBuilder coraab = new StringBuilder();

            coraaTime.setDate(time);
            human.Append(time.Day.ToString());
            human.Append(".");
            human.Append(time.Month.ToString());
            human.Append(". ");
            human.Append(time.Year.ToString());
            human.Append(" (");
            human.Append(time.DayOfWeek.ToString());
            human.Append("");
            human.Append(time.Hour.ToString());
            human.Append(":");
            human.Append(time.Minute.ToString());
            human.Append(":");
            human.Append(time.Second.ToString());
            human.Append(")");
            humanTimeLbl.Text = human.ToString();
            coraabLongLbl.Text = coraaTime.fullString();
            coraabianShortLbl.Text = coraaTime.ToString();
            test.Text = coraaTime.message;
        }

    }
}
