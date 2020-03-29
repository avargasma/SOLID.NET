using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.Interface
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }
}
