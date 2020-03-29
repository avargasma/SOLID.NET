using OCP.Animals.Enum;
using OCP.Interface;

namespace OCP.Animals
{
    public class AnimalClassAndOrderSpecification : ISpecification<Animal>
    {
        private readonly AnimalClass _animalClass;
        private readonly AnimalOrder _animalOrder;
        public AnimalClassAndOrderSpecification(AnimalClass @animalClass, AnimalOrder @animalOrder)
        {
            _animalClass = @animalClass;
            _animalOrder = @animalOrder;
        }

        public bool IsSatisfied(Animal item) => item.Class == _animalClass && item.Order == _animalOrder;
    }
}
