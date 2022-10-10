namespace Test
{
    public class EnumValuesProvider<T> : IMarkupExtension<T[]> where T : struct, Enum
    {
        public T[] ProvideValue(IServiceProvider serviceProvider)
        {
            return Enum.GetValues<T>();
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return ProvideValue(serviceProvider);
        }
    }
}
