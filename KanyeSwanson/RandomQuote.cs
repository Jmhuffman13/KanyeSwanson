using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeSwanson
{
    public class RandomQuote
    {
        public static void KanyeQuote()
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine("--------------");
            Console.WriteLine($" Kanye: {kanyeQuote}");
            Console.WriteLine("--------------");
        }
        public static void SwansonQuote()
        {
            var client = new HttpClient();

            var swansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var swansonResponse = client.GetStringAsync(swansonURL).Result;

            var swansonQuote = JArray.Parse(swansonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine("--------------");
            Console.WriteLine($" Ron: {swansonQuote}");
            Console.WriteLine("--------------");

        }
    }
}
