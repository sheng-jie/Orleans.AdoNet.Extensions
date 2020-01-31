using System.Threading.Tasks;

namespace Orleans.SqlServer.Grains
{
    public class HelloGrain:Grain,IHelloGrain
    {
        public Task<string> SayHi(string text)
        {
            var username = this.GetPrimaryKeyString();
            return Task.FromResult($"{username}: {text}!");
        }
    }
}