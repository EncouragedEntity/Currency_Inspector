using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyInspector.Models
{
    public class Markets
    {
        public ObservableCollection<MarketModel> markets { get; set; }
    }
}
