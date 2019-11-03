﻿using System.Threading.Tasks;

namespace Orleans.Grains
{
    public class HelloGrain:Grain,IHelloGrain
    {
        public Task<string> SayHi(string username)
        {
            return Task.FromResult($"Hi {username}, Welcome to Orleans!");
        }
    }
}