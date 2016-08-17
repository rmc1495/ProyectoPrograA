using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class estadoModels
    {

        [Key]
        [Column(Order = 1)]
        public int ID { get; set; }
        public string nombreEstado { get; set; }

    }
}