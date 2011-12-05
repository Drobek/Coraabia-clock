using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoraabiaTime
{
    class CoraabiaDate
    {
        public static int DayTypeLight = 1;
        public static int DayTypeHaze = 2;
        public int Gul = 710;
        public int Year = 4261;
        public int Era = 1;
        public int DayType = DayTypeLight; //podle dne v týdnu buď den šera (H=Haze) nebo den světla (L=Light)
        public int Hour = 0; //coraabské hodiny. Den světla (L) má 96 hodin, den šera 72 hodin. 
        //Dohromady odpovídají jednomu pozemskému týdnu
        private DateTime actTime = new DateTime(); // now pokud neni nastaveno jinak
        private static DateTime startTime = new DateTime(2011, 12, 5, 0, 0, 0); // 11.10.2011 00:00
        public String message = "";

        public void setCoraabTime()
        {
            setHour();
            setDayType();
            setEra();
            setYear();
            setGul();
        }

        public void setDate(DateTime dt)
        {
            actTime = dt;
            setCoraabTime();
        }

        public String fullString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Hour.ToString());
            sb.Append(" hour of ");
            sb.Append(Era.ToString());
            if (DayType == DayTypeLight)
            {
                sb.Append(" Light day ");
            }
            else
            {
                sb.Append(" Haze day ");
            }
            sb.Append(" Year ");
            sb.Append(Year.ToString());
            sb.Append(" (");
            sb.Append(Gul.ToString());
            sb.Append(" Gul)");
            return sb.ToString();
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
            /*StringBuilder sb = new StringBuilder();
            sb.Append("elapsed Time:");
            sb.Append(ts.ToString());
            sb.Append("\n(ts.Days: ");
            sb.Append(ts.Days.ToString());
            sb.Append("\n(ts.Days / 7: ");
            sb.Append((ts.Days / 7).ToString());*/
            Era = ((ts.Days / 7) % 8) + 1;
            /*sb.Append("\nEra: ");
            sb.Append(Era.ToString());
            message = sb.ToString();*/
        }

        private void setYear()
        {
            TimeSpan ts = elapsedTime();
            Year = (ts.Days / (7 * 8)) + 4261;
        }

        private void setGul()
        {
            Gul = Year / 6;
        }
    }
}
