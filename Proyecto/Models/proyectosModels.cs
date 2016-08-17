using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class proyectosModels
    {

        [Key]
        [Column(Order = 1)]
        public int ID { get; set; }

        public string nombreproyecto { get; set; }
        public string descripcionProyecto { get; set; }
        //public int usuarioID { get; set; }
        public int tareaID { get; set; }


        public virtual tareasModels tareasModels { get; set; }

    }
}