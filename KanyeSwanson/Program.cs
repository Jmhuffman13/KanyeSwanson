using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeSwanson
{
    public class Program
    {
        static void Main(string[] args)
        {
            RandomQuote.KanyeQuote();

            RandomQuote.SwansonQuote();
        }
    }
}
