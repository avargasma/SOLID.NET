using OCP.Interface;
using OCP.Animals.Enum;

namespace OCP.Animals
{
    public class AnimalOrderSpecification : ISpecification<Animal>
    {
        private readonly AnimalOrder _animalOrder;
        public AnimalOrderSpecification(AnimalOrder @animalOrder)
        {
            _animalOrder = @animalOrder;
        }

        public bool IsSatisfied(Animal item) => item.Order == _animalOrder;
    }
}
