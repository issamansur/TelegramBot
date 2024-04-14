namespace Domain.Common;

public abstract class BaseValueObject
{
    public override bool Equals(object? obj)
    {
        // TODO: DeepCompare (DeepClone)
        return false;
    }

    public override int GetHashCode()
    {
        // TODO
        return -1;
    }
}