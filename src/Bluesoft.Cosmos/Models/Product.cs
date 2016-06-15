using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Bluesoft.Cosmos.Models
{
    /// <summary>
    /// Represents a product retrieve from de Cosmos API.
    /// A product is the main Model to this Library
    /// </summary>

    [DataContract]
    public class Product
    {
        /// <summary>
        /// Description of the product name
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// GTIN Barcode
        /// </summary>
        [DataMember(Name = "gtin")]
        public string Barcode { get; set; }

        /// <summary>
        /// Thumbnail URL
        /// </summary>
        [DataMember(Name = "thumbnail")]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// Price returned from the API
        /// </summary>
        [DataMember(Name = "price")]
        public string Price { get; set; }

        /// <summary>
        /// Average Price returned from the API
        /// </summary>
        [DataMember(Name = "avg_price")]
        public decimal? AveragePrice { get; set; }


        /// <summary>
        /// Max Price returned from the API
        /// </summary>
        [DataMember(Name = "max_price")]
        public decimal? MaxPrice { get; set; }

        /// <summary>
        /// Min Price returned from the API
        /// </summary>
        [DataMember(Name = "min_price")]
        public decimal? MinPrice { get; set; }


        /// <summary>
        /// Width returned from the API
        /// </summary>
        [DataMember(Name = "width")]
        public decimal? Width { get; set; }

        /// <summary>
        /// Height returned from the API
        /// </summary>
        [DataMember(Name = "height")]
        public decimal? Height { get; set; }

        /// <summary>
        /// Length returned from the API
        /// </summary>
        [DataMember(Name = "length")]
        public decimal? Length { get; set; }

        /// <summary>
        /// net_weight returned from the API
        /// </summary>
        [DataMember(Name = "net_weight")]
        public decimal? NetWeight { get; set; }


        /// <summary>
        /// gross_weight returned from the API
        /// </summary>
        [DataMember(Name = "gross_weight")]
        public decimal? GrossWeight { get; set; }

        /// <summary>
        /// Product Brand
        /// </summary>
        [DataMember(Name = "brand")]
        public Brand Brand { get; set; }

        /// <summary>
        ///  Global Product Classification (GPC)
        /// </summary>
        [DataMember(Name = "gpc")]
        public ProductGPC GPC { get; set; }


        /// <summary>
        ///  Nomenclatura Comum do MERCOSUL - NCM
        /// </summary>
        [DataMember(Name = "ncm")]
        public ProductNCM NCM { get; set; }


        /// <summary>
        ///  GTINs list
        /// </summary>
        [DataMember(Name = "gtins")]
        public List<ProductGTIN> GTINs { get; set; }






    }
}
