namespace TradesCategories.Model2.Strategy
{
    public class LowRiscStrategy : TradeStrategy
    {     
        public override string GetClientCategoty(double value, string clientSector)
        {
            string riskReturn = string.Empty;
            if (value < 1_000_000 && clientSector == "Public")
                riskReturn = "LOWRISC";

            return riskReturn;
        }
    }
}
