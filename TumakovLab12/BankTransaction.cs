using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLab12
{
    public class BankTransaction
    {
        public readonly DateTime DateTime;
        public readonly decimal Sum;
        internal BankTransaction(DateTime dateTime, decimal sum)
        {
            DateTime = dateTime;
            Sum = sum;
        }
    }
}
