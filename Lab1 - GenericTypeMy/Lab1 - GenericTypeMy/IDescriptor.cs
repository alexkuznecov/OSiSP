namespace Lab1___GenericTypeMy
{
    interface IDescriptor <in T> where T:Car
    {
        int GetDescription(T deskr);
    }
}
