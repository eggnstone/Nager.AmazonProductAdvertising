#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Nager.AmazonProductAdvertising.Model.Paapi;

public class SavingBasisOfOffersV1
{
    public double Amount { get; set; }
    public string? Currency { get; set; }
    public string? DisplayAmount { get; set; }
    public string? PriceType { get; set; }
    public string? PriceTypeLabel { get; set; }
    public double PricePerUnit { get; set; }
}
