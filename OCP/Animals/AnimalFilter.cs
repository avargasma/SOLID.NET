using OCP.Interface;
using System.Collections.Generic;
using System.Linq;


namespace OCP.Animals
{
    public class AnimalFilter: IFilter<Animal>
    {
        public List<Animal> Filter(IEnumerable<Animal> items, ISpecification<Animal> specification) =>
            items.Where(o => specification.IsSatisfied(o)).ToList();
    }
}
