namespace Lab1___GenericTypeMy
{
    class Description2 : IDescriptor<Hatchback>
    {
        public int GetDescription(Hatchback hatchback)
        {
            return hatchback.Model + hatchback.WipersCount;
        }
    }
}
