using System.Threading.Tasks;
using Bluesoft.Cosmos.Models;

namespace Bluesoft.Cosmos
{
    /// <summary>
    /// Represents the operations avaliable in the API
    /// </summary>
    internal interface ICosmosAPI
    {
        /// <summary>
        /// Retrieves product details via the GTIN / EAN informed.
        /// https://cosmos.bluesoft.io/api/gtins/{code}
        /// </summary>
        /// <param name="gtinOrEan">Barcode in GTIN / EAN format</param>
        /// <returns>Async task with the Product</returns>
        Task<Product> GetProductByBarCodeAsync(string gtinOrEan);


        /// <summary>
        /// Retrieve GPC details and products linked to it, through the informed code.
        /// https://cosmos.bluesoft.io/api/gpcs/{code}
        /// </summary>
        /// <param name="gpc">GPC code</param>
        /// <param name="pageNumber">Page of products list</param>
        /// <returns>
        /// Retrieve GPC details and products linked to it, through the informed code.
        /// </returns>
        Task<GPC> GetProductsByGlobalProductClassificationAsync(string gpc, int pageNumber);
    }
}
