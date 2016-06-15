using System.Runtime.Serialization;

namespace Bluesoft.Cosmos.Models
{
    /// <summary>
    /// Global Trade Item Number (GTIN) 
    /// <see cref="http://www.gs1.org/gtin"/>
    /// </summary>
    [DataContract]
    public class ProductGTIN
    {
        /// <summary>
        /// The gtin Code
        /// </summary>
        [DataMember(Name = "gtin")]
        public string GTIN { get; set; }


        /// <summary>
        /// commercial_unit
        /// </summary>
        [DataMember(Name = "commercial_unit")]
        public CommercialUnit CommercialUnit { get; set; }
    }
}
