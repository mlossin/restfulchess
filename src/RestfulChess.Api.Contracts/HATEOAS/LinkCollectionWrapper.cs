using System;
using System.Collections.Generic;

namespace RestfulChess.Api.Contracts.HATEOAS
{
    /// <summary>
    /// Collection of typed HATEOAS links
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkCollectionWrapper<T> : LinkResourceBase
    {
        public List<T> Values { get; set; } = new List<T>();
        public LinkCollectionWrapper()
        {
            Values = new List<T>();
        }
        public LinkCollectionWrapper(List<T> values)
        {
            Values = values ?? throw new ArgumentNullException(nameof(values));
        }
    }
}
