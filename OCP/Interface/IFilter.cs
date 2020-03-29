using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.Interface
{
    public interface IFilter<T>
    {
        List<T> Filter(IEnumerable<T> items, ISpecification<T> specification);
    }
}
