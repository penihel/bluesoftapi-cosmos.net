using System.Runtime.Serialization;

namespace Bluesoft.Cosmos.Models
{
    /// <summary>
    /// Product Brand
    /// </summary>
    [DataContract]
    public class Brand
    {
        /// <summary>
        /// Name's Brand
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Picture absolute brand url (optional)
        /// </summary>
        [DataMember(Name = "picture")]
        public string PictureUrl { get; set; }

    }
}
