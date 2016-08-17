using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class tareasModels
    {

        [Key]
        [Column(Order = 1)]
        public int ID { get; set; }

        public string nombreTarea { get; set; }
        public string descripcion { get; set; }

        public DateTime tiempo { get; set; }

        public virtual ICollection<proyectosModels> proyectosModels { get; set; }


    }
}