using RestfulChess.Api.Contracts.HATEOAS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace RestfulChess.Api.Common.HATEOAS
{
    /// <summary>
    /// This class helps to write the HATEOAS links into XML
    /// </summary>
    public class XmlResponseMixer
    {
        public void WriteXml(XmlWriter writer)
        {
            foreach (var key in expando.Keys)
            {
                var value = expando[key];
                WriteLinksToXml(key, value, writer);
            }
        }

        /// <summary>
        /// If the element is a collection of links that link is separately written
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="writer"></param>
        private void WriteLinksToXml(string key, object value, XmlWriter writer)
        {
            writer.WriteStartElement(key);
            if (value.GetType() == typeof(ICollection<Link>))
            {
                foreach (var val in value as ICollection<Link>)
                {
                    writer.WriteStartElement(nameof(Link));
                    WriteLinksToXml(nameof(val.Href), val.Href, writer);
                    WriteLinksToXml(nameof(val.Method), val.Method, writer);
                    WriteLinksToXml(nameof(val.Rel), val.Rel, writer);
                    writer.WriteEndElement();
                }
            }
            else
            {
                writer.WriteString(value.ToString());
            }
            writer.WriteEndElement();
        }
    }
}
