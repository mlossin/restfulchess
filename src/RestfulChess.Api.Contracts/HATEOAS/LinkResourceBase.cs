using System.Collections.Generic;

namespace RestfulChess.Api.Contracts.HATEOAS
{
    /// <summary>
    /// Collection of untyped HATEOAS links
    /// </summary>
    public class LinkResourceBase
    {
        public LinkResourceBase()
        {
        }

        public List<Link> Links { get; set; } = new List<Link>();
    }
}
