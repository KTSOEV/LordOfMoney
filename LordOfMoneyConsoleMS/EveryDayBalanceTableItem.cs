using System;
using System.Collections.Generic;
using System.Text;

namespace LordOfMoneyConsole
{
    class EveryDayBalanceTableItem
    {
        private DateTime _date;
        private decimal _value;

        public DateTime DateOfCurrentMounth
        {
            get => _date.Date;
            set => _date = value;
        }

        public decimal Value
        {
            get => _value;
            set => _value = value;
        }
    }

    
}
