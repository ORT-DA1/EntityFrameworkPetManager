using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPetManager
{
    [Table("PetBreeds")]
    public class Breed
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HairType { get; set; }
        public int AmountOfExpectedYearsToLive { get; set; }
        public bool LikesChildren { get; set; }
        public bool LikesStrangers { get; set; }
        public bool AdaptsToApartment { get; set; }
    }
}
