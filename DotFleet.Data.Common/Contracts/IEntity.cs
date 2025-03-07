namespace DotFleet.Data.Common.Contracts;

public interface IEntity<TKey>
    where TKey : IEquatable<TKey>
{
    public TKey Id { get; init; }
}
