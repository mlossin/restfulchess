using System;

namespace RestfulChess.Api.Contracts.HATEOAS
{
    /// <summary>
    /// Represents a link for HATEOAS to explore further api steps
    /// </summary>
    public class Link
    {
        /// <summary>
        /// Hyperreference to the Resource
        /// </summary>
        public string Href { get; set; }
        /// <summary>
        /// Optional Relation to the Resource
        /// </summary>
        public string Rel { get; set; }
        /// <summary>
        /// HTTP-Method
        /// </summary>
        public string Method { get; set; }
        public Link()
        {
        }
        public Link(string href, string rel, string method)
        {
            Href = href ?? throw new ArgumentNullException(nameof(href));
            Method = method ?? throw new ArgumentNullException(nameof(method));
            Rel = rel;
            
        }
    }
}