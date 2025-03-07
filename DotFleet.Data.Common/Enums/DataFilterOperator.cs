namespace DotFleet.Data.Common.Enums;

public enum DataFilterOperator : byte
{
    Equals = 1,
    Contains = 2,
    GreaterThan = 3,
    GreaterThanEquals = 4,
    LessThan = 5,
    LessThanEquals = 6,
    StartsWith = 7,
    EndsWith = 8,
    Like = 9,
}