using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using Bluesoft.Cosmos.Models;
using System.Net.Http.Headers;

namespace Bluesoft.Cosmos
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".

    /// <summary>
    /// Main class, used to acess the Bluesoft Cosmos API
    /// </summary>
    public class CosmosClient :
        ICosmosAPI

    {


        internal const string OperationPathGTINS = "gtins/";


        /// <summary>
        /// The HTTPClient that recieve the API RESTFUL response
        /// </summary>
        protected HttpClient HttpClient { get; set; }

        /// <summary>
        /// The JSON Serializer
        /// </summary>
        protected DataContractJsonSerializer Serializer { get; set; }


        /// <summary>
        /// Authentication Token to Client
        /// </summary>
        protected string AuthenticationToken { get; set; }

        /// <summary>
        /// Endpoint (EN or BR) to use
        /// </summary>
        protected CosmosEndpoint Endpoint { get; set; }

        /// <summary>
        /// Instance the client passing the Authentication Token
        /// </summary>
        /// <param name="endpoint">Endpoint (EN or BR) to use</param>
        /// <param name="authenticationToken">token string, provided by the Bluesoft</param>
        public CosmosClient(CosmosEndpoint endpoint, string authenticationToken)
        {
            AuthenticationToken = authenticationToken;
            Endpoint = endpoint;

            HttpClient = new HttpClient();
            HttpClient.DefaultRequestHeaders.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.AcceptEncoding.Clear();
            HttpClient.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("UTF-8"));
            HttpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            HttpClient.DefaultRequestHeaders.Add("X-Cosmos-Token", AuthenticationToken);


        }
        /// <summary>
        /// Retrieves product details via the GTIN / EAN informed.
        /// </summary>
        /// <param name="gtinOrEan">Barcode in GTIN / EAN format</param>
        /// <returns>Async task with the Product</returns>
        public async Task<Product> GetProductByBarCodeAsync(string gtinOrEan)
        {
            var streamTask = HttpClient.GetStreamAsync(Endpoint.Url + OperationPathGTINS + gtinOrEan);

            var str = await HttpClient.GetStringAsync(Endpoint.Url + OperationPathGTINS + gtinOrEan);

            var stream = await streamTask;

            Serializer = new DataContractJsonSerializer(typeof(Product));

            var product = (Product)Serializer.ReadObject(stream);

            return product;


        }


    }
}
