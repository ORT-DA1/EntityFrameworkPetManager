using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPetManager
{
    class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person
            {
                Email = "gabriel@gabriel.com",
                Address = "Hola 123",
                Name = "Gabriel"
            };

            var breed = new Breed
            {
               Name = "Pug",
               LikesChildren = true,
               LikesStrangers = false,
               AdaptsToApartment = true,
               HairType = "short",
               AmountOfExpectedYearsToLive = 10
            };

            var pet = new Pet
            {
                Age = 5,
                Name = "Doug the Pug",
                Weight = 10.4,
                HairColor = "Fawn",
                Owners = new List<Person> { person },
                Breed = breed
            };

            using (var context = new PetManagerContext())
            {
                context.Pets.Add(pet); //Agrega a la mascota y a sus entidades relacionadas
                context.SaveChanges();
            } // El contexto muere. Cuando termina el using se ejecuta el metodo Dispose() del contexto (lo trae la clase DbContext). 

            // Inicializamos un nuevo contexto que tiene todos sus DbSets vacios (las "tablas en memoria" van a estar vacias)
            // Esto es porque el contexto es nuevo, y todavia no conoce lo que hay en la base
            using (var context = new PetManagerContext()) 
            {
                List<Pet> pets = context.Pets.ToList(); //va a disparar una nueva consulta a la base y le va obtener las mascotas
                foreach (var aPet in pets)
                {
                    PrintPetInfo(aPet); //mostramos informacion de la mascota y su raza
                    PrintPetOwnersInfo(aPet); //mostramos informacion de sus dueños
                }
            }
            Console.ReadKey();
        }

        private static void PrintPetOwnersInfo(Pet pet)
        {
            List <Person> owners = pet.Owners;
            if (owners != null && owners.Any())
            {
                Console.WriteLine($"La mascota de ID tiene {pet.Owners.Count} dueño/s !");
            }
            else
            {
                Console.WriteLine($"La mascota de ID {pet.MiIdentificadorGenial} no tiene dueño. Alguien que la adopte!");
            }
        }

        private static void PrintPetInfo(Pet pet)
        {
            Console.WriteLine($"La mascota de nombre {pet.Name}, tiene {pet.Age} años, y el pelo de color: {pet.HairColor}.");
            if (pet.Breed != null)
            {
                Console.WriteLine($"Su raza es {pet.Breed.Name}, donde tiene un tipo de pelo {pet.Breed.HairType}.");
            } else
            {
                Console.WriteLine($"No se le asignó ninguna raza... Tal vez sea cruza (?");
            }
        }
    }
}
