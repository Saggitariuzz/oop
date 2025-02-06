using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class DateException:Exception
    {
        public DateException(DateTime _startdate, DateTime _enddate)
            :base($"Дата должна находиться в пределах от " +
                 $"{_startdate.ToString("dd.MM.yyyy")} до {_enddate.ToString("dd.MM.yyyy")}")
        { }
    }
}
