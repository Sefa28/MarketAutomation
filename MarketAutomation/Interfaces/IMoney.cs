using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAutomation.Interfaces
{
    public interface IMoney
    {
        int ConvertToDollar(int tl);
        int ConvertToEuro(int tl);
        int ConvertToPound(int tl);
        int ConvertToTl(int tl);
    }
}
