using System.Threading.Tasks;

namespace Orleans.AdoNet.SqlServer.Test.Grains
{
    public interface IInventoryGrain : IGrainWithStringKey
    {
        Task Set(int qty);
        Task Add(int qty);

        Task<bool> Decrease(int qty);

        Task<int> GetInventory();
    }
}