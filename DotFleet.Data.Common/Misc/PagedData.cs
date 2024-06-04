namespace DotFleet.Data.Common.Misc;

public record PagedData<T>(ICollection<T> Payload, int TotalCount);