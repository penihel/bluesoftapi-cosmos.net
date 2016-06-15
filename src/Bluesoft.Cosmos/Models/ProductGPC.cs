using System.Runtime.Serialization;

namespace Bluesoft.Cosmos.Models
{
    /// <summary>
    /// Global Product Classification (GPC)
    /// </summary>
    [DataContract]
    public class ProductGPC
    {
        /// <summary>
        /// The GPC Code
        /// </summary>
        [DataMember(Name = "code")]
        public string Code { get; set; }


        /// <summary>
        /// The GPC description
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
}
