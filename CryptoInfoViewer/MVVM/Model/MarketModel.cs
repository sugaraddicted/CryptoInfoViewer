using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoInfoViewer.MVVM.Model
{
    internal class MarketModel
    {
        public string Name { get; set; }
        public string Identifier { get; set; }
        public bool HasTradingIncentive { get; set; }
    }
}
