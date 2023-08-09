using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public enum MonthEnum
    {
        January = 30,
        February = 28,
        March = 31,
        April = 30,
        May = 31,
        June = 30,
        July = 31,
        August = 31,
        September = 30,
        November = 31,
        December = 31
    }
    public class MonthCollection : IEnumerator, IEnumerable
    {
        private int _position = -1;
        Month[] months = new Month[12];

        public MonthCollection()
        {
            FillArray();
        }
        private void FillArray()
        {
            months[0].NameOfMonth = "January";
            months[1].NameOfMonth = "February";
            months[2].NameOfMonth = "March";
            months[3].NameOfMonth = "April";
            months[4].NameOfMonth = "May";
            months[5].NameOfMonth = "June";
            months[6].NameOfMonth = "July";
            months[7].NameOfMonth = "August";
            months[8].NameOfMonth = "September";
            months[9].NameOfMonth = "October";
            months[10].NameOfMonth = "November";
            months[11].NameOfMonth = "December";

            months[0].DaysOfMonth = 30;
            months[1].DaysOfMonth = 28;
            months[2].DaysOfMonth = 31;
            months[3].DaysOfMonth = 30;
            months[4].DaysOfMonth = 31;
            months[5].DaysOfMonth = 30;
            months[6].DaysOfMonth = 31;
            months[7].DaysOfMonth = 31;
            months[8].DaysOfMonth = 30;
            months[9].DaysOfMonth = 31;
            months[10].DaysOfMonth = 30;
            months[11].DaysOfMonth = 31;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public object Current => months[_position];

        public bool MoveNext()
        {
            if (_position < months.Length - 1)
            {
                _position++;
                return true;
            }

            Reset();
            return false;

        }

        public void Reset()
        {
            _position = -1;
        }
    }


}
