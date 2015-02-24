namespace Lab1___GenericTypeMy
{
    class Descriptor1 : IDescriptor<Car>
    {
        public int GetDescription(Car car)
        {
            return car.Model;
        }
    }
}
