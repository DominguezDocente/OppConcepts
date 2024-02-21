using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts
{
    public  class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = CheckMonth(month);
            _day = CheckDay(day, month, year);
        }

        private int CheckDay(int day, int month, int year)
        {
            int[] daysPerMonths = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (month == 2 && day == 29)
            {
                if (IsLeapYear(year))
                {
                    return day;
                }
            }

            if (day > 0 && day <= daysPerMonths[month])
            {
                return day;
            }

            throw new InvalidDateException($"Día inválido: {day}");
        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
        }

        private int CheckMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }

            throw new InvalidDateException($"Mes inválido: {month}" );
        }

        public override string ToString()
        {
            return $"{_year}/{_month:00}/{_day:00}";
        }
    }
}
