namespace Bluesoft.Cosmos
{
    /// <summary>
    /// Option of Endpoint to API
    /// </summary>
    public class CosmosEndpoint
    {
        private CosmosEndpoint()
        {

        }

        private static CosmosEndpoint _br;
        private static CosmosEndpoint _en;

        /// <summary>
        /// Endpoint using the pt-BR results
        /// </summary>
        public static CosmosEndpoint BR => _br ?? (_br = new CosmosEndpoint
        {
            Url = "https://cosmos.bluesoft.com.br/api/"
        });

        /// <summary>
        /// Endpoint using the en-US results
        /// </summary>
        public static CosmosEndpoint EN => _en ?? (_en = new CosmosEndpoint
        {
            Url = "https://cosmos.bluesoft.io/api/"
        });

        /// <summary>
        /// Url of EndPoint
        /// </summary>
        public string Url { get; set; }


    }
}
