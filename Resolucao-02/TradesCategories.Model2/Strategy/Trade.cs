using System.Collections.Generic;
using TradesCategories.Models2.Interfaces;

namespace TradesCategories.Model2.Strategy
{
    public class Trade : ITrade
    {
        private readonly double _value;
        private readonly string _clientSector;

        public double Value => _value;

        public string ClientSector => _clientSector;

        public Trade(double value, string clientSector)
        {
            _value = value;
            _clientSector = clientSector;
        }

        public string GetClientCategoty()
        {
            string value = string.Empty;
            foreach (var strategy in getStrategies())
            {
                value = strategy.GetClientCategoty(Value, ClientSector);
                if (value != string.Empty) return value;
            }

            return "NO CATEGORY";
        }

        private IList<TradeStrategy> getStrategies()
        {
            IList<TradeStrategy> strategies = new List<TradeStrategy>()
            {
                new LowRiscStrategy(),
                new MediunRisckStrategy(),
                new HighRiskStrategy()
            };

            return strategies;
        }       
    }
}
