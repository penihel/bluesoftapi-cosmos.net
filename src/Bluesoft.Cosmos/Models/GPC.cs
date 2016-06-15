using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Bluesoft.Cosmos.Models
{
    /// <summary>
    /// Global Product Classification (GPC)
    /// </summary>
    [DataContract]
    public class GPC
    {
        /// <summary>
        /// Identifier
        /// </summary>
        [DataMember(Name = "id")]
        public long Id { get; set; }

        /// <summary>
        /// The GPC Code
        /// </summary>
        [DataMember(Name = "code")]
        public string Code { get; set; }

        /// <summary>
        /// level
        /// </summary>
        [DataMember(Name = "level")]
        public long Level { get; set; }


        /// <summary>
        /// The GPC description (english_description)
        /// </summary>
        [DataMember(Name = "english_description")]
        public string Description { get; set; }

        /// <summary>
        /// The GPC description (portuguese)
        /// </summary>
        [DataMember(Name = "portuguese")]
        public string PortugueseDescription { get; set; }


        /// <summary>
        /// Parent's Identifier 
        /// </summary>
        [DataMember(Name = "parent_id")]
        public long? ParentId { get; set; }

        /// <summary>
        /// Products lists (Paged)
        /// </summary>
        [DataMember(Name = "products")]
        public List<Product> Products { get; set; }

        /// <summary>
        /// Products current page
        /// </summary>
        [DataMember(Name = "current_page")]
        public long CurrentPage { get; set; }


        /// <summary>
        /// Products per page
        /// </summary>
        [DataMember(Name = "per_page")]
        public long PerPage { get; set; }

        /// <summary>
        /// Products total ages
        /// </summary>
        [DataMember(Name = "total_pages")]
        public long TotalPages { get; set; }


        /// <summary>
        /// Products total count
        /// </summary>
        [DataMember(Name = "total_count")]
        public long TotalCount { get; set; }
    }
}
