using OCP.Interface;
using OCP.Animals.Enum;

namespace OCP.Animals
{
    public class AnimalClassSpecification : ISpecification<Animal>
    {
        private readonly AnimalClass _animalClass;
        public AnimalClassSpecification(AnimalClass @animalClass)
        {
            _animalClass = @animalClass;
        }

        public bool IsSatisfied(Animal item) => item.Class == _animalClass;
    }
}
