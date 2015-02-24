namespace Lab1___GenericTypeMy
{
    class Creating2: IDescriptor1<Hatchback>
    {
        public Hatchback CreateCar()
        {
            return new Hatchback();
        }
    }
}
