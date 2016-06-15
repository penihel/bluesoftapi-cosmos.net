using System.Runtime.Serialization;

namespace Bluesoft.Cosmos.Models
{
    /// <summary>
    /// Nomenclatura Comum do MERCOSUL - NCM
    /// <see cref="http://cosmos.bluesoft.com.br/tabelas/definicao-ncm"/>
    /// </summary>
    [DataContract]
    public class ProductNCM
    {
        /// <summary>
        /// The NCM Code
        /// </summary>
        [DataMember(Name = "code")]
        public string Code { get; set; }

        /// <summary>
        /// The NCM description
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The NCM full_description
        /// </summary>
        [DataMember(Name = "full_description")]
        public string FullDescription { get; set; }
    }
}
