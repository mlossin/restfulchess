using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace RestfulChess.Api.Contracts.Shaping
{
    /// <summary>
    /// DataShaping to give only data that was requested.
    /// Idea by https://code-maze.com/data-shaping-aspnet-core-webapi/
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDataShaper<T>
    {
        IEnumerable<ExpandoObject> ShapeData(IEnumerable<T> entities, string fieldsString);
        ExpandoObject ShapeData(T entity, string fieldsString);
    }
}
