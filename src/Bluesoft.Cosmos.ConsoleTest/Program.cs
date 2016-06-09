using System;
using Bluesoft.Cosmos;

namespace Bluesoft.Cosmos.ConsoleTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CosmosClient client = new CosmosClient(CosmosEndpoint.BR, "rgDjJMCMx9-IjX-2eAhaXg");


            var productTask = client.GetProductByBarCodeAsync("7891910000197");

            var product = productTask.Result;

            Console.WriteLine(product.Description);
            Console.WriteLine(product.Price);
        }
    }
}
