using System;
using System.Threading.Tasks;

namespace Orleans.Grains
{
    public interface IHelloGrain : IGrainWithStringKey
    {
        Task<string> SayHi(string username);
    }
}
