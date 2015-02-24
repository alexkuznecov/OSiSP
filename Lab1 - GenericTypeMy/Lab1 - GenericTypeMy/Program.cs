namespace Lab1___GenericTypeMy
{
    class Program
    {
        static void Main(string[] args)
        {
            IDescriptor<Car> desk1 = new Descriptor1();
            IDescriptor<Hatchback> desk2 = new Description2();

            //desk1 = desk2;
            desk2 = desk1;

            IDescriptor1<Car> create1 = new Creating1();
            IDescriptor1<Hatchback> create2 = new Creating2();

            create1 = create2;
            //create2 = create1;
        }
    }
}
