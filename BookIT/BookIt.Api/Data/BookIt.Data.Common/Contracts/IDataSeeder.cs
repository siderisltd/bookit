namespace BookIt.Data.Common.Contracts
{
    public interface IDataSeeder<T>
    {
        T[] SeedData();
    }
}
