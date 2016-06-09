using System.Runtime.Serialization;

namespace Bluesoft.Cosmos.Models
{
    /// <summary>
    /// Commercial Unit of GTIN
    /// </summary>
    [DataContract]
    public class CommercialUnit
    {
        /// <summary>
        /// The type_packaging
        /// </summary>
        [DataMember(Name = "type_packaging")]
        public string TypePackaging { get; set; }

        /// <summary>
        /// The quantity_packaging
        /// </summary>
        [DataMember(Name = "quantity_packaging")]
        public int QuantityPackaging { get; set; }


        /// <summary>
        /// The ballast
        /// </summary>
        [DataMember(Name = "ballast")]
        public string Ballast { get; set; }

        /// <summary>
        /// The layer
        /// </summary>
        [DataMember(Name = "layer")]
        public string Layer { get; set; }
    }
}
