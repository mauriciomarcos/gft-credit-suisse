using System.Collections.Generic;
using TradesCategories.Models.Interfaces;

namespace TradesCategories.Models.Strategy
{
    public class PortifolioStrategy
    {     
        public List<string> TradeCategoryResolver(IList<ITrade> trades)
        {
            List<string> categoriesList = new List<string>();

            foreach (var trade in trades)
            {
                categoriesList.Add(trade.GetClientCategoty(trade));
            }

            return categoriesList;
        }
    }
}
