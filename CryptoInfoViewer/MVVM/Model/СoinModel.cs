using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoInfoViewer.MVVM.Model
{
    internal class СoinModel
    {
        public string Image { get; set; }
        public long TotalVolume { get; set; }
        public decimal PriceChange24h { get; set; }    
        public decimal PriceChangePercentage24h { get; set; }
    }
}
