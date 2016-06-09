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
        /// </summary>
        /// <param name="gtinOrEan">Barcode in GTIN / EAN format</param>
        /// <returns>Async task with the Product</returns>
        Task<Product> GetProductByBarCodeAsync(string gtinOrEan);
    }
}
