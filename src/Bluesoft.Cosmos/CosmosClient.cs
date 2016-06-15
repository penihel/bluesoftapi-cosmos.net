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
        internal const string OperationPathGPCS = "gpcs/";


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
        /// https://cosmos.bluesoft.io/api/gtins/{code}
        /// </summary>
        /// <param name="gtinOrEan">Barcode in GTIN / EAN format</param>
        /// <returns>Async task with the Product</returns>
        public async Task<Product> GetProductByBarCodeAsync(string gtinOrEan)
        {
            var streamTask = HttpClient.GetStreamAsync(Endpoint.Url + OperationPathGTINS + gtinOrEan);

            //var str = await HttpClient.GetStringAsync(Endpoint.Url + OperationPathGTINS + gtinOrEan);

            var stream = await streamTask;

            Serializer = new DataContractJsonSerializer(typeof(Product));

            var product = (Product)Serializer.ReadObject(stream);

            return product;


        }


        /// <summary>
        /// Retrieve GPC details and products linked to it, through the informed code.
        /// https://cosmos.bluesoft.io/api/gpcs/{code}
        /// </summary>
        /// <param name="gpc">GPC code</param>
        /// <param name="pageNumber">Page of products list</param>
        /// <returns>
        /// Retrieve GPC details and products linked to it, through the informed code.
        /// </returns>
        public async Task<GPC> GetProductsByGlobalProductClassificationAsync(string gpc, int pageNumber)
        {
            var streamTask = HttpClient.GetStreamAsync(Endpoint.Url + OperationPathGPCS + gpc + "?page=" + pageNumber);

            //var str = await HttpClient.GetStringAsync(Endpoint.Url + OperationPathGPCS + gpc + "?page=" + pageNumber);

            var stream = await streamTask;

            Serializer = new DataContractJsonSerializer(typeof(GPC));

            var globalProductClassification = (GPC)Serializer.ReadObject(stream);

            return globalProductClassification;
        }
    }
}
