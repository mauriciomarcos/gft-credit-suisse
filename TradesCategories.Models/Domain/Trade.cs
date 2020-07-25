using TradesCategories.Models.Enuns;
using TradesCategories.Models.Extensions;
using TradesCategories.Models.Interfaces;

namespace TradesCategories.Models.Domain
{
    public class Trade : ITrade
    {
        private readonly double _value;
        private readonly string _clientSector;

        public double Value => _value;

        public string ClientSector => _clientSector;

        public Trade(double value, string clienteSector)
        {
            _value = value;
            _clientSector = clienteSector;
        }

        public string GetClientCategoty(ITrade trade)
        {
            string category;

            if (trade.Value < 1_000_000 && trade.ClientSector == ClientSetorEnum.PUBLIC.RecuperaDescricaoDoEnum())
                category = CategoryEnum.LOWRISK.RecuperaDescricaoDoEnum();
            else if (trade.Value > 1_000_000 && trade.ClientSector == ClientSetorEnum.PUBLIC.RecuperaDescricaoDoEnum())
                category = CategoryEnum.MEDIUMRISK.RecuperaDescricaoDoEnum();
            else if (trade.Value > 1_000_000 && trade.ClientSector == ClientSetorEnum.PRIVATE.RecuperaDescricaoDoEnum())
                category = CategoryEnum.HIGHRISK.RecuperaDescricaoDoEnum();
            else
                category = CategoryEnum.NOCATEGORY.RecuperaDescricaoDoEnum();

            return category;
        }
    }
}
