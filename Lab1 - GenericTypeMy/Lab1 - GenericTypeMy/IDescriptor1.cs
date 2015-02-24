namespace Lab1___GenericTypeMy
{
    interface IDescriptor1 <out T> where T:Car
    {
        T CreateCar();
    }
}
