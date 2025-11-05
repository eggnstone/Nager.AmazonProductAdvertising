#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Nager.AmazonProductAdvertising.Model.Paapi;

public class Price
{
    //public double Amount { get; set; }
    //public string? Currency { get; set; }
    //public string? DisplayAmount { get; set; }
    public Money? PricePerUnit { get; set; }
    public SavingBasis? SavingBasis { get; set; }
    //public Savings? Savings { get; set; }
}
