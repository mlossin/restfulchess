using System;
using System.Collections.Generic;
using System.Text;

namespace RestfulChess.Api.Contracts.HATEOAS
{
    /// <summary>
    /// Collection of typed HATEOAS links
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkCollectionWrapper<T> : LinkResourceBase
    {
        public List<T> Value { get; set; } = new List<T>();
        public LinkCollectionWrapper()
        {
        }
        public LinkCollectionWrapper(List<T> value)
        {
            Value = value;
        }
    }
}
