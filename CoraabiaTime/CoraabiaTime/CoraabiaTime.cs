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
    public partial class CoraabiaTime : Form
    {
        public CoraabiaTime()
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
            human.Append("Rok: ");
            human.Append(time.Year.ToString());
            human.Append("\nMěsíc: ");
            human.Append(time.Month.ToString());
            human.Append("\nDen: ");
            human.Append(time.Day.ToString());
            human.Append(" (");
            human.Append(time.DayOfWeek.ToString());
            human.Append(") ");
            human.Append(": ");
            human.Append(time.Hour.ToString());
            human.Append(":");
            human.Append(time.Minute.ToString());
            human.Append(":");
            human.Append(time.Second.ToString());
            coraab.Append("Gul: ");
            coraab.Append(coraaTime.Gul.ToString());
            coraab.Append("\nYear: ");
            coraab.Append(coraaTime.Year.ToString());
            coraab.Append("\nEra: ");
            coraab.Append(coraaTime.Era.ToString());
            coraab.Append("\nDayType: ");
            coraab.Append(coraaTime.DayType.ToString());
            coraab.Append("\nHour: ");
            coraab.Append(coraaTime.Hour.ToString());
            coraab.Append("\nMess: ");
            coraab.Append(coraaTime.message);
            /*sb.Append("Year: ");
            sb.Append(cas.Year.ToString());
            sb.Append("\nMonth: ");
            sb.Append(cas.Month.ToString());
            sb.Append("\nDay: ");
            sb.Append(cas.Day.ToString());
            sb.Append("\nHour: ");
            sb.Append(cas.Hour.ToString());
            sb.Append("\nMinute: ");
            sb.Append(cas.Minute.ToString());
            sb.Append("\nSecond: ");
            sb.Append(cas.Second.ToString());
            sb.Append("\nMillisecond: ");
            sb.Append(cas.Millisecond.ToString());
            sb.Append("\nDayOfWeek: ");
            sb.Append(cas.DayOfWeek.ToString());
            sb.Append("\nDayOfYear: ");
            sb.Append(cas.DayOfYear.ToString());
            sb.Append("\nTicks: ");
            sb.Append(cas.Ticks.ToString());*/
            timeLabel.Text = human.ToString();
            coraabianTimeLabel.Text = coraab.ToString();

        }
               
    }
}
