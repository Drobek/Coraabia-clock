using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoraabiaTime
{
    class DateConverter
    {
        private DateTime human;
        private CoraabiaDate coraabian;
        private Label coraabHourLabel;
        private Label coraabDayLabel;
        private Label coraabEraLabel;
        private Label coraabYearLabel;
        private Label coraabGulLabel;
        private DateTimePicker humanDate;

        public DateConverter(DateTime h, CoraabiaDate c, Label ch, Label cd, Label ce, Label cy, Label cg, DateTimePicker hd) 
        {
            human = h;
            coraabian = c;
            coraabHourLabel = ch;
            coraabDayLabel = cd;
            coraabEraLabel = ce;
            coraabYearLabel = cy;
            coraabGulLabel = cg;
            humanDate = hd;
        }

        public void setHuman() {
            
        }
    }
}
