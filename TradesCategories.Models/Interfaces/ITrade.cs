namespace TradesCategories.Models.Interfaces
{
    public interface ITrade : ITradeStrategy
    {
        double Value { get; }
        string ClientSector { get; }
    }
}