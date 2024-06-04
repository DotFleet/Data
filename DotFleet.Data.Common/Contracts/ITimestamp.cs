namespace DotFleet.Data.Common.Contracts;

public interface ITimestamp
{
    public DateTime CreatedAtUtc { get; set; }
    public DateTime? UpdatedAtUtc { get; set; }
}