using OCP.Animals;
using OCP.Animals.Enum;
using System;
using System.Collections.Generic;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal() { Name = "Perro", Class = AnimalClass.Mamiferos, Order = AnimalOrder.Omnivoro });
            animals.Add(new Animal() { Name = "Gato", Class = AnimalClass.Mamiferos, Order = AnimalOrder.Carnivoro });
            animals.Add(new Animal() { Name = "Vaca", Class = AnimalClass.Mamiferos, Order = AnimalOrder.Herbivoro });
            animals.Add(new Animal() { Name = "Cerdo", Class = AnimalClass.Mamiferos, Order = AnimalOrder.Omnivoro });
            animals.Add(new Animal() { Name = "Tigre", Class = AnimalClass.Mamiferos, Order = AnimalOrder.Carnivoro });
            animals.Add(new Animal() { Name = "Jirafa", Class = AnimalClass.Mamiferos, Order = AnimalOrder.Herbivoro });
            animals.Add(new Animal() { Name = "Paloma", Class = AnimalClass.Aves, Order = AnimalOrder.Herbivoro });

            foreach (var animal in animals)
            {
                Console.WriteLine($"Nombre: {animal.Name}, Clase: {animal.Class}, Orden: {animal.Order}");
            }

            Console.WriteLine("Aves");
            foreach (var animal in new AnimalFilter().Filter(animals, new AnimalClassSpecification(AnimalClass.Aves)))
            {
                Console.WriteLine($"Nombre: {animal.Name}, Clase: {animal.Class}, Orden: {animal.Order}");
            }

            Console.WriteLine("Herviboros");
            foreach (var animal in new AnimalFilter().Filter(animals, new AnimalOrderSpecification(AnimalOrder.Herbivoro)))
            {
                Console.WriteLine($"Nombre: {animal.Name}, Clase: {animal.Class}, Orden: {animal.Order}");
            }

            Console.WriteLine("Carnivoro y Mamifero");
            foreach (var animal in new AnimalFilter().Filter(animals, new AnimalClassAndOrderSpecification(AnimalClass.Mamiferos, AnimalOrder.Carnivoro)))
            {
                Console.WriteLine($"Nombre: {animal.Name}, Clase: {animal.Class}, Orden: {animal.Order}");
            }

            Console.ReadLine();
        }
    }
}
