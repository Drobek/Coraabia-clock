using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoraabiaTimeConverter
{
    public class CoraabiaDate
    {
        public static int DayTypeLight = 1;
        public static int DayTypeHaze = 2;
        public int Gul = 710;
        public int Year = 4261;
        public int Era = 1;
        public int DayType = DayTypeLight; //podle dne v týdnu buď den šera (H=Haze) nebo den světla (L=Light)
        public int Hour = 0; //coraabské hodiny. Den světla (L) má 96 hodin, den šera 72 hodin. 
        //Dohromady odpovídají jednomu pozemskému týdnu
        public DateTime actTime = new DateTime(); // now pokud neni nastaveno jinak
        public static DateTime startTime = new DateTime(2011, 12, 5, 0, 0, 0); // 11.10.2011 00:00
        public string mess;


        public CoraabiaDate(DateTime dt) {
            setDate(dt);
        }

        public CoraabiaDate(int year, int era, int dayType, int hour) {
            Hour = hour;
            DayType = dayType;
            Era = era;
            Year = year;
            Gul = year / 6;
            actualizeDate();
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Hour.ToString());
            if (DayType == DayTypeLight)
            {
                sb.Append(" L ");
            }
            else
            {
                sb.Append(" H ");
            }
            sb.Append(Era.ToString());
            sb.Append(" ");
            sb.Append(Year.ToString());
            return sb.ToString();
        }

        public void actualizeDate() {
            DateTime dt = new DateTime(2011, 12, 5, 0, 0, 0);
            mess += "\ndt1: " + dt.ToString();
            dt = dt.AddHours(Hour);
            mess += "\ndt2: " + dt.ToString();
            dt = dt.AddDays(7 * (Era - 1));
            mess += "\ndt3: " + dt.ToString();
            if (DayType == DayTypeHaze) {
                mess += "\nPridany 4 dny";
                dt = dt.AddDays(4);
                mess += "\ndt4: " + dt.ToString();
            }
            dt = dt.AddDays(7 * 8 * (Year - 4261));
            mess += "\ndt5: " + dt.ToString();
            actTime = dt;
            mess += "\n"+actTime.ToString();
        }

        public void setDate(DateTime dt)
        {
            actTime = dt;
            setTime();
        }

        public DateTime getDate()
        {
            actualizeDate();
            return actTime;
        }

        public void setTime()
        {
            setHour();
            setDayType();
            setEra();
            setYear();
            setGul();
        }

        private TimeSpan elapsedTime()
        {
            return actTime - startTime;
        }

        private void setHour()
        {
            DayOfWeek actDay = actTime.DayOfWeek;
            switch (actDay)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Friday:
                    Hour = actTime.Hour;
                    break;
                case DayOfWeek.Tuesday:
                case DayOfWeek.Saturday:
                    Hour = actTime.Hour + 24;
                    break;
                case DayOfWeek.Wednesday:
                case DayOfWeek.Sunday:
                    Hour = actTime.Hour + 48;
                    break;
                case DayOfWeek.Thursday:
                    Hour = actTime.Hour + 72;
                    break;
                default: // nemělo by k němu dojít jsou vyjmenované všechny dny
                    Hour = actTime.Hour;
                    break;
            }
        }

        private void setDayType()
        {
            DayOfWeek actDay = actTime.DayOfWeek;
            switch (actDay)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                    DayType = DayTypeLight;
                    break;
                case DayOfWeek.Friday:
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    DayType = DayTypeHaze;
                    break;
                default: // nemělo by k němu dojít jsou vyjmenované všechny dny
                    DayType = 1;
                    break;
            }
        }

        private void setEra()
        {
            TimeSpan ts = elapsedTime();
            int secs = Convert.ToInt32(Math.Sign(ts.TotalMilliseconds));
            int hours = Convert.ToInt32(ts.TotalHours);
            mess = mess + "\n secs " + secs.ToString() + "\ndays" + hours.ToString();
            if (secs >= 0)
            {
                Era = (((hours / (7 * 24)) % 8) + 1);
                mess += "secs>0, Era: " + Era.ToString();
            }
            else {
                Era = (8 + ((hours / (7 * 24)) % 8));
                mess += "secs<0, Era: " + Era.ToString();
            }
            mess = mess + "\n ((days / 7) % 8) + 1 = " + (((hours / 7) % 8) + 1).ToString();
            mess = mess + "\n 8 + ((days / 7) % 8) = " + (8 + ((hours / 7) % 8)).ToString();
            mess = mess + "\nEra: " + Era.ToString();
        }

        private void setYear()
        {
            TimeSpan ts = elapsedTime();
            int secs = Convert.ToInt32(Math.Sign(ts.TotalMilliseconds));
            int days = Convert.ToInt32(ts.TotalDays);
            mess = mess + "\n secs " + secs.ToString() + "\ndays" + days.ToString();
            if (secs >= 0)
            {
                Year = (days / (7 * 8)) + 4261;
            }
            else {
                Year = 4260 + (days / (7 * 8));
            }
            mess = mess + "\n (days / (7 * 8)) + 4261 = " + ((days / (7 * 8)) + 4261).ToString();
            mess = mess + "\n 4260 + (days / (7 * 8)) = " + (4260 + (days / (7 * 8))).ToString();
        }

        private void setGul()
        {
            Gul = Year / 6;
        }


        internal string DayTypeText()
        {
            if (DayType == DayTypeHaze)
            {
                return "Den šera";
            }
            else {
                return "Den světla";
            }
        }
    }
}
