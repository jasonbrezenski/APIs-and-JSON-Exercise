using Newtonsoft.Json.Linq;

namespace APIsAndJSON;

public class QuoteGenerator
{
    public static void KanyeQuote()
    {
        var client = new HttpClient();

        var kanyeUrl = "https://api.kanye.rest";

        var kanyeResponseJson = client.GetStringAsync(kanyeUrl).Result;

        var kanyeQuote = JObject.Parse(kanyeResponseJson)["quote"].ToString();

        Console.WriteLine($"Kanye: {kanyeQuote}");
        Console.WriteLine("---------------");
    }

    public static void RonQuote()
    {
        var client = new HttpClient();

        var ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

        var ronResponseJson = client.GetStringAsync(ronUrl).Result;
        
        var ronQuote = JArray.Parse(ronResponseJson).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

        Console.WriteLine($"Ron: {ronQuote}");
        Console.WriteLine("---------------");
    }

    public static void Conversation()
    {
        for (int i = 0; i < 5; i++)
        {
            KanyeQuote();

            RonQuote();
        }
    }
}