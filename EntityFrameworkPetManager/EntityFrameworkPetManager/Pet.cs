using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPetManager
{
    [Table("Pets")] //Data Annotation para renombrar el nombre de la tabla
    public class Pet
    {
        [Key] //Data Annotation para indicarle a EF cual es mi PK
        public int MiIdentificadorGenial { get; set; }
        public string Name { get; set; }
        public string HairColor { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        // 1) Relacion 1-N 
        // 2) Ponemos virtual para habilitar el Lazy Loading
        public virtual List<Person> Owners { get; set; }

        // 1) Relacion N-1 
        // 2) Ponemos virtual para habilitar el Lazy Loading
        public virtual Breed Breed { get; set; }
    }
}
