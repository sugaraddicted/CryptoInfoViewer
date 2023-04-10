using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoInfoViewer.MVVM.Model
{
    internal class TickerModel
    {
        public MarketModel Market { get; set; }
        public decimal Last { get; set; }
    }
}
