using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketAutomation.Interfaces;

namespace MarketAutomation.Classes
{
    public class Money : Interfaces.IMoney
    {
        int IMoney.ConvertToDollar(int tl)
        {
            int value = tl * 29;
            return value;
        }

        int IMoney.ConvertToEuro(int tl)
        {
            int value = tl * 32;
            return value;
        }

        int IMoney.ConvertToPound(int tl)
        {
            int value = tl * 37;
            return value;
        }
        int IMoney.ConvertToTl(int tl)
        {
            int value = tl * 1;
            return value;
        }
    }
}
