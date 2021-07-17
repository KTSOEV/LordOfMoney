using System;
using System.Collections.Generic;
using System.Text;
using MyLibrary;

namespace LordOfMoneyConsole
{
    // остаток от дохода до конца месяца
    class SalaryBalance
    {
        private decimal _sum = 0;
        private int _day = 0;
        private int _deltaDays = 0;
        private decimal _everyDayBalance = 0;

        private List<EveryDayBalanceTableItem> _table = new List<EveryDayBalanceTableItem>();

        public SalaryBalance(decimal sum)
        {
            _sum = sum;

            _day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            int daysInCurrentMonth = DateTime.DaysInMonth(year, month);

            _deltaDays = daysInCurrentMonth - _day + 1;
            _everyDayBalance = _sum / _deltaDays;

            DateTime dtNow = DateTime.Now;
            
            // debug
            // dtNow = new DateTime(2021, 7, 1);
            // end debug
            
            DateTime dtPlusOne = dtNow;

            int i = 0;
            do
            {
                EveryDayBalanceTableItem _ti = new EveryDayBalanceTableItem();

                _ti.DateOfCurrentMounth = dtPlusOne.Date;
                _ti.Value = _everyDayBalance;
                _table.Add(_ti);

                dtPlusOne = dtPlusOne.AddDays(1);
                i++;

            } while (i < _deltaDays);

        }

        public decimal Sum
        {
            get => _sum;
            set
            {
                _sum = value;
            }
        }

        public int DelatDays
        {
            get => _deltaDays;
        }

        public List<EveryDayBalanceTableItem> Table
        {
            get => _table;
        }
        public void PrintTable()
        {
            foreach (EveryDayBalanceTableItem ti in _table)
            {
                DateTime dt = ti.DateOfCurrentMounth;
                Library.PrintGreen(dt.Date.ToShortDateString());
                Console.Write("\t");
                Console.WriteLine($"{ ti.Value, 0:C2}");
            }
        }

    }
}
