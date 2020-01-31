using System.Threading.Tasks;

namespace Orleans.SqlServer.Grains
{
    public interface IHelloGrain : IGrainWithStringKey
    {
        Task<string> SayHi(string text);
    }
}
