namespace Lab1___GenericTypeMy
{
    class Creating1: IDescriptor1<Car>
    {
        public Car CreateCar()
        {
            return new Car();
        }
    }
}
